
namespace JobTrackingProject.Forms
{
    partial class FrmEmployees
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEmployees));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btnUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnList = new DevExpress.XtraEditors.SimpleButton();
            this.TxtName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.TxtID = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.departmentNames = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.TxtImage = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.TxtEmail = new DevExpress.XtraEditors.TextEdit();
            this.textemail = new DevExpress.XtraEditors.LabelControl();
            this.TxtSurname = new DevExpress.XtraEditors.TextEdit();
            this.textsurname = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.departmentNames.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtImage.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtEmail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSurname.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(1, 1);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(569, 325);
            this.gridControl1.TabIndex = 6;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.Click += new System.EventHandler(this.gridControl1_Click);
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // btnUpdate
            // 
            this.btnUpdate.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.ImageOptions.Image")));
            this.btnUpdate.Location = new System.Drawing.Point(121, 293);
            this.btnUpdate.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Style3D;
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(241, 23);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "Güncelle";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.ImageOptions.Image")));
            this.btnDelete.Location = new System.Drawing.Point(121, 264);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(241, 23);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Sil";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnList
            // 
            this.btnList.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnList.ImageOptions.Image")));
            this.btnList.Location = new System.Drawing.Point(121, 205);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(241, 24);
            this.btnList.TabIndex = 5;
            this.btnList.Text = "Listele";
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // TxtName
            // 
            this.TxtName.EditValue = "";
            this.TxtName.Location = new System.Drawing.Point(121, 72);
            this.TxtName.Name = "TxtName";
            this.TxtName.Properties.AccessibleName = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(241, 20);
            this.TxtName.TabIndex = 4;
            this.TxtName.EditValueChanged += new System.EventHandler(this.TxtName_EditValueChanged);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(74, 75);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(19, 13);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Adı:";
            // 
            // btnAdd
            // 
            this.btnAdd.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.ImageOptions.Image")));
            this.btnAdd.Location = new System.Drawing.Point(121, 235);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(241, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Ekle";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // TxtID
            // 
            this.TxtID.Location = new System.Drawing.Point(121, 46);
            this.TxtID.Name = "TxtID";
            this.TxtID.Size = new System.Drawing.Size(241, 20);
            this.TxtID.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(34, 49);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(59, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Personel ID:";
            this.labelControl1.Click += new System.EventHandler(this.labelControl1_Click);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.departmentNames);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.TxtImage);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.TxtEmail);
            this.groupControl1.Controls.Add(this.textemail);
            this.groupControl1.Controls.Add(this.TxtSurname);
            this.groupControl1.Controls.Add(this.textsurname);
            this.groupControl1.Controls.Add(this.btnUpdate);
            this.groupControl1.Controls.Add(this.btnDelete);
            this.groupControl1.Controls.Add(this.btnList);
            this.groupControl1.Controls.Add(this.TxtName);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.btnAdd);
            this.groupControl1.Controls.Add(this.TxtID);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(576, 1);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(392, 325);
            this.groupControl1.TabIndex = 7;
            this.groupControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.groupControl1_Paint);
            // 
            // departmentNames
            // 
            this.departmentNames.EditValue = "";
            this.departmentNames.Location = new System.Drawing.Point(120, 179);
            this.departmentNames.Name = "departmentNames";
            this.departmentNames.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.departmentNames.Size = new System.Drawing.Size(241, 20);
            this.departmentNames.TabIndex = 16;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(36, 181);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(57, 13);
            this.labelControl6.TabIndex = 14;
            this.labelControl6.Text = "Departman:";
            // 
            // TxtImage
            // 
            this.TxtImage.EditValue = "";
            this.TxtImage.Location = new System.Drawing.Point(121, 152);
            this.TxtImage.Name = "TxtImage";
            this.TxtImage.Properties.AccessibleName = "TxtName";
            this.TxtImage.Size = new System.Drawing.Size(241, 20);
            this.TxtImage.TabIndex = 13;
            this.TxtImage.EditValueChanged += new System.EventHandler(this.textEdit3_EditValueChanged);
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(59, 155);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(34, 13);
            this.labelControl5.TabIndex = 12;
            this.labelControl5.Text = "Görsel:";
            this.labelControl5.Click += new System.EventHandler(this.labelControl5_Click);
            // 
            // TxtEmail
            // 
            this.TxtEmail.EditValue = "";
            this.TxtEmail.Location = new System.Drawing.Point(121, 124);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Properties.AccessibleName = "TxtName";
            this.TxtEmail.Size = new System.Drawing.Size(241, 20);
            this.TxtEmail.TabIndex = 11;
            // 
            // textemail
            // 
            this.textemail.Location = new System.Drawing.Point(38, 127);
            this.textemail.Name = "textemail";
            this.textemail.Size = new System.Drawing.Size(55, 13);
            this.textemail.TabIndex = 10;
            this.textemail.Text = "Mail Adresi:";
            this.textemail.Click += new System.EventHandler(this.labelControl4_Click);
            // 
            // TxtSurname
            // 
            this.TxtSurname.EditValue = "";
            this.TxtSurname.Location = new System.Drawing.Point(121, 98);
            this.TxtSurname.Name = "TxtSurname";
            this.TxtSurname.Properties.AccessibleName = "TxtName";
            this.TxtSurname.Size = new System.Drawing.Size(241, 20);
            this.TxtSurname.TabIndex = 9;
            // 
            // textsurname
            // 
            this.textsurname.Location = new System.Drawing.Point(57, 101);
            this.textsurname.Name = "textsurname";
            this.textsurname.Size = new System.Drawing.Size(36, 13);
            this.textsurname.TabIndex = 8;
            this.textsurname.Text = "Soyadı:";
            // 
            // FrmEmployees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 326);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.groupControl1);
            this.Name = "FrmEmployees";
            this.Text = "Personeller";
            this.Load += new System.EventHandler(this.FrmEmployees_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.departmentNames.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtImage.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtEmail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSurname.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton btnUpdate;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        internal DevExpress.XtraEditors.SimpleButton btnList;
        private DevExpress.XtraEditors.TextEdit TxtName;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private DevExpress.XtraEditors.TextEdit TxtID;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TextEdit TxtEmail;
        private DevExpress.XtraEditors.LabelControl textemail;
        private DevExpress.XtraEditors.TextEdit TxtSurname;
        private DevExpress.XtraEditors.LabelControl textsurname;
        private DevExpress.XtraEditors.TextEdit TxtImage;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LookUpEdit departmentNames;
        private DevExpress.XtraEditors.LabelControl labelControl6;
    }
}