using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace R
{
    public partial class ARMWindow : Form
    {
        Bitmap bmpP, bmpK, bmpB, bmp;
        Graphics graP, graK, graB;
        Graph oG, pG, kG;

        // Prim & Kruskal //
        List<List<Vertex>> relatedComp;
        List<Vertex> selection;
        List<Edge> candidates;
        List<Edge> promising;

        int brmPrim, brmKruskal;
        double weightP, weightK;



        public ARMWindow(Bitmap b, Graph g)
        {
            bmpP = new Bitmap(b.Width, b.Height);
            bmpK = new Bitmap(b.Width, b.Height);
            graP = Graphics.FromImage(bmpP);
            graK = Graphics.FromImage(bmpK);
            bmp = b;

            selection = new List<Vertex>();
            promising = new List<Edge>();

            pG = new Graph();
            kG = new Graph();
            oG = g;

            InitializeComponent();

            foreach (Vertex v in oG.getVertices())
                comboBox.Items.Add("Vértice N. " + v.getID().ToString());

            pictureBox.Image = bmpP;
            pictureBox.BackgroundImage = b;
            comboBox.SelectedIndex = 0;
        }

        public Bitmap getPrimBMP() => bmpP;

        public Bitmap getKruskalBMP() => bmpK;

        public double getPrimWeight() => weightP;

        public double getKruskalWeight() => weightK;
        public Graph getPrimGraph() => pG;
        public Graph getKruskalGraph() => kG;

        private void buttonOK_Click(object sender, EventArgs e)
        {
            Vertex vP = oG.getVertexAt(comboBox.SelectedIndex);
            pictureBox.Image = bmpP;
            primAlgorithm(vP);
            pictureBox.Refresh();

            bmpB = new Bitmap(bmpP);
            graB = Graphics.FromImage(bmpB);
            pictureBox.Image = bmpB;

            selection.Clear();
            candidates.Clear();
            promising.Clear();

            kruskalAlgorithm();
            pictureBox.Refresh();

            comboBox.Enabled = false;
            buttonOK.Enabled = false;
            buttonCompare.Enabled = true;
        }

        private void buttonCompare_Click(object sender, EventArgs e)
        {
            CompareARM newWindow = new CompareARM(bmp, bmpP, bmpK, weightP, weightK);
            newWindow.ShowDialog();
            newWindow.Dispose();
        }

        // ALGORIMO PRIM //
        private void primAlgorithm(Vertex v)
        {
            selection.Add(v);
            candidates = new List<Edge>(v.getEdges());
            while (!solution(selection))
            {
                Edge a = selectCandidate(candidates);

                if (a == null) // GRAFO NO CONEXO, FORZAR BOSQUE DE RECUBRIMIENTO MINIMO
                {
                    brmPrim++;
                    primAlgorithm(outsideVertex());
                    return;
                }

                if (factible(a, selection))
                {
                    promising.Add(a);
                    weightP = weightP + a.getWeight();
                    Vertex vO = a.getOrigin();
                    Vertex vD = a.getDestination();
                    drawPrim(vO, vD);
                    selection.Add(a.getDestination());
                    foreach (Edge edge in a.getDestination().getEdges())
                        candidates.Add(new Edge(edge));
                }
            }
            listBoxPrim.Items.Add("PESO ARM: " + Math.Round(weightP).ToString());
            listBoxPrim.Items.Add("SUB-ARBOLES: " + brmPrim.ToString());
            buildGraph(pG);
        }
        private bool solution(List<Vertex> sel) => sel.Count == oG.getVerticesCount();
        private Vertex outsideVertex()
        {
            List<Vertex> nl = oG.getVertices().Except(selection).ToList();
            return nl.ElementAt(0);
        }
        private Edge selectCandidate(List<Edge> c)
        {
            bool firstRead = true;
            double temp = 0, min = 0;
            Edge selectedEdge = null;

            foreach (Edge e in c)
            {
                temp = e.getWeight();

                if (firstRead)
                {
                    firstRead = false;
                    selectedEdge = e;
                    min = temp;
                }

                if (temp < min)
                {
                    min = temp;
                    selectedEdge = e;
                }
            }

            c.Remove(selectedEdge);
            return selectedEdge;
        }
        private bool factible(Edge e, List<Vertex> s)
        {
            Vertex d = e.getDestination();
            foreach (Vertex v in s)
                if (v == d)
                    return false;
            return true;
        }
        private void drawPrim(Vertex vO, Vertex vD)
        {
            int size = 44;
            Point o = vO.getPoint();
            Point d = vD.getPoint();
            Pen p = new Pen(Brushes.Magenta, 5);
            Font f = new Font(this.Font.FontFamily, size / 2);
            StringFormat format = new StringFormat(StringFormatFlags.NoClip);
            format.LineAlignment = StringAlignment.Center;
            format.Alignment = StringAlignment.Center;

            graP.DrawLine(p, o.X, o.Y, d.X, d.Y);
            graP.FillEllipse(Brushes.Magenta, o.X - (size / 2), o.Y - (size / 2), size, size);
            graP.FillEllipse(Brushes.Magenta, d.X - (size / 2), d.Y - (size / 2), size, size);
            graP.DrawString(vO.getID().ToString(), f, Brushes.White, vO.getPoint(), format);
            graP.DrawString(vD.getID().ToString(), f, Brushes.White, vD.getPoint(), format);

            listBoxPrim.Items.Add("Arista de " + vO.getID().ToString() + " a " + vD.getID().ToString());
            pictureBox.Refresh();

            p.Dispose();
            f.Dispose();
            format.Dispose();
        }

        // ALGORITMO KRUSKAL //
        private void kruskalAlgorithm()
        {
            candidates = new List<Edge>(oG.getDirectionalEdges());
            relatedComp = initializeRC();
            while (!solutionK())
            {
                Edge a = selectCandidateK(candidates);
                List<Vertex> rC_1 = getRC(a.getOrigin());
                List<Vertex> rC_2 = getRC(a.getDestination());
                if (rC_1 != rC_2)
                {
                    Vertex vO = a.getOrigin();
                    Vertex vD = a.getDestination();
                    promising.Add(a);
                    selection.Add(vO);
                    selection.Add(vD);
                    weightK = weightK + a.getWeight();
                    drawKruskal(vO, vD);
                    mergeRC(rC_1, rC_2);
                }
            }
            brmKruskal = relatedComp.Count - 1;
            listBoxKruskal.Items.Add("PESO ARM: " + Math.Round(weightK).ToString());
            listBoxKruskal.Items.Add("SUB-ARBOLES: " + brmKruskal.ToString());
            buildGraph(kG);
        }
        private bool solutionK() => candidates.Count == 0;
        private List<List<Vertex>> initializeRC()
        {
            List<Vertex> vl = null;
            List<List<Vertex>> cc = new List<List<Vertex>>();
            foreach (Vertex v in oG.getVertices())
            {
                vl = new List<Vertex>();
                vl.Add(v);
                cc.Add(vl);
            }
            return cc;
        }
        private Edge selectCandidateK(List<Edge> c)
        {
            Edge e = c.ElementAt(0);
            c.Remove(e);
            return e;
        }
        private List<Vertex> getRC(Vertex v)
        {
            foreach (List<Vertex> vl in relatedComp)
                if (vl.Contains(v))
                    return vl;
            return null;
        }
        private void mergeRC(List<Vertex> rc1, List<Vertex> rc2)
        {
            rc1.AddRange(rc2);
            relatedComp.Remove(rc2);
        }
        private void drawKruskal(Vertex vO, Vertex vD)
        {
            int size = 44;
            Point o = vO.getPoint();
            Point d = vD.getPoint();
            Pen p = new Pen(Brushes.Orange, 5);
            Font f = new Font(this.Font.FontFamily, size / 2);
            StringFormat format = new StringFormat(StringFormatFlags.NoClip);
            format.LineAlignment = StringAlignment.Center;
            format.Alignment = StringAlignment.Center;

            graB.DrawLine(p, o.X, o.Y, d.X, d.Y);
            graB.FillEllipse(Brushes.Orange, o.X - (size / 2), o.Y - (size / 2), size, size);
            graB.FillEllipse(Brushes.Orange, d.X - (size / 2), d.Y - (size / 2), size, size);
            graB.DrawString(vO.getID().ToString(), f, Brushes.White, vO.getPoint(), format);
            graB.DrawString(vD.getID().ToString(), f, Brushes.White, vD.getPoint(), format);

            graK.DrawLine(p, o.X, o.Y, d.X, d.Y);
            graK.FillEllipse(Brushes.Orange, o.X - (size / 2), o.Y - (size / 2), size, size);
            graK.FillEllipse(Brushes.Orange, d.X - (size / 2), d.Y - (size / 2), size, size);
            graK.DrawString(vO.getID().ToString(), f, Brushes.White, vO.getPoint(), format);
            graK.DrawString(vD.getID().ToString(), f, Brushes.White, vD.getPoint(), format);

            listBoxKruskal.Items.Add("Arista de " + vO.getID().ToString() + " a " + vD.getID().ToString());
            pictureBox.Refresh();

            p.Dispose();
            f.Dispose();
            format.Dispose();
        }

        private void buildGraph(Graph g)
        {
            foreach (Vertex v in oG.getVertices())
                g.addVertex(v.getPoint());

            foreach (Edge e in promising)
            {
                Vertex vO = e.getOrigin();
                Vertex vD = e.getDestination();
                double w = e.getWeight();
                List<Point> lp = e.getPoints();

                vO = g.findVertex(vO);
                vD = g.findVertex(vD);
                vO.addEdge(vO, vD, w, lp);
                List<Point> lpReversed = new List<Point>(lp);
                lpReversed.Reverse();
                vD.addEdge(vD, vO, w, lpReversed);
            }
        }
    }
}
