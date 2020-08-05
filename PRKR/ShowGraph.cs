using System;
using System.Drawing;
using System.Windows.Forms;

namespace R
{
    public partial class ShowGraph : Form
    {
        Graph g;
        Bitmap bmp;
        Graphics gra;
        public ShowGraph(Graph graph, Bitmap b)
        {
            g = graph;
            bmp = new Bitmap(b.Width, b.Height);
            gra = Graphics.FromImage(bmp);

            InitializeComponent();
            foreach (Vertex v in g.getVertices())
                comboBox.Items.Add("Vértice N. " + v.getID().ToString());

            pictureBoxDisplay.BackgroundImage = b;
            pictureBoxDisplay.Image = bmp;
        }

        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int sizeO = 80;
            int size = 44;

            Font f = new Font(this.Font.FontFamily, size / 2);
            StringFormat format = new StringFormat(StringFormatFlags.NoClip);
            format.LineAlignment = StringAlignment.Center;
            format.Alignment = StringAlignment.Center;
            Pen p = new Pen(Brushes.Orange, 3);

            int index = comboBox.SelectedIndex;
            Vertex vO = g.getVertexAt(index);
            Point pA = vO.getPoint();

            listBox.Items.Clear();
            gra.Clear(Color.Transparent);
            gra.FillEllipse(Brushes.Orange, pA.X - (sizeO / 2), pA.Y - (sizeO / 2), sizeO, sizeO);

            foreach (Edge edge in vO.getEdges())
            {
                Vertex vD = edge.getDestination();
                Point pB = edge.getDestination().getPoint();

                gra.DrawLine(p, pA, pB);
                gra.FillEllipse(Brushes.Orange, pB.X - (size / 2), pB.Y - (size / 2), size, size);
                gra.DrawString(vD.getID().ToString(), f, Brushes.White, vD.getPoint(), format);

                listBox.Items.Add("Vértice N." + vD.getID().ToString() + ", Peso: " + Math.Round(edge.getWeight()).ToString());
            }
            gra.DrawString(vO.getID().ToString(), f, Brushes.White, vO.getPoint(), format);

            pictureBoxDisplay.Image = bmp;
        }
    }
}
