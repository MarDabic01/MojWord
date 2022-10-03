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
    public partial class Form1 : Form
    {
        //Colors for menu
        private Color onClickMenuColor = new Color();
        private Color onClickMenuFontColor = new Color();
        //Fonts
        static public Font[] fontovi = new Font[10];
        static public int[] fontoviVelicina = new int[13];

        public Form1()
        {
            InitializeComponent();

            //Colors for menu
            onClickMenuColor = Color.FromArgb(255, 230, 230, 230);
            onClickMenuFontColor = Color.FromArgb(255, 3, 90, 252);

            //Setting default menu colors
            homeToolStripMenuItem.BackColor = onClickMenuColor;
            homeToolStripMenuItem.ForeColor = onClickMenuFontColor;

            //Setting default value of Font Style combo box
            MojWord.Metode.FontInit(fontovi);
            MojWord.Metode.FontSizeInit(fontoviVelicina);
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 1;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
        }

        //Menu home
        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MojProstorImena.MojeMetode.ChangeMenuColors(designToolStripMenuItem, insertToolStripMenuItem);

            homeToolStripMenuItem.BackColor = onClickMenuColor;
            homeToolStripMenuItem.ForeColor = onClickMenuFontColor;
        }

        //Menu design
        private void designToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MojProstorImena.MojeMetode.ChangeMenuColors(homeToolStripMenuItem, insertToolStripMenuItem);

            designToolStripMenuItem.BackColor = onClickMenuColor;
            designToolStripMenuItem.ForeColor = onClickMenuFontColor;
        }

        //Menu insert
        private void insertToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MojProstorImena.MojeMetode.ChangeMenuColors(designToolStripMenuItem, homeToolStripMenuItem);

            insertToolStripMenuItem.BackColor = onClickMenuColor;
            insertToolStripMenuItem.ForeColor = onClickMenuFontColor;
        }

        //Changes Font
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            HomeMethods.HomeChangeFont(comboBox1, comboBox2,richTextBox1, fontovi, fontoviVelicina);
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        //Changes font size
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            HomeMethods.HomeChangeFontSize(comboBox1, comboBox2, richTextBox1, fontovi, fontoviVelicina);
        }

        //Bold text button
        private void button1_Click(object sender, EventArgs e)
        {
            HomeMethods.BoldButton(comboBox1, comboBox2, richTextBox1, fontovi, fontoviVelicina);
        }

        //Italic text button
        private void button2_Click(object sender, EventArgs e)
        {
            HomeMethods.ItalicButton(comboBox1, comboBox2, richTextBox1, fontovi, fontoviVelicina);
        }

        //Underline text button
        private void button3_Click(object sender, EventArgs e)
        {
            HomeMethods.UnderlineButton(comboBox1, comboBox2, richTextBox1, fontovi, fontoviVelicina);
        }

        //Bigger font
        private void button6_Click(object sender, EventArgs e)
        {
            HomeMethods.BiggerFont(comboBox1, comboBox2, richTextBox1, fontovi, fontoviVelicina);
        }

        //Lower font
        private void button7_Click(object sender, EventArgs e)
        {
            HomeMethods.LowerFont(comboBox1, comboBox2, richTextBox1, fontovi, fontoviVelicina);
        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        //Show highlight menu
        private void button8_Click_1(object sender, EventArgs e)
        {
            HomeMethods.ShowHighlightMenu(groupBox2,groupBox3);
        }
        //Yellow highlight
        private void button10_Click(object sender, EventArgs e)
        {
            HomeMethods.ChangeFontHighlight(richTextBox1, 0);
        }
        //Red highlight
        private void button11_Click(object sender, EventArgs e)
        {
            HomeMethods.ChangeFontHighlight(richTextBox1, 1);
        }
        //Aqua highlight
        private void button12_Click(object sender, EventArgs e)
        {
            HomeMethods.ChangeFontHighlight(richTextBox1, 2);
        }
        //Green highlight
        private void button13_Click(object sender, EventArgs e)
        {
            HomeMethods.ChangeFontHighlight(richTextBox1, 3);
        }
        //Show font color manu
        private void button9_Click(object sender, EventArgs e)
        {
            HomeMethods.ShowFontColorMenu(groupBox3,groupBox2);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            HomeMethods.ChangeFontColor(richTextBox1, 0);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            HomeMethods.ChangeFontColor(richTextBox1, 1);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            HomeMethods.ChangeFontColor(richTextBox1, 2);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            HomeMethods.ChangeFontColor(richTextBox1, 3);
        }
    }
}
