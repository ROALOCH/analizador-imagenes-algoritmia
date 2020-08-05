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
    public partial class Maximize : Form
    {
        public Maximize(Bitmap b)
        {
            InitializeComponent();
            pictureBoxDisplay.Image = b;
        }
    }
}
