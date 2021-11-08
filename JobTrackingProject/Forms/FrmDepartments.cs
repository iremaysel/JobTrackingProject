using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JobTrackingProject.Entity_Framework;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace JobTrackingProject.Forms
{
    public partial class FrmDepartments : Form
    {
        public FrmDepartments()
        {
            InitializeComponent();
        }
        DbJobTrackingEntities db = new DbJobTrackingEntities();

        void ToList()
        {
            var values = (from x in db.TblDepartments
                          select new
                          {
                              x.ID,
                              x.Name
                          }).ToList();
            gridControl1.DataSource = values;

        }


        private void labelControl2_Click(object sender, EventArgs e)
        {

        }

        // Btn-list
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            ToList();
        }

        private void textEdit2_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void TxtID_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            TblDepartments t = new TblDepartments();
            t.Name = TxtName.Text;
            db.TblDepartments.Add(t);
            db.SaveChanges();
            XtraMessageBox.Show("Departman başarılı bir şekilde sisteme kaydedildi.", "Bilgi",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            ToList();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int x = int.Parse(TxtID.Text);
            var value = db.TblDepartments.Find(x);
            db.TblDepartments.Remove(value);
            db.SaveChanges();
            XtraMessageBox.Show("Departman silme işlemi başarıyla gerçekleşti.", "Bilgi", MessageBoxButtons.OK,
                MessageBoxIcon.Stop);
            ToList();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int x = int.Parse(TxtID.Text);
            var value = db.TblDepartments.Find(x);
            value.Name = TxtName.Text;
            db.SaveChanges();
            XtraMessageBox.Show("Departman güncelleme işlemi başarıyla gerçekleşti.", "Bilgi", MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
            ToList();
        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            TxtID.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
            TxtName.Text = gridView1.GetFocusedRowCellValue("Name").ToString();
        }

        private void labelControl1_Click(object sender, EventArgs e)
        {

        }
    }
}
