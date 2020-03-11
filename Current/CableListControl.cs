using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Current
{
    public partial class CableListControl : ParentUserControl
    {
        public CableListControl()
        {
            InitializeComponent();

            gridControl1.DataSource = new BindingList<Cable>();
        }

        public void AddNewCable()
        {
            throw new NotImplementedException();
        }
    }
}
