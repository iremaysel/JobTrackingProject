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
    public partial class FrmCallDetail : Form
    {
        public FrmCallDetail()
        {
            InitializeComponent();
        }

        public int id;

        private void BtnGiveUp_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmCallDetail_Load(object sender, EventArgs e)
        {
            TxtCallID.Enabled = false;
            TxtCallID.Text = id.ToString();
            string clocks, dates;
            dates = DateTime.Now.ToShortDateString();
            clocks = DateTime.Now.ToShortTimeString();
            TxtDates.Text = dates;
            TxtClock.Text = clocks;
        }
    }
}
