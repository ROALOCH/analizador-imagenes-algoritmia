using System;
using System.Drawing;
using System.Windows.Forms;

namespace R
{
    public partial class CompareARM : Form
    {
        public CompareARM(Bitmap bmp, Bitmap prim, Bitmap kruskal, double wp, double wk)
        {
            InitializeComponent();
            pictureBoxPrim.BackgroundImage = bmp;
            pictureBoxPrim.Image = prim;
            pictureBoxKruskal.BackgroundImage = bmp;
            pictureBoxKruskal.Image = kruskal;
            labelPrim.Text = "ARM PRIM | PESO " + Math.Round(wp).ToString();
            labelKruskal.Text = "ARM KRUSKAL | PESO " + Math.Round(wk).ToString();
        }
    }
}
