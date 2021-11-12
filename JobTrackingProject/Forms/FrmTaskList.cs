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
    public partial class FrmTaskList : Form
    {
        public FrmTaskList()
        {
            InitializeComponent();
        }
        DbJobTrackingEntities db = new DbJobTrackingEntities();

        private void FrmTaskList_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = (from x in db.TblTask
                select new
                {
                    Açıklama = x.Satement
                }).ToList();

            LblActiveTask.Text = db.TblTask.Where(x => x.Status == true).Count().ToString();
            LblPassiveTask.Text = db.TblTask.Where(x => x.Status == false).Count().ToString();
            LblTotalDepartment.Text = db.TblDepartments.Count().ToString();

            chartControl1.Series["State1"].Points.AddPoint("Aktif Görevler", int.Parse(LblActiveTask.Text));
            chartControl1.Series["State1"].Points.AddPoint("Pasif Görevler", int.Parse(LblPassiveTask.Text));

        }

        private void labelControl3_Click(object sender, EventArgs e)
        {

        }

        private void labelControl2_Click(object sender, EventArgs e)
        {

        }
    }
}
