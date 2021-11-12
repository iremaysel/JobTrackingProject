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
    public partial class FrmEmployeeStatistics : Form
    {
        public FrmEmployeeStatistics()
        {
            InitializeComponent();
        }

        private void labelControl2_Click(object sender, EventArgs e)
        {

        }

        private void labelControl1_Click(object sender, EventArgs e)
        {

        }

        private DbJobTrackingEntities db = new DbJobTrackingEntities();
        private void FrmEmployeeStatistics_Load(object sender, EventArgs e)
        {
            LblTotalDepartment.Text = db.TblDepartments.Count().ToString();
            LblCompany.Text = db.TblCompanies.Count().ToString();
            LblTotalEmployee.Text = db.TblEmployee.Count().ToString();

            LblEndTask.Text = db.TblTask.OrderByDescending(x=>x.ID).Select(x => x.Satement).FirstOrDefault();

            LblCityOfWork.Text = db.TblCompanies.Select(x => x.Province).Distinct().Count().ToString();
            LblSector.Text = db.TblCompanies.Select(x => x.Sector).Distinct().Count().ToString();

            DateTime today = DateTime.Today;
            LblMissionOpenToday.Text = db.TblTask.Count(x => x.Dates == today).ToString();

            var d1 = db.TblTask.GroupBy(x => x.GiveTask).
                OrderByDescending(z => z.Count()).
                Select(y=>y.Key).FirstOrDefault();
            LblEmployeeOfTheMonth.Text = db.TblEmployee.Where(x => x.ID == d1).
                Select(y => y.Name+" "+ y.Surname).FirstOrDefault().ToString();

            LblDepartmentsOfTheMonth.Text = db.TblDepartments.Where(x => x.ID == db.TblEmployee.Where(t=>t.ID == d1).Select(z=>z.Department)
                .FirstOrDefault()).Select(y => y.Name).FirstOrDefault()
                .ToString();

            LblLastTaskDetails.Text = db.TblTask.OrderByDescending(x => x.ID).Select(x => x.Dates.ToString())
                .FirstOrDefault().ToString();

        }

        private void LblMissionOpenToday_Click(object sender, EventArgs e)
        {

        }

        private void LblSector_Click(object sender, EventArgs e)
        {

        }

        private void LblTotalDepartment_Click(object sender, EventArgs e)
        {

        }

        private void LblCompany_Click(object sender, EventArgs e)
        {

        }

        private void LblLastTaskDetails_Click(object sender, EventArgs e)
        {

        }
    }
}
