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

namespace JobTrackingProject.Forms
{
    public partial class FrmActiveCalls : Form
    {
        public FrmActiveCalls()
        {
            InitializeComponent();
        }

        DbJobTrackingEntities db = new DbJobTrackingEntities();
        private void FrmActiveCalls_Load(object sender, EventArgs e)
        {
            var values = (from x in db.TblCall
                          select new
                          {
                              x.ID,
                              FirmaAdı = x.TblCompanies.Name,
                              Telefon = x.TblCompanies.Telephone,
                              ÇağrıKonusu = x.CallSubject,
                              Açıklama = x.CallStatement,
                              Durum = x.CallStatus
                          }).Where(y => y.Durum == true).ToList();
        
            gridControl1.DataSource = values;

        }
    }
}
