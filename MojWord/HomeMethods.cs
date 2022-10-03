using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MojWord
{
    class HomeMethods
    {
        //Changing Font
        public static void HomeChangeFont(ComboBox comboBox1, ComboBox comboBox2, RichTextBox richTextBox1, Font[] fontovi, int[] fontoviVelicina)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0: richTextBox1.SelectionFont = new Font(fontovi[0].Name, fontoviVelicina[comboBox2.SelectedIndex]); break;
                case 1: richTextBox1.SelectionFont = new Font(fontovi[1].Name, fontoviVelicina[comboBox2.SelectedIndex]); break;
                case 2: richTextBox1.SelectionFont = new Font(fontovi[2].Name, fontoviVelicina[comboBox2.SelectedIndex]); break;
                case 3: richTextBox1.SelectionFont = new Font(fontovi[3].Name, fontoviVelicina[comboBox2.SelectedIndex]); break;
                case 4: richTextBox1.SelectionFont = new Font(fontovi[4].Name, fontoviVelicina[comboBox2.SelectedIndex]); break;
                case 5: richTextBox1.SelectionFont = new Font(fontovi[5].Name, fontoviVelicina[comboBox2.SelectedIndex]); break;
                case 6: richTextBox1.SelectionFont = new Font(fontovi[6].Name, fontoviVelicina[comboBox2.SelectedIndex]); break;
                case 7: richTextBox1.SelectionFont = new Font(fontovi[7].Name, fontoviVelicina[comboBox2.SelectedIndex]); break;
                case 8: richTextBox1.SelectionFont = new Font(fontovi[8].Name, fontoviVelicina[comboBox2.SelectedIndex]); break;
                case 9: richTextBox1.SelectionFont = new Font(fontovi[9].Name, fontoviVelicina[comboBox2.SelectedIndex]); break;
            }
        }
        //Changing Font Size
        public static void HomeChangeFontSize(ComboBox comboBox1, ComboBox comboBox2, RichTextBox richTextBox1, Font[] fontovi, int[] fontoviVelicina)
        {
            switch (comboBox2.SelectedIndex)
            {
                case 0: richTextBox1.SelectionFont = new Font(fontovi[comboBox1.SelectedIndex].Name, 7); break;
                case 1: richTextBox1.SelectionFont = new Font(fontovi[comboBox1.SelectedIndex].Name, 9); break;
                case 2: richTextBox1.SelectionFont = new Font(fontovi[comboBox1.SelectedIndex].Name, 10); break;
                case 3: richTextBox1.SelectionFont = new Font(fontovi[comboBox1.SelectedIndex].Name, 11); break;
                case 4: richTextBox1.SelectionFont = new Font(fontovi[comboBox1.SelectedIndex].Name, 12); break;
                case 5: richTextBox1.SelectionFont = new Font(fontovi[comboBox1.SelectedIndex].Name, 15); break;
                case 6: richTextBox1.SelectionFont = new Font(fontovi[comboBox1.SelectedIndex].Name, 17); break;
                case 7: richTextBox1.SelectionFont = new Font(fontovi[comboBox1.SelectedIndex].Name, 19); break;
                case 8: richTextBox1.SelectionFont = new Font(fontovi[comboBox1.SelectedIndex].Name, 21); break;
                case 9: richTextBox1.SelectionFont = new Font(fontovi[comboBox1.SelectedIndex].Name, 23); break;
                case 10: richTextBox1.SelectionFont = new Font(fontovi[comboBox1.SelectedIndex].Name, 25); break;
                case 11: richTextBox1.SelectionFont = new Font(fontovi[comboBox1.SelectedIndex].Name, 27); break;
                case 12: richTextBox1.SelectionFont = new Font(fontovi[comboBox1.SelectedIndex].Name, 30); break;
            }
        }
        //Bold Text
        public static void BoldButton(ComboBox comboBox1, ComboBox comboBox2, RichTextBox richTextBox1, Font[] fontovi, int[] fontoviVelicina)
        {
            if (richTextBox1.SelectionFont.Style != FontStyle.Bold)
                richTextBox1.SelectionFont = new Font(fontovi[comboBox1.SelectedIndex].Name, fontoviVelicina[comboBox2.SelectedIndex], FontStyle.Bold);
            else
                richTextBox1.SelectionFont = new Font(fontovi[comboBox1.SelectedIndex].Name, fontoviVelicina[comboBox2.SelectedIndex], FontStyle.Regular);
        }
        //Italic Text
        public static void ItalicButton(ComboBox comboBox1, ComboBox comboBox2, RichTextBox richTextBox1, Font[] fontovi, int[] fontoviVelicina)
        {
            if (richTextBox1.SelectionFont.Style != FontStyle.Italic)
                richTextBox1.SelectionFont = new Font(fontovi[comboBox1.SelectedIndex].Name, fontoviVelicina[comboBox2.SelectedIndex], FontStyle.Italic);
            else
                richTextBox1.SelectionFont = new Font(fontovi[comboBox1.SelectedIndex].Name, fontoviVelicina[comboBox2.SelectedIndex], FontStyle.Regular);
        }
        //Underline Text
        public static void UnderlineButton(ComboBox comboBox1, ComboBox comboBox2, RichTextBox richTextBox1, Font[] fontovi, int[] fontoviVelicina)
        {
            if (richTextBox1.SelectionFont.Style != FontStyle.Underline)
                richTextBox1.SelectionFont = new Font(fontovi[comboBox1.SelectedIndex].Name, fontoviVelicina[comboBox2.SelectedIndex], FontStyle.Underline);
            else
                richTextBox1.SelectionFont = new Font(fontovi[comboBox1.SelectedIndex].Name, fontoviVelicina[comboBox2.SelectedIndex], FontStyle.Regular);
        }
        //Bigger Font
        public static void BiggerFont(ComboBox comboBox1, ComboBox comboBox2, RichTextBox richTextBox1, Font[] fontovi, int[] fontoviVelicina)
        {
            if (fontoviVelicina[comboBox2.SelectedIndex] < 30)
            {
                richTextBox1.SelectionFont = new Font(fontovi[comboBox1.SelectedIndex].Name, fontoviVelicina[comboBox2.SelectedIndex + 1]);
                comboBox2.Text = fontoviVelicina[comboBox2.SelectedIndex + 1].ToString();
            }
            else
            {
                richTextBox1.SelectionFont = new Font(fontovi[comboBox1.SelectedIndex].Name, richTextBox1.SelectionFont.Size + 2);
                comboBox2.Text = (richTextBox1.SelectionFont.Size + 2).ToString();
            }
        }
        //Lower Font
        public static void LowerFont(ComboBox comboBox1, ComboBox comboBox2, RichTextBox richTextBox1, Font[] fontovi, int[] fontoviVelicina)
        {
            if (fontoviVelicina[comboBox2.SelectedIndex] < 30 && fontoviVelicina[comboBox2.SelectedIndex] > 7)
            {
                richTextBox1.SelectionFont = new Font(fontovi[comboBox1.SelectedIndex].Name, fontoviVelicina[comboBox2.SelectedIndex - 1]);
                comboBox2.Text = fontoviVelicina[comboBox2.SelectedIndex - 1].ToString();
            }
            else if (fontoviVelicina[comboBox2.SelectedIndex] != 7)
            {
                richTextBox1.SelectionFont = new Font(fontovi[comboBox1.SelectedIndex].Name, richTextBox1.SelectionFont.Size - 2);
                comboBox2.Text = (richTextBox1.SelectionFont.Size - 2).ToString();
            }
        }
        //Show Highlight Menu
        public static void ShowHighlightMenu(GroupBox groupBox2,GroupBox groupBox3)
        {
            if (groupBox2.Visible == false)
            {
                groupBox2.Visible = true;
                groupBox3.Visible = false;
            }
            else
                groupBox2.Visible = false;
        }
        //Change font highlight
        public static void ChangeFontHighlight(RichTextBox richTextBox1,int x)
        {
            switch (x)
            {
                case 0:
                    if (richTextBox1.SelectionBackColor != Color.Yellow)
                        richTextBox1.SelectionBackColor = Color.Yellow;
                    else
                        richTextBox1.SelectionBackColor = Color.White;
                    break;
                case 1:
                    if (richTextBox1.SelectionBackColor != Color.Red)
                        richTextBox1.SelectionBackColor = Color.Red;
                    else
                        richTextBox1.SelectionBackColor = Color.White;
                    break;
                case 2:
                    if (richTextBox1.SelectionBackColor != Color.Aqua)
                        richTextBox1.SelectionBackColor = Color.Aqua;
                    else
                        richTextBox1.SelectionBackColor = Color.White;
                    break;
                case 3:
                    if (richTextBox1.SelectionBackColor != Color.Green)
                        richTextBox1.SelectionBackColor = Color.Green;
                    else
                        richTextBox1.SelectionBackColor = Color.White;
                    break;
            }
        }
        //Show font color menu
        public static void ShowFontColorMenu(GroupBox groupBox3,GroupBox groupBox2)
        {
            if (groupBox3.Visible == false)
            {
                groupBox3.Visible = true;
                groupBox2.Visible = false;
            }
            else
                groupBox3.Visible = false;
        }
        //Change font color
        public static void ChangeFontColor(RichTextBox richTextBox1,int x)
        {
            switch(x)
            {
                case 0:
                    if (richTextBox1.SelectionColor != Color.Yellow)
                        richTextBox1.SelectionColor = Color.Yellow;
                    else
                        richTextBox1.SelectionColor = Color.Black;
                    break;
                case 1:
                    if (richTextBox1.SelectionColor != Color.Red)
                        richTextBox1.SelectionColor = Color.Red;
                    else
                        richTextBox1.SelectionColor = Color.Black;
                    break;
                case 2:
                    if (richTextBox1.SelectionColor != Color.Aqua)
                        richTextBox1.SelectionColor = Color.Aqua;
                    else
                        richTextBox1.SelectionColor = Color.Black;
                    break;
                case 3:
                    if (richTextBox1.SelectionColor != Color.Green)
                        richTextBox1.SelectionColor = Color.Green;
                    else
                        richTextBox1.SelectionColor = Color.Black;
                    break;
            }
        }
    }
}
