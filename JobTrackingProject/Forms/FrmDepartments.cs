using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JobTrackingProject.Entity_Framework;
using System.Windows.Forms;

namespace JobTrackingProject.Forms
{
    public partial class FrmDepartments : Form
    {
        public FrmDepartments()
        {
            InitializeComponent();
        }

        void Listele()
        {
            DbJobTrackingEntities db = new DbJobTrackingEntities();
            var values = (from x in db.TblDepartments
                select new
                {
                    x.ID,
                    x.Name
                }).ToList();
            gridControl1.DataSource = values;

        }


        private void labelControl2_Click(object sender, EventArgs e)
        {

        }

        // Btn-list
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void textEdit2_EditValueChanged(object sender, EventArgs e)
        {

        }

       private void TxtID_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
