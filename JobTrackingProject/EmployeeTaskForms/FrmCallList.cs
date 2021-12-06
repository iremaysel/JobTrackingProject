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

namespace JobTrackingProject.EmployeeTaskForms
{
    public partial class FrmCallList : Form
    {
        public FrmCallList()
        {
            InitializeComponent();
        }

        
        DbJobTrackingEntities db = new DbJobTrackingEntities();
        public string email2;

        private void FrmCallList_Load(object sender, EventArgs e)
        {
            var employeeID = db.TblEmployee.Where(x => x.Email == email2).Select(y => y.ID).FirstOrDefault();
            gridControl1.DataSource = (from x in db.TblCall
                                       select new
                                       {
                                           x.ID,
                                           FirmaAdı = x.TblCompanies.Name,
                                           Telefon = x.TblCompanies.Telephone,
                                           Mail = x.TblCompanies.Email,
                                           Açıklama = x.CallStatement,
                                           x.CallEmployee,
                                           x.CallStatus
                                       }).Where(y => y.CallStatus == true && y.CallEmployee == employeeID).ToList();

            gridView1.Columns["CallStatus"].Visible = false;
            gridView1.Columns["ID"].Visible = false;
            gridView1.Columns["CallEmployee"].Visible = false;

        }

        private void FrmCallList_DoubleClick(object sender, EventArgs e)
        {
            
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            FrmCallDetail fr = new FrmCallDetail();
            fr.id = int.Parse(gridView1.GetFocusedRowCellValue("ID").ToString());
            fr.Show();
        }
    }
}
