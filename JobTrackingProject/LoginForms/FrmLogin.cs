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
    }
}
