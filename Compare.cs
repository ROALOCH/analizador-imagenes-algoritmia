using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iP_Etapa2
{
    public partial class Compare : Form
    {
        public Compare(Bitmap o, Bitmap p, Bitmap g)
        {
            InitializeComponent();
            pictureBoxOriginal.Image = o;
            pictureBoxProcessed.Image = p;
            pictureBoxGraph.Image = g;
        }
    }
}
