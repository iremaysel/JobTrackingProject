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

        void ToListTask()
        {
            var values = (from x in db.TblTask
                select new
                {
                    x.Satement
                }).ToList();
            gridControl1.DataSource = values;

        }

        private void FrmTaskList_Load(object sender, EventArgs e)
        {
            ToListTask();
        }

        private void labelControl3_Click(object sender, EventArgs e)
        {

        }

        private void labelControl2_Click(object sender, EventArgs e)
        {

        }
    }
}
