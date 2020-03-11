namespace Current
{
    partial class CabelListControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.bandedGridView1 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridView();
            this.bandedGridColumnCabelID = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.bandedGridColumnCabelLength = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.bandedGridColumnCabelColour = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.bandedGridColumnCabelDiameter = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBandCabel = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.gridBandDirection = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.bandedGridColumnDirectionFrom = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.bandedGridColumnDirectionTo = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.bandedGridColumnCabelFromDiameter = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.bandedGridColumnCabelToDiameter = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bandedGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.bandedGridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1199, 623);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.bandedGridView1});
            // 
            // bandedGridView1
            // 
            this.bandedGridView1.Bands.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.gridBandCabel,
            this.gridBandDirection});
            this.bandedGridView1.Columns.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn[] {
            this.bandedGridColumnCabelID,
            this.bandedGridColumnCabelLength,
            this.bandedGridColumnCabelColour,
            this.bandedGridColumnCabelDiameter,
            this.bandedGridColumnDirectionFrom,
            this.bandedGridColumnDirectionTo,
            this.bandedGridColumnCabelFromDiameter,
            this.bandedGridColumnCabelToDiameter});
            this.bandedGridView1.GridControl = this.gridControl1;
            this.bandedGridView1.Name = "bandedGridView1";
            this.bandedGridView1.OptionsView.ColumnAutoWidth = false;
            // 
            // bandedGridColumnCabelID
            // 
            this.bandedGridColumnCabelID.Caption = "ID";
            this.bandedGridColumnCabelID.Name = "bandedGridColumnCabelID";
            this.bandedGridColumnCabelID.Visible = true;
            this.bandedGridColumnCabelID.Width = 30;
            // 
            // bandedGridColumnCabelLength
            // 
            this.bandedGridColumnCabelLength.Caption = "Length";
            this.bandedGridColumnCabelLength.Name = "bandedGridColumnCabelLength";
            this.bandedGridColumnCabelLength.Visible = true;
            // 
            // bandedGridColumnCabelColour
            // 
            this.bandedGridColumnCabelColour.Caption = "Colour";
            this.bandedGridColumnCabelColour.Name = "bandedGridColumnCabelColour";
            this.bandedGridColumnCabelColour.Visible = true;
            // 
            // bandedGridColumnCabelDiameter
            // 
            this.bandedGridColumnCabelDiameter.Caption = "Diameter";
            this.bandedGridColumnCabelDiameter.Name = "bandedGridColumnCabelDiameter";
            this.bandedGridColumnCabelDiameter.Visible = true;
            // 
            // gridBandCabel
            // 
            this.gridBandCabel.Caption = "Cabel";
            this.gridBandCabel.Columns.Add(this.bandedGridColumnCabelID);
            this.gridBandCabel.Columns.Add(this.bandedGridColumnCabelLength);
            this.gridBandCabel.Columns.Add(this.bandedGridColumnCabelDiameter);
            this.gridBandCabel.Columns.Add(this.bandedGridColumnCabelColour);
            this.gridBandCabel.Name = "gridBandCabel";
            this.gridBandCabel.VisibleIndex = 0;
            this.gridBandCabel.Width = 255;
            // 
            // gridBandDirection
            // 
            this.gridBandDirection.Caption = "Direction";
            this.gridBandDirection.Columns.Add(this.bandedGridColumnDirectionFrom);
            this.gridBandDirection.Columns.Add(this.bandedGridColumnCabelFromDiameter);
            this.gridBandDirection.Columns.Add(this.bandedGridColumnDirectionTo);
            this.gridBandDirection.Columns.Add(this.bandedGridColumnCabelToDiameter);
            this.gridBandDirection.Name = "gridBandDirection";
            this.gridBandDirection.VisibleIndex = 1;
            this.gridBandDirection.Width = 450;
            // 
            // bandedGridColumnDirectionFrom
            // 
            this.bandedGridColumnDirectionFrom.Caption = "From";
            this.bandedGridColumnDirectionFrom.Name = "bandedGridColumnDirectionFrom";
            this.bandedGridColumnDirectionFrom.Visible = true;
            this.bandedGridColumnDirectionFrom.Width = 150;
            // 
            // bandedGridColumnDirectionTo
            // 
            this.bandedGridColumnDirectionTo.Caption = "To";
            this.bandedGridColumnDirectionTo.Name = "bandedGridColumnDirectionTo";
            this.bandedGridColumnDirectionTo.Visible = true;
            this.bandedGridColumnDirectionTo.Width = 150;
            // 
            // bandedGridColumnCabelFromDiameter
            // 
            this.bandedGridColumnCabelFromDiameter.Caption = "Fr. Diameter";
            this.bandedGridColumnCabelFromDiameter.Name = "bandedGridColumnCabelFromDiameter";
            this.bandedGridColumnCabelFromDiameter.Visible = true;
            // 
            // bandedGridColumnCabelToDiameter
            // 
            this.bandedGridColumnCabelToDiameter.Caption = "To Diameter";
            this.bandedGridColumnCabelToDiameter.Name = "bandedGridColumnCabelToDiameter";
            this.bandedGridColumnCabelToDiameter.Visible = true;
            // 
            // CabelListControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControl1);
            this.Name = "CabelListControl";
            this.Size = new System.Drawing.Size(1199, 623);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bandedGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridView bandedGridView1;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBandCabel;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bandedGridColumnCabelID;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bandedGridColumnCabelLength;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bandedGridColumnCabelDiameter;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bandedGridColumnCabelColour;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBandDirection;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bandedGridColumnDirectionFrom;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bandedGridColumnCabelFromDiameter;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bandedGridColumnDirectionTo;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bandedGridColumnCabelToDiameter;
    }
}
