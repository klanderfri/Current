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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CurrentMainForm));
            DevExpress.XtraBars.Docking2010.Views.Tabbed.DockingContainer dockingContainer1 = new DevExpress.XtraBars.Docking2010.Views.Tabbed.DockingContainer();
            DevExpress.Utils.Animation.PushTransition pushTransition1 = new DevExpress.Utils.Animation.PushTransition();
            this.documentGroup1 = new DevExpress.XtraBars.Docking2010.Views.Tabbed.DocumentGroup(this.components);
            this.document1 = new DevExpress.XtraBars.Docking2010.Views.Tabbed.Document(this.components);
            this.document2 = new DevExpress.XtraBars.Docking2010.Views.Tabbed.Document(this.components);
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barButtonItemAddNewCable = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPageDocumentation = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroupCables = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.dockManagerApplicationContent = new DevExpress.XtraBars.Docking.DockManager(this.components);
            this.dockPanelCableList = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel1_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.cableListCtrl = new Current.CableListControl();
            this.dockPanelCrewList = new DevExpress.XtraBars.Docking.DockPanel();
            this.controlContainer1 = new DevExpress.XtraBars.Docking.ControlContainer();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.crewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.crewDataSet = new Current.Database.CrewDataSet();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFullName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAddress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPhone = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHasBasicTraining = new DevExpress.XtraGrid.Columns.GridColumn();
            this.documentManagerApplicationContent = new DevExpress.XtraBars.Docking2010.DocumentManager(this.components);
            this.tabbedView1 = new DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView(this.components);
            this.workspaceManager = new DevExpress.Utils.WorkspaceManager(this.components);
            this.crewTableAdapter = new Current.Database.CrewDataSetTableAdapters.CrewTableAdapter();
            this.ribbonPageGroupCrew = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.barButtonItemAddNewCrew = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.documentGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.document1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.document2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManagerApplicationContent)).BeginInit();
            this.dockPanelCableList.SuspendLayout();
            this.dockPanel1_Container.SuspendLayout();
            this.dockPanelCrewList.SuspendLayout();
            this.controlContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.crewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.crewDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentManagerApplicationContent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView1)).BeginInit();
            this.SuspendLayout();
            // 
            // documentGroup1
            // 
            this.documentGroup1.Items.AddRange(new DevExpress.XtraBars.Docking2010.Views.Tabbed.Document[] {
            this.document1,
            this.document2});
            // 
            // document1
            // 
            this.document1.Caption = "Cable List";
            this.document1.ControlName = "dockPanelCableList";
            this.document1.FloatLocation = new System.Drawing.Point(0, 0);
            this.document1.FloatSize = new System.Drawing.Size(200, 200);
            this.document1.Properties.AllowClose = DevExpress.Utils.DefaultBoolean.True;
            this.document1.Properties.AllowFloat = DevExpress.Utils.DefaultBoolean.True;
            this.document1.Properties.AllowFloatOnDoubleClick = DevExpress.Utils.DefaultBoolean.True;
            // 
            // document2
            // 
            this.document2.Caption = "Crew List";
            this.document2.ControlName = "dockPanelCrewList";
            this.document2.FloatLocation = new System.Drawing.Point(0, 0);
            this.document2.FloatSize = new System.Drawing.Size(200, 200);
            this.document2.Properties.AllowClose = DevExpress.Utils.DefaultBoolean.True;
            this.document2.Properties.AllowFloat = DevExpress.Utils.DefaultBoolean.True;
            this.document2.Properties.AllowFloatOnDoubleClick = DevExpress.Utils.DefaultBoolean.True;
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.barButtonItemAddNewCable,
            this.barButtonItemAddNewCrew});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 4;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPageDocumentation});
            this.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013;
            this.ribbonControl1.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.ShowDisplayOptionsMenuButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.Size = new System.Drawing.Size(1278, 154);
            // 
            // barButtonItemAddNewCable
            // 
            this.barButtonItemAddNewCable.Caption = "Add New";
            this.barButtonItemAddNewCable.Id = 1;
            this.barButtonItemAddNewCable.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItemAddNewCable.ImageOptions.SvgImage")));
            this.barButtonItemAddNewCable.Name = "barButtonItemAddNewCable";
            this.barButtonItemAddNewCable.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemAddNewCable_ItemClick);
            // 
            // ribbonPageDocumentation
            // 
            this.ribbonPageDocumentation.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroupCables,
            this.ribbonPageGroupCrew});
            this.ribbonPageDocumentation.Name = "ribbonPageDocumentation";
            this.ribbonPageDocumentation.Text = "Documentation";
            // 
            // ribbonPageGroupCables
            // 
            this.ribbonPageGroupCables.ItemLinks.Add(this.barButtonItemAddNewCable);
            this.ribbonPageGroupCables.Name = "ribbonPageGroupCables";
            this.ribbonPageGroupCables.Text = "Cables";
            // 
            // dockManagerApplicationContent
            // 
            this.dockManagerApplicationContent.Form = this;
            this.dockManagerApplicationContent.RootPanels.AddRange(new DevExpress.XtraBars.Docking.DockPanel[] {
            this.dockPanelCableList,
            this.dockPanelCrewList});
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
            // dockPanelCableList
            // 
            this.dockPanelCableList.Controls.Add(this.dockPanel1_Container);
            this.dockPanelCableList.DockedAsTabbedDocument = true;
            this.dockPanelCableList.ID = new System.Guid("ada24b00-ba54-4ebf-98d1-c507d6693587");
            this.dockPanelCableList.Name = "dockPanelCableList";
            this.dockPanelCableList.OriginalSize = new System.Drawing.Size(200, 200);
            this.dockPanelCableList.Text = "Cable List";
            // 
            // dockPanel1_Container
            // 
            this.dockPanel1_Container.Controls.Add(this.cableListCtrl);
            this.dockPanel1_Container.Location = new System.Drawing.Point(0, 0);
            this.dockPanel1_Container.Name = "dockPanel1_Container";
            this.dockPanel1_Container.Size = new System.Drawing.Size(1272, 614);
            this.dockPanel1_Container.TabIndex = 0;
            // 
            // cableListCtrl
            // 
            this.cableListCtrl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cableListCtrl.Location = new System.Drawing.Point(0, 0);
            this.cableListCtrl.Name = "cableListCtrl";
            this.cableListCtrl.Size = new System.Drawing.Size(1272, 614);
            this.cableListCtrl.TabIndex = 0;
            // 
            // dockPanelCrewList
            // 
            this.dockPanelCrewList.Controls.Add(this.controlContainer1);
            this.dockPanelCrewList.DockedAsTabbedDocument = true;
            this.dockPanelCrewList.ID = new System.Guid("584dd136-0b5c-418a-a5b9-51bff70fb0e0");
            this.dockPanelCrewList.Name = "dockPanelCrewList";
            this.dockPanelCrewList.OriginalSize = new System.Drawing.Size(200, 200);
            this.dockPanelCrewList.Text = "Crew List";
            // 
            // controlContainer1
            // 
            this.controlContainer1.Controls.Add(this.gridControl1);
            this.controlContainer1.Location = new System.Drawing.Point(0, 0);
            this.controlContainer1.Name = "controlContainer1";
            this.controlContainer1.Size = new System.Drawing.Size(1272, 614);
            this.controlContainer1.TabIndex = 0;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.crewBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.MenuManager = this.ribbonControl1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1272, 614);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // crewBindingSource
            // 
            this.crewBindingSource.DataMember = "Crew";
            this.crewBindingSource.DataSource = this.crewDataSet;
            // 
            // crewDataSet
            // 
            this.crewDataSet.DataSetName = "CrewDataSet";
            this.crewDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colFullName,
            this.colEmail,
            this.colAddress,
            this.colPhone,
            this.colHasBasicTraining});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.Visible = true;
            this.colId.VisibleIndex = 0;
            this.colId.Width = 30;
            // 
            // colFullName
            // 
            this.colFullName.FieldName = "FullName";
            this.colFullName.Name = "colFullName";
            this.colFullName.Visible = true;
            this.colFullName.VisibleIndex = 1;
            this.colFullName.Width = 175;
            // 
            // colEmail
            // 
            this.colEmail.FieldName = "Email";
            this.colEmail.Name = "colEmail";
            this.colEmail.Visible = true;
            this.colEmail.VisibleIndex = 2;
            this.colEmail.Width = 250;
            // 
            // colAddress
            // 
            this.colAddress.FieldName = "Address";
            this.colAddress.Name = "colAddress";
            this.colAddress.Visible = true;
            this.colAddress.VisibleIndex = 3;
            this.colAddress.Width = 250;
            // 
            // colPhone
            // 
            this.colPhone.FieldName = "Phone";
            this.colPhone.Name = "colPhone";
            this.colPhone.Visible = true;
            this.colPhone.VisibleIndex = 4;
            this.colPhone.Width = 150;
            // 
            // colHasBasicTraining
            // 
            this.colHasBasicTraining.Caption = "BT";
            this.colHasBasicTraining.FieldName = "HasBasicTraining";
            this.colHasBasicTraining.Name = "colHasBasicTraining";
            this.colHasBasicTraining.ToolTip = "Has basic training.";
            this.colHasBasicTraining.Visible = true;
            this.colHasBasicTraining.VisibleIndex = 5;
            this.colHasBasicTraining.Width = 30;
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
            this.document1,
            this.document2});
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
            // crewTableAdapter
            // 
            this.crewTableAdapter.ClearBeforeFill = true;
            // 
            // ribbonPageGroupCrew
            // 
            this.ribbonPageGroupCrew.ItemLinks.Add(this.barButtonItemAddNewCrew);
            this.ribbonPageGroupCrew.Name = "ribbonPageGroupCrew";
            this.ribbonPageGroupCrew.Text = "Crew";
            // 
            // barButtonItemAddNewCrew
            // 
            this.barButtonItemAddNewCrew.Caption = "Add New";
            this.barButtonItemAddNewCrew.Id = 2;
            this.barButtonItemAddNewCrew.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItemAddNewCrew.ImageOptions.SvgImage")));
            this.barButtonItemAddNewCrew.Name = "barButtonItemAddNewCrew";
            this.barButtonItemAddNewCrew.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemAddNewCrew_ItemClick);
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
            ((System.ComponentModel.ISupportInitialize)(this.document2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManagerApplicationContent)).EndInit();
            this.dockPanelCableList.ResumeLayout(false);
            this.dockPanel1_Container.ResumeLayout(false);
            this.dockPanelCrewList.ResumeLayout(false);
            this.controlContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.crewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.crewDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentManagerApplicationContent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPageDocumentation;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroupCables;
        private DevExpress.XtraBars.Docking.DockManager dockManagerApplicationContent;
        private DevExpress.XtraBars.Docking.DockPanel dockPanelCableList;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanel1_Container;
        private DevExpress.XtraBars.Docking2010.DocumentManager documentManagerApplicationContent;
        private DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView tabbedView1;
        private DevExpress.XtraBars.Docking2010.Views.Tabbed.DocumentGroup documentGroup1;
        private DevExpress.XtraBars.Docking2010.Views.Tabbed.Document document1;
        private CableListControl cableListCtrl;
        private DevExpress.Utils.WorkspaceManager workspaceManager;
        private DevExpress.XtraBars.BarButtonItem barButtonItemAddNewCable;
        private DevExpress.XtraBars.Docking2010.Views.Tabbed.Document document2;
        private DevExpress.XtraBars.Docking.DockPanel dockPanelCrewList;
        private DevExpress.XtraBars.Docking.ControlContainer controlContainer1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private Database.CrewDataSet crewDataSet;
        private System.Windows.Forms.BindingSource crewBindingSource;
        private Database.CrewDataSetTableAdapters.CrewTableAdapter crewTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colFullName;
        private DevExpress.XtraGrid.Columns.GridColumn colEmail;
        private DevExpress.XtraGrid.Columns.GridColumn colAddress;
        private DevExpress.XtraGrid.Columns.GridColumn colPhone;
        private DevExpress.XtraGrid.Columns.GridColumn colHasBasicTraining;
        private DevExpress.XtraBars.BarButtonItem barButtonItemAddNewCrew;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroupCrew;
    }
}

