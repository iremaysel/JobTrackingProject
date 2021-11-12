using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JobTrackingProject.Forms;

namespace JobTrackingProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        Forms.FrmDepartments frm;
        private void btnDepartmentList_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Application.OpenForms["FrmDepartments"] == null)
            {
                frm = new Forms.FrmDepartments();
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                Application.OpenForms["FrmDepartments"].Activate();
            }
            
        }

        Forms.FrmEmployees frm2;
        private void BtnEmployeeList_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Application.OpenForms["FrmEmployees"] == null)
            {
                frm2 = new FrmEmployees();
                frm2.MdiParent = this;
                frm2.Show();
            }
            else
            {
                Application.OpenForms["FrmEmployees"].Activate();
            }
        }

        Forms.FrmEmployeeStatistics frm3;
        private void BtnEmployeeStatistics_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Application.OpenForms["FrmEmployeeStatistics"] == null)
            {
                frm3 = new FrmEmployeeStatistics();
                frm3.MdiParent = this;
                frm3.Show();
            }
            else
            {
                Application.OpenForms["FrmEmployeeStatistics"].Activate();
            }
        }

        Forms.FrmTaskList frm4;
        private void BtnTaskList_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Application.OpenForms["FrmTaskList"] == null)
            {
                frm4 = new FrmTaskList();
                frm4.MdiParent = this;
                frm4.Show();
            }
            else
            {
                Application.OpenForms["FrmTaskList"].Activate();
            }
        }

        private void BtnDefineNewTask_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.FrmTask fr = new Forms.FrmTask();
            fr.Show();
        }

        private void BtnTaskDetails_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.FrmTaskDetails fr2 = new Forms.FrmTaskDetails();
            fr2.Show();
        }
    }
}
