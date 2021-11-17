using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JobTrackingProject.Entity_Framework;

namespace JobTrackingProject.Forms
{
    public partial class FrmMainForm : Form
    {
        public FrmMainForm()
        {
            InitializeComponent();
        }

        DbJobTrackingEntities db = new DbJobTrackingEntities();
        private void FrmMainForm_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = (from x in db.TblTask
                                       select new
                                       {
                                           Durum = x.Status,
                                           Açıklama = x.Satement,
                                           Personel = x.TblEmployee.Name + " " + x.TblEmployee.Surname
                                       }).Where(y => y.Durum == true).ToList();
            gridView1.Columns["Durum"].Visible = false;

            // Tasks done today
            DateTime today = DateTime.Parse(DateTime.Now.ToShortDateString());
            gridControl2.DataSource = (from x in db.TblTaskDetail
                                       select new
                                       {
                                           Görev = x.TblTask.Satement,
                                           Açıklama = x.Statement,
                                           Tarih = x.Dates
                                       }).Where(x => x.Tarih == today).ToList();
            gridView2.Columns["Tarih"].Visible = false;

            // active call list

            gridControl3.DataSource = (from x in db.TblCall
                                       select new
                                       {
                                           FirmaAdı = x.TblCompanies.Name,
                                           ÇağrıKonusu = x.CallSubject,
                                           ÇağrıTarihi = x.CallDate,
                                           ÇağrıDurum = x.CallStatus
                                       }).Where(x => x.ÇağrıDurum == true).ToList();
            gridView3.Columns["ÇağrıDurum"].Visible = false;
        }
    }
}
