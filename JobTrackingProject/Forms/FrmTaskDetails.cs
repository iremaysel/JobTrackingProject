using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JobTrackingProject.Entity_Framework;

namespace JobTrackingProject.Forms
{
    public partial class FrmTaskDetails : Form
    {
        public FrmTaskDetails()
        {
            InitializeComponent();
        }

        private DbJobTrackingEntities db = new DbJobTrackingEntities();
        private void FrmTaskDetails_Load(object sender, EventArgs e)
        {
            db.TblTaskDetail.Load();
            bindingSource1.DataSource = db.TblTaskDetail.Local;
        }

        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            db.SaveChanges();
        }

        private void görevDetayıSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bindingSource1.RemoveCurrent();
            db.SaveChanges();
        }
    }
}