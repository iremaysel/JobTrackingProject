﻿using System;
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
    public partial class FrmEmployeeForms : Form
    {
        public FrmEmployeeForms()
        {
            InitializeComponent();
        }

        EmployeeTaskForms.FrmActiveTasks frm1;
        private void BtnActiveTasks_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Application.OpenForms["EmployeeTaskForms.FrmActiveTasks"] == null)
            {
                frm1 = new EmployeeTaskForms.FrmActiveTasks();
                frm1.MdiParent = this;
                frm1.Show();
            }
            else
            {
                Application.OpenForms["EmployeeTaskForms.FrmActiveTasks"].Activate();
            }
        }

        EmployeeTaskForms.FrmPassiveTasks frm2;
        private void BtnPassiveTasks_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Application.OpenForms["EmployeeTaskForms.FrmPassiveTasks"] == null)
            {
                frm2 = new EmployeeTaskForms.FrmPassiveTasks();
                frm2.MdiParent = this;
                frm2.Show();
            }
            else
            {
                Application.OpenForms["EmployeeTaskForms.FrmPassiveTasks"].Activate();
            }
        }
    }
}
