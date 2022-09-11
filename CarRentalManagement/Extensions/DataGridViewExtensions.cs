using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentalManagement.Extensions
{
    public static class DataGridViewExtensions
    {
        public static void SetupRowColor(this DataGridView dataGridView)
        {
            var evenColor = Color.FromArgb(175, 238, 238);
            var oddColor = Color.FromArgb(240, 255, 255);
            dataGridView.SetupRowColor(evenColor, oddColor);
           
        }

        public static void SetupRowColor(this DataGridView dataGridView, Color oddColor, Color evenColor)
        {
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                if (row.Index % 2 == 0)
                {
                    row.DefaultCellStyle.BackColor = evenColor;
                }
                else
                {
                    row.DefaultCellStyle.BackColor = oddColor;
                }
            }
        }
    }
}
