using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iP_Etapa5
{
    public partial class DijkstraWindow : Form
    {
        Pen p;
        Graph g;
        Bitmap back, front, clean;
        Graphics graB, graF, gClean;

        eD[] vector;
        Agent agent;
        Vertex initialV;
        List<Vertex> vertexRoute;
        double maxW, prevW, tempW;
        public DijkstraWindow(Bitmap bBack, Graphics gBack, Bitmap bFront, Graphics gFront, Graph g)
        {
            this.g = g;
            this.back = bBack;
            this.graB = gBack;
            this.front = bFront;
            this.graF = gFront;
            this.clean = new Bitmap(bBack);
            this.gClean = Graphics.FromImage(clean);

            this.p = new Pen(Brushes.Orange, 6);
            this.p.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            this.p.EndCap = System.Drawing.Drawing2D.LineCap.Round;
            InitializeComponent();

            pictureBox.BackgroundImage = back;
            pictureBox.Image = front;

            agent = null;
            vertexRoute = new List<Vertex>();

            foreach(Vertex v in g.getVertices())
            {
                comboBoxInitialV.Items.Add("Vértice " + v.getID().ToString());
                comboBoxPath.Items.Add("Vértice " + v.getID().ToString());
            }

        }
        private void Dijkstra(Vertex v0)
        {
            initializeVector(v0);

            while (!solution())
            {
                Vertex vD = selectDefinitive();
                updateVector(vD);
            }
        }

        private bool solution()
        {
            foreach (eD e in vector)
                if (!e.isDefinitive())
                    return false;
            return true;
        }
        private void initializeVector(Vertex v0)
        {
            maxW = g.getGraphWeight() + 1;
            vector = new eD[g.getVerticesCount()];

            foreach (Vertex v in g.getVertices())
                vector[v.getID()] = new eD(null, maxW, false);

            vector[v0.getID()].setWeight(0);
            vector[v0.getID()].setFrom(v0);
        }

        private void buttonSetInitial_Click(object sender, EventArgs e)
        {
            initialV = g.getVertexAt(comboBoxInitialV.SelectedIndex);
            Dijkstra(initialV);
            agent = new Agent(initialV, vertexRoute);
            agent.draw(graF);
            pictureBox.Refresh();
            labelInitialV.Enabled = false;
            comboBoxInitialV.Enabled = false;
            buttonSetInitial.Enabled = false;
            labelPath.Enabled = true;
            comboBoxPath.Enabled = true;
            buttonAnimate.Enabled = true;
        }

        private void comboBoxPath_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonAnimate.Enabled = true;
            graB.Clear(Color.Transparent);
            graF.Clear(Color.Transparent);
            pictureBox.BackgroundImage = clean;
            graB.DrawImage(pictureBox.BackgroundImage, new Point(0, 0));
            pictureBox.BackgroundImage = back;
            vertexRoute = new List<Vertex>();
            if(vector[comboBoxPath.SelectedIndex].getFrom() == null)
            {
                MessageBox.Show("NO SE PUEDE LLEGAR A ESE VÉRTICE PORQUE NO HAY CAMINO QUE LO CONECTE", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                buttonAnimate.Enabled = false;
                if (agent != null)
                    agent.draw(graF);
                pictureBox.Refresh();
                return;
            }
            getPath(initialV, g.getVertexAt(comboBoxPath.SelectedIndex));
            pictureBox.Refresh();
        }

        private void buttonAnimate_Click(object sender, EventArgs e)
        {
            vertexRoute.Reverse();
            initialV = vertexRoute.Last();
            agent = new Agent(initialV, vertexRoute);

            while (!agent.reachedObjective())
            {
                graF.Clear(Color.Transparent);
                agent.draw(graF);
                agent.move();
                pictureBox.Refresh();
            }
            Dijkstra(initialV);
            graF.Clear(Color.Transparent);
        }

        private Vertex selectDefinitive()
        {
            double topW = maxW;
            int indexDef = -1;
            bool firstRead = true;

            for (int i = 0; i < vector.Length; i++)
            {
                if (!vector[i].isDefinitive())
                {
                    if (firstRead)
                    {
                        topW = vector[i].getWeight();
                        firstRead = false;
                        indexDef = i;
                    }

                    tempW = vector[i].getWeight();
                    if (tempW < topW)
                    {
                        topW = tempW;
                        indexDef = i;
                    }
                }
            }

            vector[indexDef].setDefinitive(true);
            prevW = vector[indexDef].getWeight();
            return g.getVertexAt(indexDef);
        }

        private void updateVector(Vertex vS)
        {
            foreach(Edge e in vS.getEdges())
            {
                Vertex vD = e.getDestination();
                double cumulativeW = prevW + e.getWeight();
                if (cumulativeW < vector[vD.getID()].getWeight())
                {
                    vector[vD.getID()].setWeight(cumulativeW);
                    vector[vD.getID()].setFrom(vS);
                }
            }
        }

        private void getPath(Vertex origin, Vertex destination)
        {
            vertexRoute.Add(destination);

            if (origin == destination)
                return;

            Point p1 = destination.getPoint();
            Point p2 = vector[destination.getID()].getFrom().getPoint();
            graB.DrawLine(p, p1.X, p1.Y, p2.X, p2.Y);

            if(agent != null)
                agent.draw(graF);

            getPath(origin, vector[destination.getID()].getFrom());
        }
    }
}
