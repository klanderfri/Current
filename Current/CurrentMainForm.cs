using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Current
{
    public partial class CurrentMainForm : RibbonForm
    {
        /// <summary>
        /// The name of the last layout the user had.
        /// </summary>
        private string LastUserLayoutName { get; } = "LastUserLayout";

        /// <summary>
        /// The name of the file containing the last layout the user had.
        /// </summary>
        private string LastUserLayoutFile
        {
            get { return String.Concat(LastUserLayoutName, ".xml"); }
        }

        public CurrentMainForm()
        {
            InitializeComponent();
        }

        private void CurrentMainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            workspaceManager.CaptureWorkspace(LastUserLayoutName, true);
            workspaceManager.SaveWorkspace(LastUserLayoutName, LastUserLayoutFile, true);
        }

        private void CurrentMainForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'crewDataSet.Crew' table. You can move, or remove it, as needed.
            this.crewTableAdapter.Fill(this.crewDataSet.Crew);
            if (workspaceManager.LoadWorkspace(LastUserLayoutName, LastUserLayoutFile, true))
            {
                workspaceManager.ApplyWorkspace(LastUserLayoutName);
            }
        }

        private void barButtonItemAddNewCable_ItemClick(object sender, ItemClickEventArgs e)
        {
            cableListCtrl.AddNewCable();
        }

        private void barButtonItemAddNewCrew_ItemClick(object sender, ItemClickEventArgs e)
        {

        }
    }
}
