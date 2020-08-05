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
    public partial class mainWindow : Form
    {
        Bitmap original, bmp, graphBmp;
        bool checkOvals, anyOvals;
        string centerA, centerB;
        List<Circle> cL;
        int distance;
        Graph g;
        public mainWindow()
        {
            InitializeComponent();
            cL = new List<Circle>();
            g = new Graph();
        }
        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "Imagen (*.PNG; *.JPG) | *.PNG; *.JPG";
            if (DialogResult.OK == file.ShowDialog())
            {
                cL.Clear();
                g.getVertex().Clear();
                centerA = "---";
                centerB = "---";
                distance = 0;
                original = new Bitmap(file.FileName);
                bmp = new Bitmap(file.FileName);
                pictureBoxDisplay.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBoxDisplay.Image = original;
                buttonProcess.Enabled = true;
                buttonMaximize.Enabled = false;
                buttonCompare.Enabled = false;
                buttonDetails.Enabled = false;
                buttonGraph.Enabled = false;
                buttonSave.Enabled = false;
            }
        }
        private void ButtonProcess_Click(object sender, EventArgs e)
        {
            imageProcessing();
            buttonProcess.Enabled = false;
            buttonMaximize.Enabled = true;
            buttonCompare.Enabled = true;
            buttonDetails.Enabled = true;
            buttonGraph.Enabled = true;
            buttonSave.Enabled = true;
        }
        private void ButtonMaximize_Click(object sender, EventArgs e)
        {
            Maximize newWindow = new Maximize(bmp);
            newWindow.ShowDialog();
            newWindow.Dispose();
        }
        private void ButtonCompare_Click(object sender, EventArgs e)
        {
            Compare newWindow = new Compare(original, bmp, graphBmp);
            newWindow.ShowDialog();
            newWindow.Dispose();
        }
        private void ButtonDetails_Click(object sender, EventArgs e)
        {
            Details newWindow = new Details(bmp, cL, centerA, centerB, distance);
            newWindow.ShowDialog();
            newWindow.Dispose(); 
        }
        private void ButtonGraph_Click(object sender, EventArgs e)
        {
            GraphW newWindow = new GraphW(graphBmp, g);
            newWindow.ShowDialog();
            newWindow.Dispose();
        }
        private void ButtonSave_Click(object sender, EventArgs e)
        {
            Image file = pictureBoxDisplay.Image;
            SaveFileDialog f = new SaveFileDialog();
            f.Filter = "Imagen (*.PNG; *.JPG) | *.PNG; *.JPG";
            if (DialogResult.OK == f.ShowDialog())
            {
                file.Save(f.FileName);
                MessageBox.Show("ARCHIVO GUARDADO EXITOSAMENTE", "GUARDAR", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void ButtonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private bool isOval(Color c) => c.Name == "fffffafa";
        private bool isWhite(Color c)
        {
            if (c.R == 255)
                if (c.G == 255)
                    if (c.B == 255)
                        return true;
            return false;
        }
        private bool isBlack(Color c)
        {
            if (c.R == 0)
                if (c.G == 0)
                    if (c.B == 0)
                        return true;
            return false;
        }
        private void imageProcessing()
        {
            shapeDetection(bmp);
            if(anyOvals)
                deleteOvals(bmp);
            buildGraph();
            drawCenters(bmp);
            closestPair(bmp, Color.GreenYellow, Color.Black);
            pictureBoxDisplay.Image = bmp;
        }
        private void buildGraph()
        {
            graphBmp = new Bitmap(bmp.Width, bmp.Height);
            foreach (Circle c in cL)
                g.addVertex(c.getCenter());
            setEdges(bmp);
            drawAllEdges(bmp, graphBmp, Color.Red, 1, Color.White, 3, 20, Brushes.Cyan);
        }
        private void setEdges(Bitmap bmp)
        {
            for (int i = 0; i < cL.ToArray().Length; i++)
            {
                Circle cA = cL[i];
                for (int j = 0; j < cL.ToArray().Length; j++)
                {
                    Circle cB = cL[j];
                    if (cA != cB)
                    {
                        cA.highlightShape(bmp, Color.Black, Color.Black);
                        cB.highlightShape(bmp, Color.Black, Color.Black);
                        if (DDA(bmp, cA, cB))
                        {
                            Vertex vA = g.getVertexAt(i);
                            Vertex vB = g.getVertexAt(j);
                            vA.addEdge(vB);
                            vB.addEdge(vA);
                        }
                        cA.highlightShape(bmp, Color.Magenta, Color.Black);
                        cB.highlightShape(bmp, Color.Magenta, Color.Black);
                    }
                }
            }
        }
        private void drawCenters(Bitmap bmp)
        {
            foreach (Circle c in cL)
                c.drawCenter(bmp, Color.Black);
        }
        private void drawEdge(Vertex vA, Vertex vB, Bitmap b, Color c, int s)
        {
            Graphics g = Graphics.FromImage(b);
            Pen p = new Pen(c, s);
            g.DrawLine(p, vA.getData().X, vA.getData().Y, vB.getData().X, vB.getData().Y);
        }

        private void drawAllEdges(Bitmap a, Bitmap b, Color ca, int sa, Color cb, int sb, int pS, Brush pC)
        {
            List<Vertex> vL = g.getVertex();
            Graphics gra = Graphics.FromImage(b);
            if(vL.Count > 0)
            {
                foreach (Vertex vA in vL)
                {
                    gra.FillEllipse(pC, vA.getData().X - pS / 2, vA.getData().Y - pS / 2, pS, pS);
                    foreach (Edge e in vA.getEdges())
                    {
                        Vertex vB = e.getDestination();
                        drawEdge(vA, vB, a, ca, sa);
                        drawEdge(vA, vB, b, cb, sb);
                        gra.FillEllipse(pC, vB.getData().X - pS / 2, vB.getData().Y - pS / 2, pS, pS);
                    }
                }
            }
        }
        private void deleteOvals(Bitmap bmp)
        {
            for (int i = 0; i < bmp.Height; i++)
                for (int j = 0; j < bmp.Width; j++)
                    if (isOval(bmp.GetPixel(j, i)))
                        bmp.SetPixel(j, i, Color.White);
        }
        private void shapeDetection(Bitmap bmp)
        {
            int lx, rx, uy, ly, cx, cy, lsx, rsx;
            for(int y = 0; y < bmp.Height; y++)
                for(int x = 0; x < bmp.Width; x++)
                {
                    if(isBlack(bmp.GetPixel(x, y)))
                    {
                        lx = x;
                        rx = lx;
                        uy = y;
                        while (rx < bmp.Width && isBlack(bmp.GetPixel(rx, uy)))
                            rx++;
                        rx--;
                        cx = ((rx - lx) / 2) + lx;
                        ly = uy;
                        while (ly < bmp.Height && isBlack(bmp.GetPixel(cx, ly)))
                            ly++;
                        ly--;
                        cy = ((ly - uy) / 2) + uy;
                        rsx = cx;
                        while (rsx < bmp.Width && isBlack(bmp.GetPixel(rsx, cy)))
                            rsx++;
                        rsx--;
                        lsx = cx;
                        while (lsx > 0 && isBlack(bmp.GetPixel(lsx, cy)))
                            lsx--;
                        lsx++;
                        Circle temp = new Circle(cx, cy, uy, ly, lsx, rsx, cL.Count);
                        if (temp.isCircle())
                        {
                            cL.Add(temp);
                        }
                        checkOvals = temp.eraseShape(bmp);
                        if (checkOvals)
                            anyOvals = true;
                    }
                }
        }
        private bool DDA(Bitmap b, Circle pA, Circle pB)
        {
            int x1 = pA.getCenter().X;
            int y1 = pA.getCenter().Y;
            int x2 = pB.getCenter().X;
            int y2 = pB.getCenter().Y;

            int dx = x2 - x1;
            int dy = y2 - y1;
            decimal xinc, yinc, tempX, tempY, step;
            if (Math.Abs(dx) > Math.Abs(dy))
                step = Math.Abs(dx);
            else
                step = Math.Abs(dy);
            xinc = dx / step;
            yinc = dy / step;
            tempX = x1;
            tempY = y1;
            for(int i = 1; i <= step; i++)
            {
                if (!isWhite(b.GetPixel(x1, y1)) && !isBlack(b.GetPixel(x1, y1)))
                    return false;
                tempX = tempX + xinc;
                tempY = tempY + yinc;
                x1 = (int)Math.Round(tempX);
                y1 = (int)Math.Round(tempY);
            }
            return true;
        }
        private double distanceBetweenCenters(int x1, int y1, int x2, int y2)
        {
            double deltaX = (x2 - x1);
            double deltaY = (y2 - y1);
            return Math.Sqrt(((Math.Pow(deltaX, 2)) + (Math.Pow(deltaY, 2))));
        }
        private void closestPair(Bitmap bmp, Color cir, Color ctr)
        {
            if (cL.Count > 1)
            {
                Circle pointA = null, pointB = null;
                double minDistance = -1;
                double temp;
                foreach (Circle a in cL)
                    foreach (Circle b in cL)
                        if (a != b)
                        {
                            temp = distanceBetweenCenters(a.getCenter().X, a.getCenter().Y, b.getCenter().X, b.getCenter().Y);
                            if (minDistance == -1)
                                minDistance = temp;
                            if (temp <= minDistance)
                            {
                                minDistance = temp;
                                pointA = a;
                                pointB = b;
                            }
                        }
                centerA = pointA.getID().ToString();
                centerB = pointB.getID().ToString();
                distance = (int)Math.Round(minDistance);
                pointA.highlightShape(bmp, cir, ctr);
                pointB.highlightShape(bmp, cir, ctr);
            }
        }
    }
}
