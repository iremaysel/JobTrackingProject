using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JobTrackingProject.LoginForms
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form fr = new Form1();
            fr.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EmployeeTaskForms.FrmEmployeeForms fr = new EmployeeTaskForms.FrmEmployeeForms();
            fr.Show();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void textEdit1_Click(object sender, EventArgs e)
        {
           
            panel3.BackColor = SystemColors.Control;
            panel4.BackColor = SystemColors.ControlLightLight;

        }

        private void textEdit3_Click(object sender, EventArgs e)
        {
            panel4.BackColor = SystemColors.Control;
            panel3.BackColor = SystemColors.ControlLightLight;

        }

        private void textEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form fr = new Form1();
            fr.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            EmployeeTaskForms.FrmEmployeeForms fr = new EmployeeTaskForms.FrmEmployeeForms();
            fr.Show();
        }
    }
}
