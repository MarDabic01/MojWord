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
    class Metode
    {
        static private int[] niz = new int[] { 7, 9, 10, 11, 12, 15, 17, 19, 21, 23, 25, 27, 30 };

        static public void FontInit(Font[] fontovi)
        {
            fontovi[0] = new Font("Calibri", 9);
            fontovi[1] = new Font("Calibri Light", 9);
            fontovi[2] = new Font("Arial", 9);
            fontovi[3] = new Font("Tahoma", 9);
            fontovi[4] = new Font("Times New Roman", 9);
            fontovi[5] = new Font("Courier New", 9);
            fontovi[6] = new Font("Bahnschrift", 9);
            fontovi[7] = new Font("Chapbook", 9);
            fontovi[8] = new Font("SimSun", 9);
            fontovi[9] = new Font("Candara", 9);
        }
        static public void FontSizeInit(int[] fontVelicine)
        {
            for(int i=0;i<niz.Length;i++)
            {
                fontVelicine[i] = niz[i];
            }
        }
    }
}
