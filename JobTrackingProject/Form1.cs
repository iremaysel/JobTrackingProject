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

        private void btnDepartmentList_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.FrmDepartments frm = new Forms.FrmDepartments();
            frm.MdiParent = this;
            frm.Show();
        }

        private void BtnEmployeeList_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.FrmEmployees frm2 = new FrmEmployees();
            frm2.MdiParent = this;
            frm2.Show();
        }

        private void BtnEmployeeStatistics_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.FrmEmployeeStatistics frm3 = new FrmEmployeeStatistics();
            frm3.MdiParent = this;
            frm3.Show();
        }

        private void BtnTaskList_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.FrmTaskList frm4 = new FrmTaskList();
            frm4.MdiParent = this;
            frm4.Show();
        }

        private void BtnDefineNewTask_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.FrmTask fr = new Forms.FrmTask();
            fr.Show();
        }
    }
}
