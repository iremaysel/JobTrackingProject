using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using JobTrackingProject.Entity_Framework;

namespace JobTrackingProject.Forms
{
    public partial class FrmTask : Form
    {
        public FrmTask()
        {
            InitializeComponent();
        }

        private void FrmTask_Load(object sender, EventArgs e)
        {
            var values = (from x in db.TblEmployee
                select new
                {
                    x.ID,
                    AdSoyad = x.Name +" "+ x.Surname
                }).ToList();
            LueGetTask.Properties.ValueMember = "ID";
            LueGetTask.Properties.DisplayMember = "AdSoyad";
            LueGetTask.Properties.DataSource = values;
        }

        private void BtnGiveUp_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        DbJobTrackingEntities db = new DbJobTrackingEntities();
        private void BtnSave_Click(object sender, EventArgs e)
        {
            TblTask t = new TblTask();
            t.Satement = TxtDescription.Text;
            t.Status = true;
            t.GetTask = int.Parse(LueGetTask.EditValue.ToString());
            t.Dates = DateTime.Parse(TxtDates.Text);
            t.GiveTask = int.Parse(TxtGiveTesk.Text);
            db.TblTask.Add(t);
            db.SaveChanges();
            XtraMessageBox.Show("Görev başarılı bir şekilde tanımlandı.", "Bilgi", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }
}
