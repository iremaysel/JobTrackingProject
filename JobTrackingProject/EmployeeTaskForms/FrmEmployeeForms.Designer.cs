
namespace JobTrackingProject.EmployeeTaskForms
{
    partial class FrmEmployeeForms
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEmployeeForms));
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.BtnActiveTasks = new DevExpress.XtraBars.BarButtonItem();
            this.BtnPassiveTasks = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.xtraTabbedMdiManager2 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.BtnCallList = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager2)).BeginInit();
            this.SuspendLayout();
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = null;
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.BtnActiveTasks,
            this.BtnPassiveTasks,
            this.BtnCallList});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 4;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.Size = new System.Drawing.Size(984, 150);
            // 
            // BtnActiveTasks
            // 
            this.BtnActiveTasks.Caption = "Aktif Görevler";
            this.BtnActiveTasks.Id = 1;
            this.BtnActiveTasks.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BtnActiveTasks.ImageOptions.SvgImage")));
            this.BtnActiveTasks.Name = "BtnActiveTasks";
            this.BtnActiveTasks.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnActiveTasks_ItemClick);
            // 
            // BtnPassiveTasks
            // 
            this.BtnPassiveTasks.Caption = "Pasif Görevler";
            this.BtnPassiveTasks.Id = 2;
            this.BtnPassiveTasks.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BtnPassiveTasks.ImageOptions.SvgImage")));
            this.BtnPassiveTasks.Name = "BtnPassiveTasks";
            this.BtnPassiveTasks.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnPassiveTasks_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "ribbonPage1";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.BtnActiveTasks);
            this.ribbonPageGroup1.ItemLinks.Add(this.BtnPassiveTasks);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // xtraTabbedMdiManager2
            // 
            this.xtraTabbedMdiManager2.MdiParent = this;
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.BtnCallList);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            // 
            // BtnCallList
            // 
            this.BtnCallList.Caption = "Çağrı Listesi";
            this.BtnCallList.Id = 3;
            this.BtnCallList.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnCallList.ImageOptions.Image")));
            this.BtnCallList.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BtnCallList.ImageOptions.LargeImage")));
            this.BtnCallList.Name = "BtnCallList";
            this.BtnCallList.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnCallList_ItemClick);
            // 
            // FrmEmployeeForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 511);
            this.Controls.Add(this.ribbonControl1);
            this.IsMdiContainer = true;
            this.Name = "FrmEmployeeForms";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personel Formu";
            this.Load += new System.EventHandler(this.FrmEmployeeForms_Load);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.BarButtonItem BtnActiveTasks;
        private DevExpress.XtraBars.BarButtonItem BtnPassiveTasks;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager2;
        private DevExpress.XtraBars.BarButtonItem BtnCallList;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
    }
}