using DevExpress.XtraEditors;
using JobTrackingProject.Entity_Framework;
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


        DbJobTrackingEntities db = new DbJobTrackingEntities();

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void TxtUser_Click(object sender, EventArgs e)
        {
           
            panel3.BackColor = SystemColors.Control;
            panel4.BackColor = SystemColors.ControlLightLight;

        }

        private void TxtPassword_Click(object sender, EventArgs e)
        {
            panel4.BackColor = SystemColors.Control;
            panel3.BackColor = SystemColors.ControlLightLight;

        }

        private void TxtUser_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void BtnAdmin_Click_1(object sender, EventArgs e)
        {
            
            var adminValue = db.TblAdmin.Where(x => x.Users == TxtUser.Text && 
            x.Password == TxtPassword.Text).FirstOrDefault();
            if(adminValue != null)
            {
              
                XtraMessageBox.Show("Hoşgeldiniz", "Başarılı", MessageBoxButtons.OK,
               MessageBoxIcon.Information);
                Form fr = new Form1();
                fr.Show();
                this.Hide();

            }
            else
            {
                XtraMessageBox.Show("Hatalı Giriş Yaptınız!", "Uyarı", MessageBoxButtons.OK,
               MessageBoxIcon.Information);
            }
            
        }

        private void BtnEmployee_Click_1(object sender, EventArgs e)
        {
            var employeeValue = db.TblEmployee.Where(x => x.Email == TxtUser.Text &&
            x.Password == TxtPassword.Text).FirstOrDefault();
            if (employeeValue != null)
            {

                XtraMessageBox.Show("Hoşgeldiniz", "Başarılı", MessageBoxButtons.OK,
               MessageBoxIcon.Information);
                EmployeeTaskForms.FrmEmployeeForms fr = new EmployeeTaskForms.FrmEmployeeForms();
                fr.Show();
                this.Hide();
                

            }
            else
            {
                XtraMessageBox.Show("Hatalı Giriş Yaptınız!", "Uyarı", MessageBoxButtons.OK,
               MessageBoxIcon.Information);
            }
            
        }
    }
}
