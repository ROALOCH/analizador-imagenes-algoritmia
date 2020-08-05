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
    public partial class Details : Form
    {
        int index;
        List<Circle> cLiD, cLR;
        Bitmap bmp, highlight;

        private void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            index = comboBox.SelectedIndex;
        }

        private void ButtonOK_Click(object sender, EventArgs e)
        {
            Circle temp = cLiD.ElementAt(index);
            highlight = new Bitmap(bmp);
            temp.drawCenter(highlight, Color.Magenta);
            temp.highlightShape(highlight, Color.Cyan, Color.Black);
            pictureBoxDisplay.Image = highlight;
            labelCenterI.Text = "(" + temp.getCenter().X + ", " + temp.getCenter().Y + ")";
            labelRadiusI.Text = temp.getRadius() + " PIXELES";
        }
        public Details(Bitmap b, List<Circle> list, string pA, string pB, int d)
        {
            bmp = b;
            cLiD = list;
            cLR = new List<Circle>(list);
            bubbleSort(cLR);
            InitializeComponent();
            pictureBoxDisplay.Image = bmp;
            if (cLiD.Count > 0)
            {
                foreach (Circle c in cLiD)
                    comboBox.Items.Add("Círculo N. " + c.getID());
                foreach (Circle c in cLR)
                    listBox.Items.Add(c.showInfo());
                if(cLiD.Count > 1)
                {
                    labelPoints.Text = pA + " Y " + pB;
                    labelDistance.Text = d + " PIXELES";
                }
            }
            else
            {
                comboBox.Enabled = false;
                buttonOK.Enabled = false;
                listBox.Enabled = false;
            }  
        }
        private void bubbleSort(List<Circle> l)
        {
            Circle aux = null;
            int size = l.ToArray().Length;
            for (int i = 1; i < size; i++)
                for (int j = 0; j < (size - i); j++)
                    if (l[j] > l[j + 1])
                    {
                        aux = l[j];
                        l[j] = l[j + 1];
                        l[j + 1] = aux;
                    }
        }
    }
}
