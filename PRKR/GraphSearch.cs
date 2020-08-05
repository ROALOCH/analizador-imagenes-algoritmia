using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace R
{
    public partial class GraphSearch : Form
    {
        Graph gP, gK;
        Bitmap bP, bK, bmp;
        Graphics gra;
        Agent agent;

        Stack<Vertex> stack = new Stack<Vertex>();

        Vertex vO, vD;
        bool prim, flag;
        List<Vertex> selectedPath;

        public GraphSearch(Bitmap bmpP, Bitmap bmpK, Graph graphP, Graph graphK)
        {

            gP = new Graph(graphP);
            gK = new Graph(graphK);
            bP = new Bitmap(bmpP);
            bK = new Bitmap(bmpK);
            bmp = new Bitmap(bmpP.Width, bmpP.Height);
            gra = Graphics.FromImage(bmp);

            vO = null;
            vD = null;
            selectedPath = new List<Vertex>();

            InitializeComponent();

            pictureBox.Image = bP;

        }
        private void radioButtonP_CheckedChanged(object sender, System.EventArgs e)
        {
            if (radioButtonP.Checked)
                pictureBox.Image = bP;
            else
                pictureBox.Image = bK;
        }
        private void buttonSelectGraph_Click(object sender, System.EventArgs e)
        {
            if (radioButtonP.Checked)
            {
                prim = true;
                foreach (Vertex v in gP.getVertices())
                {
                    comboBoxObjective.Items.Add("Vértice " + v.getID().ToString());
                    comboBoxDFS.Items.Add("Vértice " + v.getID().ToString());
                }
            }
            else
            {
                prim = false;
                foreach (Vertex v in gK.getVertices())
                {
                    comboBoxObjective.Items.Add("Vértice " + v.getID().ToString());
                    comboBoxDFS.Items.Add("Vértice " + v.getID().ToString());
                }
            }

            radioButtonP.Enabled = false;
            radioButtonK.Enabled = false;
            buttonSelectGraph.Enabled = false;

            labelObjective.Enabled = true;
            comboBoxObjective.Enabled = true;

            comboBoxDFS.Enabled = true;
            labelDFS.Enabled = true;

            buttonStart.Enabled = true;
        }
        private void buttonStart_Click(object sender, System.EventArgs e)
        {
            bool link = false;

            if (prim)
            {
                vD = gP.getVertexAt(comboBoxObjective.SelectedIndex);
                vO = gP.getVertexAt(comboBoxDFS.SelectedIndex);

                if(vO != null && vD != null)
                {
                    link = DFS(vO, vD);
                    agent = new Agent(vO, 0, selectedPath);
                }
            }
            else
            {
                vD = gK.getVertexAt(comboBoxObjective.SelectedIndex);
                vO = gK.getVertexAt(comboBoxDFS.SelectedIndex);

                if (vO != null && vD != null)
                {
                    link = DFS(vO, vD);
                    agent = new Agent(vO, 0, selectedPath);
                }
            }
            

            labelObjective.Enabled = false;
            comboBoxObjective.Enabled = false;

            comboBoxDFS.Enabled = false;
            labelDFS.Enabled = false;

            buttonStart.Enabled = false;

            drawSimulation(vO, vD);

        }

        // BUSQUEDA EN PROFUNDIDAD (DFS)
        private bool DFS(Vertex v_act, Vertex v_obj)
        {

            selectedPath.Add(v_act);

            if (v_act == v_obj)
                return true;

            flag = false;

            foreach (Edge e in v_act.getEdges())
            {
                if (!selectedPath.Contains(e.getDestination()))
                {
                    stack.Push(v_act);
                    flag = DFS(e.getDestination(), v_obj);
                }

                if (flag)
                    return true;
            }

            if(stack.Count != 0)
            {
                selectedPath.Add(stack.Peek());
                stack.Pop();
            }

            return flag;
        }

        // ANIMACION //

        private void drawSimulation(Vertex origin, Vertex destination)
        {

            if (prim)
                pictureBox.BackgroundImage = bP;
            else
                pictureBox.BackgroundImage = bK;

            pictureBox.Image = bmp;

            int size = 44;
            bool flag = true;
            Pen p = new Pen(Color.White, 5);
            Point dest = destination.getPoint();

            while(agent.getActualVertex() != destination && flag == true)
            {
                gra.Clear(Color.Transparent);
                gra.DrawEllipse(p, dest.X - (size / 2), dest.Y - (size / 2), size, size);
                agent.draw(gra);
                flag = agent.move();
                pictureBox.Refresh();
            }
            gra.Clear(Color.Transparent);
            gra.FillEllipse(Brushes.YellowGreen, dest.X - (size / 2), dest.Y - (size / 2), size, size);
            agent.draw(gra);
            pictureBox.Refresh();
        }
    }
}
