
namespace JobTrackingProject.EmployeeTaskForms
{
    partial class FrmCallDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCallDetail));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.TxtClock = new DevExpress.XtraEditors.TextEdit();
            this.pictureEdit5 = new DevExpress.XtraEditors.PictureEdit();
            this.TxtDates = new DevExpress.XtraEditors.DateEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.TxtDescription = new DevExpress.XtraEditors.MemoEdit();
            this.callid = new DevExpress.XtraEditors.LabelControl();
            this.TxtCallID = new DevExpress.XtraEditors.TextEdit();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.pictureEdit3 = new DevExpress.XtraEditors.PictureEdit();
            this.txtclocks = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.pictureEdit2 = new DevExpress.XtraEditors.PictureEdit();
            this.BtnSave = new DevExpress.XtraEditors.SimpleButton();
            this.BtnGiveUp = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtClock.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit5.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtDates.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtDates.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtDescription.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtCallID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit2.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.TxtClock);
            this.panelControl1.Controls.Add(this.pictureEdit5);
            this.panelControl1.Controls.Add(this.TxtDates);
            this.panelControl1.Controls.Add(this.labelControl5);
            this.panelControl1.Controls.Add(this.TxtDescription);
            this.panelControl1.Controls.Add(this.callid);
            this.panelControl1.Controls.Add(this.TxtCallID);
            this.panelControl1.Controls.Add(this.pictureEdit1);
            this.panelControl1.Controls.Add(this.pictureEdit3);
            this.panelControl1.Controls.Add(this.txtclocks);
            this.panelControl1.Controls.Add(this.labelControl3);
            this.panelControl1.Controls.Add(this.pictureEdit2);
            this.panelControl1.Location = new System.Drawing.Point(15, 12);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(444, 223);
            this.panelControl1.TabIndex = 21;
            // 
            // TxtClock
            // 
            this.TxtClock.Location = new System.Drawing.Point(152, 42);
            this.TxtClock.Name = "TxtClock";
            this.TxtClock.Size = new System.Drawing.Size(272, 20);
            this.TxtClock.TabIndex = 18;
            // 
            // pictureEdit5
            // 
            this.pictureEdit5.EditValue = ((object)(resources.GetObject("pictureEdit5.EditValue")));
            this.pictureEdit5.Location = new System.Drawing.Point(21, 97);
            this.pictureEdit5.Name = "pictureEdit5";
            this.pictureEdit5.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit5.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit5.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit5.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit5.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit5.Size = new System.Drawing.Size(24, 24);
            this.pictureEdit5.TabIndex = 17;
            // 
            // TxtDates
            // 
            this.TxtDates.EditValue = null;
            this.TxtDates.Location = new System.Drawing.Point(152, 71);
            this.TxtDates.Name = "TxtDates";
            this.TxtDates.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.TxtDates.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.TxtDates.Properties.DisplayFormat.FormatString = "";
            this.TxtDates.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.TxtDates.Properties.EditFormat.FormatString = "";
            this.TxtDates.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.TxtDates.Properties.MaskSettings.Set("mask", "");
            this.TxtDates.Size = new System.Drawing.Size(272, 20);
            this.TxtDates.TabIndex = 12;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(73, 107);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(41, 13);
            this.labelControl5.TabIndex = 16;
            this.labelControl5.Text = "Açıklama";
            // 
            // TxtDescription
            // 
            this.TxtDescription.Location = new System.Drawing.Point(152, 106);
            this.TxtDescription.Name = "TxtDescription";
            this.TxtDescription.Size = new System.Drawing.Size(272, 112);
            this.TxtDescription.TabIndex = 7;
            // 
            // callid
            // 
            this.callid.Location = new System.Drawing.Point(73, 15);
            this.callid.Name = "callid";
            this.callid.Size = new System.Drawing.Size(42, 13);
            this.callid.TabIndex = 1;
            this.callid.Text = "Çağrı ID ";
            // 
            // TxtCallID
            // 
            this.TxtCallID.Location = new System.Drawing.Point(152, 12);
            this.TxtCallID.Name = "TxtCallID";
            this.TxtCallID.Size = new System.Drawing.Size(272, 20);
            this.TxtCallID.TabIndex = 2;
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.EditValue = ((object)(resources.GetObject("pictureEdit1.EditValue")));
            this.pictureEdit1.Location = new System.Drawing.Point(21, 8);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit1.Size = new System.Drawing.Size(24, 24);
            this.pictureEdit1.TabIndex = 5;
            // 
            // pictureEdit3
            // 
            this.pictureEdit3.EditValue = ((object)(resources.GetObject("pictureEdit3.EditValue")));
            this.pictureEdit3.Location = new System.Drawing.Point(21, 67);
            this.pictureEdit3.Name = "pictureEdit3";
            this.pictureEdit3.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit3.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit3.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit3.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit3.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit3.Size = new System.Drawing.Size(24, 24);
            this.pictureEdit3.TabIndex = 11;
            // 
            // txtclocks
            // 
            this.txtclocks.Location = new System.Drawing.Point(73, 45);
            this.txtclocks.Name = "txtclocks";
            this.txtclocks.Size = new System.Drawing.Size(25, 13);
            this.txtclocks.TabIndex = 6;
            this.txtclocks.Text = "Saat ";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(73, 74);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(24, 13);
            this.labelControl3.TabIndex = 10;
            this.labelControl3.Text = "Tarih";
            // 
            // pictureEdit2
            // 
            this.pictureEdit2.EditValue = ((object)(resources.GetObject("pictureEdit2.EditValue")));
            this.pictureEdit2.Location = new System.Drawing.Point(21, 38);
            this.pictureEdit2.Name = "pictureEdit2";
            this.pictureEdit2.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit2.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit2.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit2.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit2.Size = new System.Drawing.Size(24, 24);
            this.pictureEdit2.TabIndex = 8;
            // 
            // BtnSave
            // 
            this.BtnSave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnSave.ImageOptions.Image")));
            this.BtnSave.Location = new System.Drawing.Point(337, 248);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(102, 23);
            this.BtnSave.TabIndex = 23;
            this.BtnSave.Text = "Kaydet";
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnGiveUp
            // 
            this.BtnGiveUp.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnGiveUp.ImageOptions.Image")));
            this.BtnGiveUp.Location = new System.Drawing.Point(221, 248);
            this.BtnGiveUp.Name = "BtnGiveUp";
            this.BtnGiveUp.Size = new System.Drawing.Size(102, 23);
            this.BtnGiveUp.TabIndex = 22;
            this.BtnGiveUp.Text = "Vazgeç";
            this.BtnGiveUp.Click += new System.EventHandler(this.BtnGiveUp_Click);
            // 
            // FrmCallDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 283);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.BtnGiveUp);
            this.Name = "FrmCallDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Çağrı Detay Girişi";
            this.Load += new System.EventHandler(this.FrmCallDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtClock.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit5.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtDates.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtDates.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtDescription.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtCallID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit2.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton BtnSave;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PictureEdit pictureEdit5;
        private DevExpress.XtraEditors.DateEdit TxtDates;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.MemoEdit TxtDescription;
        private DevExpress.XtraEditors.LabelControl callid;
        private DevExpress.XtraEditors.TextEdit TxtCallID;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.PictureEdit pictureEdit3;
        private DevExpress.XtraEditors.LabelControl txtclocks;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.PictureEdit pictureEdit2;
        private DevExpress.XtraEditors.SimpleButton BtnGiveUp;
        private DevExpress.XtraEditors.TextEdit TxtClock;
    }
}