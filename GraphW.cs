using System;
using System.Drawing;
using System.Windows.Forms;

namespace iP_Etapa2{
    public partial class GraphW : Form{

        private Bitmap original;
        private Bitmap highlight;
        private Graph graph;
        private int index;
        public GraphW(Bitmap b, Graph g){
            original = b;
            graph = g;
            InitializeComponent();
            if (g.getVertexCount() > 0)
                foreach (Vertex v in graph.getVertex()){
                    listBox.Items.Add(v.getInfo());
                    comboBox.Items.Add("Vértice N. " + v.getID());
                }
            else{
                comboBox.Enabled = false;
                buttonOK.Enabled = false;
            }
            pictureBoxDisplay.Image = b;
            comboBox.SelectedIndex = 0;
        }
        private void drawEdge(Vertex vA, Vertex vB, Bitmap b, Color c, int s){
            Graphics g = Graphics.FromImage(b);
            Pen p = new Pen(c, s);
            g.DrawLine(p, vA.getData().X, vA.getData().Y, vB.getData().X, vB.getData().Y);
        }
        private void ComboBox_SelectedIndexChanged(object sender, EventArgs e){
            index = comboBox.SelectedIndex;
        }

        private void ButtonOK_Click(object sender, EventArgs e){
            listBoxConnection.Items.Clear();
            Vertex temp = graph.getVertexAt(index);
            highlight = new Bitmap(original);
            Graphics gra = Graphics.FromImage(highlight);
            Pen p = new Pen(Brushes.Magenta, 3);
            foreach (Edge edge in temp.getEdges()){
                Vertex aux = edge.getDestination();
                listBoxConnection.Items.Add(aux.getInfo());
                gra.FillEllipse(Brushes.Magenta, aux.getData().X - 10, aux.getData().Y - 10, 20, 20);
                gra.DrawLine(p, temp.getData(), aux.getData());
            }
            gra.FillEllipse(Brushes.Magenta, temp.getData().X - 20, temp.getData().Y - 20, 40, 40);
            pictureBoxDisplay.Image = highlight;
        }
    }
}
