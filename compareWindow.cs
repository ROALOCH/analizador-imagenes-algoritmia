using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iP
{
    public partial class compareWindow : Form
    {
        public compareWindow(Bitmap o, Bitmap p)
        {
            InitializeComponent();
            pictureBoxOriginal.Image = o;
            pictureBoxDone.Image = p;
        }
    }
}
