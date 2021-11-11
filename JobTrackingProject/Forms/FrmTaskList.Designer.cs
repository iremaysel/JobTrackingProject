
namespace JobTrackingProject.Forms
{
    partial class FrmTaskList
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
            DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.PieSeriesView pieSeriesView1 = new DevExpress.XtraCharts.PieSeriesView();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.LblTotalDepartment = new DevExpress.XtraEditors.LabelControl();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.chartControl1 = new DevExpress.XtraCharts.ChartControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.LblPassiveTask = new DevExpress.XtraEditors.LabelControl();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.LblActiveTask = new DevExpress.XtraEditors.LabelControl();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pieSeriesView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(123)))), ((int)(((byte)(200)))));
            this.panelControl1.Appearance.Options.UseBackColor = true;
            this.panelControl1.Controls.Add(this.LblTotalDepartment);
            this.panelControl1.Controls.Add(this.pictureBox1);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Location = new System.Drawing.Point(349, 0);
            this.panelControl1.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.panelControl1.LookAndFeel.UseDefaultLookAndFeel = false;
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(200, 100);
            this.panelControl1.TabIndex = 6;
            // 
            // LblTotalDepartment
            // 
            this.LblTotalDepartment.Appearance.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblTotalDepartment.Appearance.ForeColor = System.Drawing.SystemColors.Window;
            this.LblTotalDepartment.Appearance.Options.UseFont = true;
            this.LblTotalDepartment.Appearance.Options.UseForeColor = true;
            this.LblTotalDepartment.Location = new System.Drawing.Point(84, 41);
            this.LblTotalDepartment.Name = "LblTotalDepartment";
            this.LblTotalDepartment.Size = new System.Drawing.Size(17, 29);
            this.LblTotalDepartment.TabIndex = 3;
            this.LblTotalDepartment.Text = "0";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::JobTrackingProject.Properties.Resources.icons8_chart_2;
            this.pictureBox1.Location = new System.Drawing.Point(145, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(49, 50);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.SystemColors.Window;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(36, 19);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(119, 16);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Toplam Departman";
            // 
            // chartControl1
            // 
            this.chartControl1.Location = new System.Drawing.Point(349, 106);
            this.chartControl1.Name = "chartControl1";
            series1.Name = "State1";
            series1.View = pieSeriesView1;
            this.chartControl1.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1};
            this.chartControl1.Size = new System.Drawing.Size(612, 219);
            this.chartControl1.TabIndex = 9;
            // 
            // panelControl2
            // 
            this.panelControl2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(167)))), ((int)(((byte)(255)))));
            this.panelControl2.Appearance.Options.UseBackColor = true;
            this.panelControl2.Controls.Add(this.LblPassiveTask);
            this.panelControl2.Controls.Add(this.pictureBox3);
            this.panelControl2.Controls.Add(this.labelControl6);
            this.panelControl2.Location = new System.Drawing.Point(761, 0);
            this.panelControl2.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.panelControl2.LookAndFeel.UseDefaultLookAndFeel = false;
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(200, 100);
            this.panelControl2.TabIndex = 7;
            // 
            // LblPassiveTask
            // 
            this.LblPassiveTask.Appearance.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblPassiveTask.Appearance.ForeColor = System.Drawing.SystemColors.Window;
            this.LblPassiveTask.Appearance.Options.UseFont = true;
            this.LblPassiveTask.Appearance.Options.UseForeColor = true;
            this.LblPassiveTask.Location = new System.Drawing.Point(93, 41);
            this.LblPassiveTask.Name = "LblPassiveTask";
            this.LblPassiveTask.Size = new System.Drawing.Size(17, 29);
            this.LblPassiveTask.TabIndex = 7;
            this.LblPassiveTask.Text = "0";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::JobTrackingProject.Properties.Resources.icons8_system_report;
            this.pictureBox3.Location = new System.Drawing.Point(145, 44);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(49, 50);
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl6.Appearance.ForeColor = System.Drawing.SystemColors.Window;
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Appearance.Options.UseForeColor = true;
            this.labelControl6.Location = new System.Drawing.Point(47, 19);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(109, 16);
            this.labelControl6.TabIndex = 6;
            this.labelControl6.Text = "Pasif Görev Sayısı";
            // 
            // panelControl3
            // 
            this.panelControl3.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(148)))), ((int)(((byte)(242)))));
            this.panelControl3.Appearance.Options.UseBackColor = true;
            this.panelControl3.Controls.Add(this.LblActiveTask);
            this.panelControl3.Controls.Add(this.pictureBox2);
            this.panelControl3.Controls.Add(this.labelControl3);
            this.panelControl3.Location = new System.Drawing.Point(555, 0);
            this.panelControl3.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.panelControl3.LookAndFeel.UseDefaultLookAndFeel = false;
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(200, 100);
            this.panelControl3.TabIndex = 7;
            // 
            // LblActiveTask
            // 
            this.LblActiveTask.Appearance.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblActiveTask.Appearance.ForeColor = System.Drawing.SystemColors.Window;
            this.LblActiveTask.Appearance.Options.UseFont = true;
            this.LblActiveTask.Appearance.Options.UseForeColor = true;
            this.LblActiveTask.Location = new System.Drawing.Point(93, 41);
            this.LblActiveTask.Name = "LblActiveTask";
            this.LblActiveTask.Size = new System.Drawing.Size(17, 29);
            this.LblActiveTask.TabIndex = 5;
            this.LblActiveTask.Text = "0";
            this.LblActiveTask.Click += new System.EventHandler(this.labelControl2_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::JobTrackingProject.Properties.Resources.icons8_system_information;
            this.pictureBox2.Location = new System.Drawing.Point(145, 44);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(49, 50);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl3.Appearance.ForeColor = System.Drawing.SystemColors.Window;
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Appearance.Options.UseForeColor = true;
            this.labelControl3.Location = new System.Drawing.Point(46, 19);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(110, 16);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Aktif Görev Sayısı";
            this.labelControl3.Click += new System.EventHandler(this.labelControl3_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(2, 0);
            this.gridControl1.MainView = this.gridView2;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(341, 325);
            this.gridControl1.TabIndex = 10;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.gridControl1;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // FrmTaskList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 326);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl3);
            this.Controls.Add(this.chartControl1);
            this.Controls.Add(this.panelControl1);
            this.Name = "FrmTaskList";
            this.Text = "Görev Listesi";
            this.Load += new System.EventHandler(this.FrmTaskList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pieSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            this.panelControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraCharts.ChartControl chartControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl LblTotalDepartment;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private DevExpress.XtraEditors.LabelControl LblActiveTask;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl LblPassiveTask;
        private DevExpress.XtraEditors.LabelControl labelControl6;
    }
}