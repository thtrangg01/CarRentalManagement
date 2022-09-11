using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentalManagement.Extensions
{
    public static class ControlsExtensions
    {
        public static void VisibleOrHide(this Control control, bool isVisible)
        {
            if (isVisible)
            {
                control.Visible = true;
            }
        }
    }
}
