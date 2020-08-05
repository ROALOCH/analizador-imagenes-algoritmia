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
    public partial class resultsWindow : Form
    {
        List<Circle> list;
        Circle temp;
        Bitmap original, highlight;
        int nShape, nCircle, nOval, index;

        private void ButtonHideList_Click(object sender, EventArgs e)
        {
            listBoxGrid.Visible = false;
            buttonHideList.Visible = false;
            buttonShowGrid.Visible = true;
        }

        private void ButtonShowGrid_Click(object sender, EventArgs e)
        {
            listBoxGrid.Visible = true;
            listBoxGrid.Items.Clear();
            

            foreach(Circle sh in list)
            {
                if (sh.isCircle())
                {
                    listBoxGrid.Items.Add(sh.showInfo());
                }
            }
            buttonShowGrid.Visible = false;
            buttonHideList.Enabled = true;
            buttonHideList.Visible = true;
        }

        private void ButtonShow_Click(object sender, EventArgs e)
        {
            temp = list.ElementAt(index);
            highlight = new Bitmap(original);
            temp.highlightShape(highlight);
            pictureBoxResult.Image = highlight;
            labelCenterC.Text = "(" + temp.getCenterC() + ")";
            labelRadiusC.Text =  temp.getRadius() + " PIXELES";
        }

        private void ComboBoxList_SelectedIndexChanged(object sender, EventArgs e)
        {
            index = comboBoxList.SelectedIndex;
        }

        public resultsWindow(Bitmap b, List<Circle> l, int s, int c, int o)
        {
            list = l;
            nShape = s;
            nCircle = c;
            nOval = o;
            original = b;
            InitializeComponent();
            pictureBoxResult.Image = original;
            labelInfoShapes.Text = nShape.ToString();
            labelInfoCircle.Text = nCircle.ToString();
            labelInfoOvals.Text = nOval.ToString();
            foreach(Circle sh in list)
            {
                if (sh.isCircle())
                {
                    comboBoxList.Items.Add("Circulo N." + sh.getID());
                    comboBoxList.Enabled = true;
                    buttonShow.Enabled = true;
                    listBoxGrid.Enabled = true;
                    buttonShowGrid.Enabled = true;
                }
            }
        }
    }
}
