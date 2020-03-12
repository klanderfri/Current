using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Current.GUI.BaseComponents;
using Current.DataObjects;

namespace Current.GUI.Controls
{
    public partial class CableListControl : ParentUserControl
    {
        private BindingList<Cable> DataSource
        {
            get { return gridControl1.DataSource as BindingList<Cable>; }
            set { gridControl1.DataSource = value; }
        }

        public CableListControl()
        {
            InitializeComponent();

            DataSource = new BindingList<Cable>();
        }

        public void AddNewCable()
        {
            throw new NotImplementedException();
        }
    }
}
