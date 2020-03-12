using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Current.Helpers
{
    public static class MessageBoxes
    {
        public static void ShowProblemWhenAddingDataMessage()
        {
            MessageBox.Show("A problem occured when adding new data!", "A problem occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
