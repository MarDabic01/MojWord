using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MojProstorImena
{
    class MojeMetode
    {
        static private Color originalMenuBackColor = new Color();
        static private Color originalMenuFontColor = new Color();

        static public void ChangeMenuColors(ToolStripMenuItem menu1, ToolStripMenuItem menu2)
        {
            originalMenuBackColor = Color.RoyalBlue;
            originalMenuFontColor = Color.FromArgb(255, 255, 255, 255);

            menu1.BackColor = originalMenuBackColor;
            menu2.BackColor = originalMenuBackColor;

            menu1.ForeColor = originalMenuFontColor;
            menu2.ForeColor = originalMenuFontColor;
        }

        public static void PaintHighlightComboBox(ComboBox comboBox)
        {

        }
    }
}
