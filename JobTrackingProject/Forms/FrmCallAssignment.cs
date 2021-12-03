using DevExpress.XtraEditors;
using JobTrackingProject.Entity_Framework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JobTrackingProject.Forms
{
    public partial class FrmCallAssignment : Form
    {
        public FrmCallAssignment()
        {
            InitializeComponent();
        }

        public int id;

        DbJobTrackingEntities db = new DbJobTrackingEntities();
        private void FrmCallAssignment_Load(object sender, EventArgs e)
        {
            var values = (from x in db.TblEmployee
                          select new
                          {
                              x.ID,
                              AdSoyad = x.Name + " " + x.Surname
                          }).ToList();
            LueGetTask.Properties.ValueMember = "ID";
            LueGetTask.Properties.DisplayMember = "AdSoyad";
            LueGetTask.Properties.DataSource = values;            
            TxtCallid.Text = id.ToString();
            var data = db.TblCall.Find(id);
            TxtSubject.Text = data.CallSubject;
            TxtDescription.Text = data.CallStatement;       
            TxtDates.Text = data.CallDate.ToString();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            var data = db.TblCall.Find(id);
            data.CallSubject = TxtSubject.Text;
            data.CallStatement = TxtDescription.Text;
            data.CallDate = DateTime.Parse(TxtDates.Text);
            data.CallEmployee = int.Parse(LueGetTask.EditValue.ToString());
            db.SaveChanges();
            XtraMessageBox.Show("Görev başarılı bir şekilde yönlendirildi.", "Bilgi", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            this.Close();
        }
    }
}
