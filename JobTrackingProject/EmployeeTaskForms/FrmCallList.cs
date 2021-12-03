﻿using JobTrackingProject.Entity_Framework;
using System;
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
    public partial class FrmCallList : Form
    {
        public FrmCallList()
        {
            InitializeComponent();
        }

        DbJobTrackingEntities db = new DbJobTrackingEntities();

        private void FrmCallList_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = (from x in db.TblCall
                                       select new
                                       {
                                           x.ID,
                                           FirmaAdı = x.TblCompanies.Name,
                                           Telefon = x.TblCompanies.Telephone,
                                           Mail = x.TblCompanies.Email,
                                           Açıklama = x.CallStatement,
                                           x.CallStatus
                                       }).Where(y => y.CallStatus == true).ToList();

            gridView1.Columns["CallStatus"].Visible = false;
            gridView1.Columns["ID"].Visible = false;

        }
    }
}