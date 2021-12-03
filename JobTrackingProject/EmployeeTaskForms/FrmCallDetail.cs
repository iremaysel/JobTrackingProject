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

namespace JobTrackingProject.EmployeeTaskForms
{
    public partial class FrmCallDetail : Form
    {
        public FrmCallDetail()
        {
            InitializeComponent();
        }

        public int id;
        DbJobTrackingEntities db = new DbJobTrackingEntities();

        private void BtnGiveUp_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmCallDetail_Load(object sender, EventArgs e)
        {
            TxtCallID.Enabled = false;
            TxtCallID.Text = id.ToString();
            string clocks, dates;
            dates = DateTime.Now.ToShortDateString();
            clocks = DateTime.Now.ToShortTimeString();
            TxtDates.Text = dates;
            TxtClock.Text = clocks;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            TblCallDetail t = new TblCallDetail();
            t.DetailCall = int.Parse(TxtCallID.Text);
            t.DetailClock = TxtClock.Text;
            t.DetailDate = DateTime.Parse(TxtDates.Text);
            t.DetailStatement = TxtDescription.Text;
            db.TblCallDetail.Add(t);
            db.SaveChanges();
            XtraMessageBox.Show("Çağrı Detayları Başarıyla Eklendi!");
            this.Close();




        }
    }
}
