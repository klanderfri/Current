namespace Current.GUI.Controls
{
    partial class CableListControl
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
            this.bandedGridColumnCableID = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.bandedGridColumnCableLength = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.bandedGridColumnCableColour = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.bandedGridColumnCableDiameter = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBandCable = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.gridBandDirection = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.bandedGridColumnDirectionFrom = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.bandedGridColumnDirectionTo = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.bandedGridColumnCableFromDiameter = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.bandedGridColumnCableToDiameter = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
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
            this.gridBandCable,
            this.gridBandDirection});
            this.bandedGridView1.Columns.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn[] {
            this.bandedGridColumnCableID,
            this.bandedGridColumnCableLength,
            this.bandedGridColumnCableColour,
            this.bandedGridColumnCableDiameter,
            this.bandedGridColumnDirectionFrom,
            this.bandedGridColumnDirectionTo,
            this.bandedGridColumnCableFromDiameter,
            this.bandedGridColumnCableToDiameter});
            this.bandedGridView1.GridControl = this.gridControl1;
            this.bandedGridView1.Name = "bandedGridView1";
            this.bandedGridView1.OptionsView.ColumnAutoWidth = false;
            // 
            // bandedGridColumnCableID
            // 
            this.bandedGridColumnCableID.Caption = "ID";
            this.bandedGridColumnCableID.FieldName = "ID";
            this.bandedGridColumnCableID.Name = "bandedGridColumnCableID";
            this.bandedGridColumnCableID.Visible = true;
            this.bandedGridColumnCableID.Width = 30;
            // 
            // bandedGridColumnCableLength
            // 
            this.bandedGridColumnCableLength.Caption = "Length";
            this.bandedGridColumnCableLength.FieldName = "LengthInMeter";
            this.bandedGridColumnCableLength.Name = "bandedGridColumnCableLength";
            this.bandedGridColumnCableLength.Visible = true;
            // 
            // bandedGridColumnCableColour
            // 
            this.bandedGridColumnCableColour.Caption = "Colour";
            this.bandedGridColumnCableColour.FieldName = "Colour";
            this.bandedGridColumnCableColour.Name = "bandedGridColumnCableColour";
            this.bandedGridColumnCableColour.Visible = true;
            // 
            // bandedGridColumnCableDiameter
            // 
            this.bandedGridColumnCableDiameter.Caption = "Diameter";
            this.bandedGridColumnCableDiameter.FieldName = "DiameterInMeter";
            this.bandedGridColumnCableDiameter.Name = "bandedGridColumnCableDiameter";
            this.bandedGridColumnCableDiameter.Visible = true;
            // 
            // gridBandCable
            // 
            this.gridBandCable.Caption = "Cable";
            this.gridBandCable.Columns.Add(this.bandedGridColumnCableID);
            this.gridBandCable.Columns.Add(this.bandedGridColumnCableLength);
            this.gridBandCable.Columns.Add(this.bandedGridColumnCableDiameter);
            this.gridBandCable.Columns.Add(this.bandedGridColumnCableColour);
            this.gridBandCable.Name = "gridBandCable";
            this.gridBandCable.VisibleIndex = 0;
            this.gridBandCable.Width = 255;
            // 
            // gridBandDirection
            // 
            this.gridBandDirection.Caption = "Direction";
            this.gridBandDirection.Columns.Add(this.bandedGridColumnDirectionFrom);
            this.gridBandDirection.Columns.Add(this.bandedGridColumnCableFromDiameter);
            this.gridBandDirection.Columns.Add(this.bandedGridColumnDirectionTo);
            this.gridBandDirection.Columns.Add(this.bandedGridColumnCableToDiameter);
            this.gridBandDirection.Name = "gridBandDirection";
            this.gridBandDirection.VisibleIndex = 1;
            this.gridBandDirection.Width = 450;
            // 
            // bandedGridColumnDirectionFrom
            // 
            this.bandedGridColumnDirectionFrom.Caption = "From";
            this.bandedGridColumnDirectionFrom.FieldName = "From";
            this.bandedGridColumnDirectionFrom.Name = "bandedGridColumnDirectionFrom";
            this.bandedGridColumnDirectionFrom.Visible = true;
            this.bandedGridColumnDirectionFrom.Width = 150;
            // 
            // bandedGridColumnDirectionTo
            // 
            this.bandedGridColumnDirectionTo.Caption = "To";
            this.bandedGridColumnDirectionTo.FieldName = "To";
            this.bandedGridColumnDirectionTo.Name = "bandedGridColumnDirectionTo";
            this.bandedGridColumnDirectionTo.Visible = true;
            this.bandedGridColumnDirectionTo.Width = 150;
            // 
            // bandedGridColumnCableFromDiameter
            // 
            this.bandedGridColumnCableFromDiameter.Caption = "Fr. Diameter";
            this.bandedGridColumnCableFromDiameter.FieldName = "FromConnectionDiameterInMeter";
            this.bandedGridColumnCableFromDiameter.Name = "bandedGridColumnCableFromDiameter";
            this.bandedGridColumnCableFromDiameter.Visible = true;
            // 
            // bandedGridColumnCableToDiameter
            // 
            this.bandedGridColumnCableToDiameter.Caption = "To Diameter";
            this.bandedGridColumnCableToDiameter.FieldName = "ToConnectionDiameterInMeter";
            this.bandedGridColumnCableToDiameter.Name = "bandedGridColumnCableToDiameter";
            this.bandedGridColumnCableToDiameter.Visible = true;
            // 
            // CableListControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControl1);
            this.Name = "CableListControl";
            this.Size = new System.Drawing.Size(1199, 623);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bandedGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridView bandedGridView1;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBandCable;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bandedGridColumnCableID;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bandedGridColumnCableLength;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bandedGridColumnCableDiameter;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bandedGridColumnCableColour;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBandDirection;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bandedGridColumnDirectionFrom;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bandedGridColumnCableFromDiameter;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bandedGridColumnDirectionTo;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bandedGridColumnCableToDiameter;
    }
}
