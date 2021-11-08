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
    public partial class FrmEmployees : Form
    {
        public FrmEmployees()
        {
            InitializeComponent();
        }

        DbJobTrackingEntities db = new DbJobTrackingEntities();

        void Employees()
        {
            var values = from x in db.TblEmployee
                         select new
                         {
                             x.ID,
                             x.Name,
                             x.Email,
                             x.Department
                         };
            gridControl1.DataSource = values.ToList();

        }
        private void FrmEmployees_Load(object sender, EventArgs e)
        {
            Employees();
            var departments = (from x in db.TblDepartments
                select new
                {
                    x.ID,
                    x.Name
                }).ToList();
            departmentNames.Properties.ValueMember = "ID";
            departmentNames.Properties.DisplayMember = "Name";
            departmentNames.Properties.DataSource = departments;
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            Employees();
        }

        private void labelControl1_Click(object sender, EventArgs e)
        {

        }

        private void labelControl4_Click(object sender, EventArgs e)
        {

        }

        private void labelControl5_Click(object sender, EventArgs e)
        {

        }

        private void textEdit3_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}
