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

namespace JobTrackingProject.EmployeeTaskForms
{
    public partial class FrmActiveTasks : Form
    {
        public FrmActiveTasks()
        {
            InitializeComponent();
        }

        DbJobTrackingEntities db = new DbJobTrackingEntities();
        public string email2;

        private void FrmActiveTasks_Load(object sender, EventArgs e)
        {
            var employeeID = db.TblEmployee.Where(x => x.Email == email2).Select(y => y.ID).FirstOrDefault();
            
            var values = (from x in db.TblTask
                          select new
                          {
                              x.ID,
                              Açıklama = x.Satement,
                              Tarih = x.Dates,
                              GörevAlan = x.GetTask,
                              Durum = x.Status
                          }).Where(y => y.GörevAlan == employeeID && y.Durum == true).ToList();
            gridControl1.DataSource = values;

            gridView1.Columns["GörevAlan"].Visible = false;
            gridView1.Columns["Durum"].Visible = false;

        }
    }
}
