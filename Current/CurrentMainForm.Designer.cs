namespace Current
{
    partial class CurrentMainForm
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
            DevExpress.XtraBars.Docking2010.Views.Tabbed.DockingContainer dockingContainer1 = new DevExpress.XtraBars.Docking2010.Views.Tabbed.DockingContainer();
            DevExpress.Utils.Animation.PushTransition pushTransition1 = new DevExpress.Utils.Animation.PushTransition();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CurrentMainForm));
            this.documentGroup1 = new DevExpress.XtraBars.Docking2010.Views.Tabbed.DocumentGroup(this.components);
            this.document1 = new DevExpress.XtraBars.Docking2010.Views.Tabbed.Document(this.components);
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.ribbonPageDocumentation = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroupCabels = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.dockManagerApplicationContent = new DevExpress.XtraBars.Docking.DockManager(this.components);
            this.dockPanelCabelList = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel1_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.cabelListCtrl = new Current.CabelListControl();
            this.documentManagerApplicationContent = new DevExpress.XtraBars.Docking2010.DocumentManager(this.components);
            this.tabbedView1 = new DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView(this.components);
            this.workspaceManager = new DevExpress.Utils.WorkspaceManager(this.components);
            this.barButtonItemAddNewCabel = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.documentGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.document1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManagerApplicationContent)).BeginInit();
            this.dockPanelCabelList.SuspendLayout();
            this.dockPanel1_Container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.documentManagerApplicationContent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView1)).BeginInit();
            this.SuspendLayout();
            // 
            // documentGroup1
            // 
            this.documentGroup1.Items.AddRange(new DevExpress.XtraBars.Docking2010.Views.Tabbed.Document[] {
            this.document1});
            // 
            // document1
            // 
            this.document1.Caption = "Cabel List";
            this.document1.ControlName = "dockPanelCabelList";
            this.document1.FloatLocation = new System.Drawing.Point(0, 0);
            this.document1.FloatSize = new System.Drawing.Size(200, 200);
            this.document1.Properties.AllowClose = DevExpress.Utils.DefaultBoolean.True;
            this.document1.Properties.AllowFloat = DevExpress.Utils.DefaultBoolean.True;
            this.document1.Properties.AllowFloatOnDoubleClick = DevExpress.Utils.DefaultBoolean.True;
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.barButtonItemAddNewCabel});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 2;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPageDocumentation});
            this.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013;
            this.ribbonControl1.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.ShowDisplayOptionsMenuButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.Size = new System.Drawing.Size(1278, 154);
            // 
            // ribbonPageDocumentation
            // 
            this.ribbonPageDocumentation.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroupCabels});
            this.ribbonPageDocumentation.Name = "ribbonPageDocumentation";
            this.ribbonPageDocumentation.Text = "Documentation";
            // 
            // ribbonPageGroupCabels
            // 
            this.ribbonPageGroupCabels.ItemLinks.Add(this.barButtonItemAddNewCabel);
            this.ribbonPageGroupCabels.Name = "ribbonPageGroupCabels";
            this.ribbonPageGroupCabels.Text = "Cabels";
            // 
            // dockManagerApplicationContent
            // 
            this.dockManagerApplicationContent.Form = this;
            this.dockManagerApplicationContent.RootPanels.AddRange(new DevExpress.XtraBars.Docking.DockPanel[] {
            this.dockPanelCabelList});
            this.dockManagerApplicationContent.TopZIndexControls.AddRange(new string[] {
            "DevExpress.XtraBars.BarDockControl",
            "DevExpress.XtraBars.StandaloneBarDockControl",
            "System.Windows.Forms.StatusBar",
            "System.Windows.Forms.MenuStrip",
            "System.Windows.Forms.StatusStrip",
            "DevExpress.XtraBars.Ribbon.RibbonStatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonControl",
            "DevExpress.XtraBars.Navigation.OfficeNavigationBar",
            "DevExpress.XtraBars.Navigation.TileNavPane",
            "DevExpress.XtraBars.TabFormControl",
            "DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl"});
            // 
            // dockPanelCabelList
            // 
            this.dockPanelCabelList.Controls.Add(this.dockPanel1_Container);
            this.dockPanelCabelList.DockedAsTabbedDocument = true;
            this.dockPanelCabelList.ID = new System.Guid("ada24b00-ba54-4ebf-98d1-c507d6693587");
            this.dockPanelCabelList.Name = "dockPanelCabelList";
            this.dockPanelCabelList.OriginalSize = new System.Drawing.Size(200, 200);
            this.dockPanelCabelList.Text = "Cabel List";
            // 
            // dockPanel1_Container
            // 
            this.dockPanel1_Container.Controls.Add(this.cabelListCtrl);
            this.dockPanel1_Container.Location = new System.Drawing.Point(0, 0);
            this.dockPanel1_Container.Name = "dockPanel1_Container";
            this.dockPanel1_Container.Size = new System.Drawing.Size(1272, 614);
            this.dockPanel1_Container.TabIndex = 0;
            // 
            // cabelListCtrl
            // 
            this.cabelListCtrl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cabelListCtrl.Location = new System.Drawing.Point(0, 0);
            this.cabelListCtrl.Name = "cabelListCtrl";
            this.cabelListCtrl.Size = new System.Drawing.Size(1272, 614);
            this.cabelListCtrl.TabIndex = 0;
            // 
            // documentManagerApplicationContent
            // 
            this.documentManagerApplicationContent.ContainerControl = this;
            this.documentManagerApplicationContent.View = this.tabbedView1;
            this.documentManagerApplicationContent.ViewCollection.AddRange(new DevExpress.XtraBars.Docking2010.Views.BaseView[] {
            this.tabbedView1});
            // 
            // tabbedView1
            // 
            this.tabbedView1.DocumentGroups.AddRange(new DevExpress.XtraBars.Docking2010.Views.Tabbed.DocumentGroup[] {
            this.documentGroup1});
            this.tabbedView1.Documents.AddRange(new DevExpress.XtraBars.Docking2010.Views.BaseDocument[] {
            this.document1});
            dockingContainer1.Element = this.documentGroup1;
            this.tabbedView1.RootContainer.Nodes.AddRange(new DevExpress.XtraBars.Docking2010.Views.Tabbed.DockingContainer[] {
            dockingContainer1});
            // 
            // workspaceManager
            // 
            this.workspaceManager.AllowTransitionAnimation = DevExpress.Utils.DefaultBoolean.False;
            this.workspaceManager.SaveTargetControlSettings = true;
            this.workspaceManager.TargetControl = this;
            this.workspaceManager.TransitionType = pushTransition1;
            // 
            // barButtonItemAddNewCabel
            // 
            this.barButtonItemAddNewCabel.Caption = "Add New";
            this.barButtonItemAddNewCabel.Id = 1;
            this.barButtonItemAddNewCabel.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItemAddNewCabel.ImageOptions.SvgImage")));
            this.barButtonItemAddNewCabel.Name = "barButtonItemAddNewCabel";
            this.barButtonItemAddNewCabel.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemAddNewCabel_ItemClick);
            // 
            // CurrentMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1278, 799);
            this.Controls.Add(this.ribbonControl1);
            this.MinimumSize = new System.Drawing.Size(530, 330);
            this.Name = "CurrentMainForm";
            this.Ribbon = this.ribbonControl1;
            this.Text = "Current";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CurrentMainForm_FormClosed);
            this.Load += new System.EventHandler(this.CurrentMainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.documentGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.document1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManagerApplicationContent)).EndInit();
            this.dockPanelCabelList.ResumeLayout(false);
            this.dockPanel1_Container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.documentManagerApplicationContent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPageDocumentation;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroupCabels;
        private DevExpress.XtraBars.Docking.DockManager dockManagerApplicationContent;
        private DevExpress.XtraBars.Docking.DockPanel dockPanelCabelList;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanel1_Container;
        private DevExpress.XtraBars.Docking2010.DocumentManager documentManagerApplicationContent;
        private DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView tabbedView1;
        private DevExpress.XtraBars.Docking2010.Views.Tabbed.DocumentGroup documentGroup1;
        private DevExpress.XtraBars.Docking2010.Views.Tabbed.Document document1;
        private CabelListControl cabelListCtrl;
        private DevExpress.Utils.WorkspaceManager workspaceManager;
        private DevExpress.XtraBars.BarButtonItem barButtonItemAddNewCabel;
    }
}

