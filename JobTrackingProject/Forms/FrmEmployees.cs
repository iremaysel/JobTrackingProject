﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
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
                             departments = x.TblDepartments.Name,
                             x.Status
                         };
            gridControl1.DataSource = values.Where(x=>x.Status == true).ToList();

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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            TblEmployee t = new TblEmployee();
            t.Name = TxtName.Text;
            t.Surname = TxtSurname.Text;
            t.Email = TxtEmail.Text;
            t.Image = TxtEmail.Text;
            t.Department = int.Parse(departmentNames.EditValue.ToString());
            db.TblEmployee.Add(t);
            db.SaveChanges();
            XtraMessageBox.Show("Yeni Personel kaydı başarıyla eklendi.", "Bilgi", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            Employees();
        }

        private void TxtName_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var x = int.Parse(TxtID.Text);
            var value = db.TblEmployee.Find(x);
            value.Status = false;
            db.SaveChanges();
            XtraMessageBox.Show("Personel başarıyla silindi. Silinen personeller," +
                                "listesinden tüm silinmiş personel bilgilerine ulaşabilirsiniz!", "Bilgi", MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            Employees();
        }
    }
}
