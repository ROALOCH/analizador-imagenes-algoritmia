using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace R
{
    public partial class MainWindow : Form
    {
        Bitmap orig, bmp, sD, graphBMP, bmpP, bmpK;
        Graphics gBMP, gGRAPH;
        Graph g, graphPrim, graphKruskal;

        bool anyOvals;
        double weightPrim, weightKruskal;

        public MainWindow()
        {
            InitializeComponent();
            anyOvals = false;
            g = new Graph();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "Imagen (*.PNG; *.JPG) | *.PNG; *.JPG";

            if (DialogResult.OK == file.ShowDialog())
            {
                g.clear();
                orig = new Bitmap(file.FileName);
                sD = new Bitmap(file.FileName);
                bmp = new Bitmap(file.FileName);
                graphBMP = new Bitmap(bmp.Width, bmp.Height);
                gBMP = Graphics.FromImage(bmp);
                gGRAPH = Graphics.FromImage(graphBMP);

                pictureBoxDisplay.Image = bmp;
                buttonProcess.Enabled = true;
                buttonShowGraph.Enabled = false;
                buttonARM.Enabled = false;
                buttonCompare.Enabled = false;
                buttonSearch.Enabled = false;
                buttonSave.Enabled = false;
            }
        }

        private void buttonProcess_Click(object sender, EventArgs e)
        {
            shapeDetection();
            buildGraph();

            pictureBoxDisplay.Image = bmp;
            buttonProcess.Enabled = false;
            buttonShowGraph.Enabled = true;
            buttonARM.Enabled = true;
        }

        private void buttonShowGraph_Click(object sender, EventArgs e)
        {
            ShowGraph newWindow = new ShowGraph(g, graphBMP);
            newWindow.ShowDialog();
            newWindow.Dispose();
        }

        private void buttonARM_Click(object sender, EventArgs e)
        {
            ARMWindow newWindow = new ARMWindow(graphBMP, g);
            newWindow.ShowDialog();

            bmpP = newWindow.getPrimBMP();
            bmpK = newWindow.getKruskalBMP();
            weightPrim = newWindow.getPrimWeight();
            weightKruskal = newWindow.getKruskalWeight();
            graphPrim = newWindow.getPrimGraph();
            graphKruskal = newWindow.getKruskalGraph();

            newWindow.Dispose();
            buttonCompare.Enabled = true;
            buttonSearch.Enabled = true;
            buttonSave.Enabled = true;
        }

        private void buttonCompare_Click(object sender, EventArgs e)
        {
            CompareARM newWindow = new CompareARM(graphBMP, bmpP, bmpK, weightPrim, weightKruskal);
            newWindow.ShowDialog();
            newWindow.Dispose();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            GraphSearch newWindow = new GraphSearch(bmpP, bmpK, graphPrim, graphKruskal);
            newWindow.ShowDialog();
            newWindow.Dispose();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            Image file = orig;
            Image file2 = bmp;
            Image file3 = graphBMP;
            Image file4 = bmpP;
            Image file5 = bmpK;
            SaveFileDialog f = new SaveFileDialog();
            if (DialogResult.OK == f.ShowDialog())
            {
                file.Save(f.FileName + "_original.png");
                file2.Save(f.FileName + "_processed.png");
                file3.Save(f.FileName + "_graph.png");
                file4.Save(f.FileName + "_graphPrim.png");
                file5.Save(f.FileName + "_graphKruskal.png");
                MessageBox.Show("archivos guardados exitosamente en\n" + f.FileName, "AVISO");
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // DETECCIÓN DE FIGURAS //

        private void shapeDetection()
        {
            detectCircles(sD, bmp);
            if (anyOvals)
                eraseOvals(bmp);
        }

        private bool isSnow(Color c) => c.Name == "fffffafa";

        private bool isBlack(Color c)
        {
            if (c.R == 0)
                if (c.G == 0)
                    if (c.B == 0)
                        return true;
            return false;
        }

        private bool isWhite(Color c)
        {
            if (c.R == 255)
                if (c.G == 255)
                    if (c.B == 255)
                        return true;
            return false;
        }

        private void eraseOvals(Bitmap bmp)
        {
            for (int i = 0; i < bmp.Height; i++)
                for (int j = 0; j < bmp.Width; j++)
                    if (isSnow(bmp.GetPixel(j, i)))
                        bmp.SetPixel(j, i, Color.White);
        }

        private void detectCircles(Bitmap input, Bitmap output)
        {
            bool flag = false;
            int lx, rx, uy, ly, cx, cy, lsx, rsx;

            for (int y = 0; y < input.Height; y++)
                for (int x = 0; x < input.Width; x++)
                    if (isBlack(input.GetPixel(x, y)))
                    {
                        lx = x;
                        rx = lx;
                        uy = y;

                        while (rx < input.Width && isBlack(input.GetPixel(rx, uy)))
                            rx++;
                        rx--;
                        cx = ((rx - lx) / 2) + lx;
                        ly = uy;

                        while (ly < input.Height && isBlack(input.GetPixel(cx, ly)))
                            ly++;
                        ly--;
                        cy = ((ly - uy) / 2) + uy;
                        rsx = cx;

                        while (rsx < input.Width && isBlack(input.GetPixel(rsx, cy)))
                            rsx++;
                        rsx--;
                        lsx = cx;

                        while (lsx > 0 && isBlack(input.GetPixel(lsx, cy)))
                            lsx--;
                        lsx++;

                        Circle temp = new Circle(cx, cy, uy, ly, lsx, rsx, g.getVerticesCount() + 1);
                        if (temp.isCircle())
                            g.addVertex(temp.getCenter());
                        flag = temp.eraseShape(input, output);
                        if (flag)
                            anyOvals = true;
                    }
            sD.Dispose();
        }

        // CONSTRUCCIÓN DE GRAFO //

        private void buildGraph()
        {
            setEdges(bmp);
            drawGraph(gBMP, gGRAPH, bmp);
        }

        private void setEdges(Bitmap bmp)
        {
            foreach (Vertex vA in g.getVertices())
                foreach (Vertex vB in g.getVertices())
                    if (vA != vB)
                    {
                        List<Point> pL = DDA(bmp, vA, vB);
                        if (pL != null)
                        {
                            double deltaX = (vB.getPoint().X - vA.getPoint().X);
                            double deltaY = (vB.getPoint().Y - vA.getPoint().Y);
                            double weight = Math.Sqrt(Math.Pow(deltaX, 2) + Math.Pow(deltaY, 2));
                            vA.addEdge(vA, vB, weight, pL);
                        }
                    }
        }

        private void drawGraph(Graphics gB, Graphics gG, Bitmap bmp)
        {
            int size = 40;

            Font f = new Font(this.Font.FontFamily, size / 2);
            StringFormat format = new StringFormat(StringFormatFlags.NoClip);
            format.LineAlignment = StringAlignment.Center;
            format.Alignment = StringAlignment.Center;

            foreach (Vertex v in g.getVertices())
            {
                v.drawCenter(bmp, Color.Red);
                gG.FillEllipse(Brushes.White, v.getPoint().X - (size / 2), v.getPoint().Y - (size / 2), size, size);
                foreach (Edge e in v.getEdges())
                {
                    Point point = e.getDestination().getPoint();
                    gB.DrawLine(Pens.Red, v.getPoint().X, v.getPoint().Y, point.X, point.Y);
                    gG.DrawLine(Pens.White, v.getPoint().X, v.getPoint().Y, point.X, point.Y);
                }
                gB.DrawString(v.getID().ToString(), f, Brushes.White, v.getPoint(), format);
                gG.DrawString(v.getID().ToString(), f, Brushes.Black, v.getPoint(), format);
            }
        }

        private List<Point> DDA(Bitmap bmp, Vertex pA, Vertex pB)
        {
            List<Point> list = new List<Point>();
            int x1 = pA.getPoint().X;
            int y1 = pA.getPoint().Y;
            int x2 = pB.getPoint().X;
            int y2 = pB.getPoint().Y;

            int flag = -1;
            int dx = x2 - x1;
            int dy = y2 - y1;

            decimal xinc, yinc, tempX, tempY, step;

            if (Math.Abs(dx) > Math.Abs(dy))
                step = Math.Abs(dx);
            else
                step = Math.Abs(dy);

            tempX = x1;
            tempY = y1;
            xinc = dx / step;
            yinc = dy / step;

            for (int i = 0; i < step; i++)
            {
                if (isWhite(bmp.GetPixel(x1, y1)) && flag == 2)
                    return null;

                if (isBlack(bmp.GetPixel(x1, y1)) && flag == -1)
                    flag = -1;

                if (isWhite(bmp.GetPixel(x1, y1)))
                    flag = 1;

                if (!isWhite(bmp.GetPixel(x1, y1)) && flag != -1)
                    flag = 2;

                tempX = tempX + xinc;
                tempY = tempY + yinc;

                x1 = (int)Math.Round(tempX);
                y1 = (int)Math.Round(tempY);

                list.Add(new Point(x1, y1));
            }
            return list;
        }
    }
}
