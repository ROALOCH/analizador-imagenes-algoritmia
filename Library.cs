using System;
using System.Collections.Generic;
using System.Drawing;


namespace iP_Etapa5
{
    class Circle
    {
        Point center;
        int iD, upperY, lowestY, leftSideX, rightSideX, radiusH, radiusV, sizeX, sizeY;
        public Circle(int cx, int cy, int uy, int ly, int lsx, int rsx, int id)
        {
            iD = id;
            center.X = cx;
            center.Y = cy;
            upperY = uy;
            lowestY = ly;
            leftSideX = lsx;
            rightSideX = rsx;
            radiusH = rsx - cx;
            radiusV = ly - cy;
            sizeX = rsx - lsx;
            sizeY = ly - uy;
        }
        public int getID() => iD;
        public int getRadius()
        {
            if (radiusH > radiusV)
                return radiusH;
            return radiusV;
        }
        public Point getCenter() => center;
        public bool isWhite(Color c)
        {
            if (c.R == 255)
                if (c.G == 255)
                    if (c.B == 255)
                        return true;
            return false;
        }
        public bool isCircle() => (((radiusV - radiusH) <= 10) && ((radiusV - radiusH) >= -10));
        public bool eraseShape(Bitmap sD, Bitmap bmp)
        {
            int up, down;
            bool flag = false;

            for (int x = leftSideX - 5; x <= rightSideX + 5; x++)
            {
                up = center.Y;
                down = center.Y;

                while (!isWhite(sD.GetPixel(x, up)))
                {
                    if (isCircle())
                        sD.SetPixel(x, up, Color.Magenta);
                    else
                    {
                        flag = true;
                        sD.SetPixel(x, up, Color.Snow);
                        bmp.SetPixel(x, up, Color.Snow);
                    }
                    up++;
                }

                while (!isWhite(sD.GetPixel(x, down)))
                {
                    if (isCircle())
                        sD.SetPixel(x, down, Color.Magenta);
                    else
                    {
                        sD.SetPixel(x, down, Color.Snow);
                        bmp.SetPixel(x, down, Color.Snow);
                    }
                    down--;
                }
            }
            return flag;
        }
    }
    class Library
    {
        // COLORES //
        public bool isSnow(Color c) => c.Name == "fffffafa";
        public bool isBlack(Color c)
        {
            if (c.R == 0)
                if (c.G == 0)
                    if (c.B == 0)
                        return true;
            return false;
        }
        public bool isWhite(Color c)
        {
            if (c.R == 255)
                if (c.G == 255)
                    if (c.B == 255)
                        return true;
            return false;
        }

        // PROCESAMIENTO DE IMAGEN //

        public void processImage(Bitmap sB, Bitmap pB, Graphics pG, Graphics gG, Graph g)
        {
            if (detectCircles(sB, pB, g))
                eraseOvals(pB);
            buildGraph(pB, pG, gG, g);
        }

        // DETECCIÓN DE CIRCULOS //
        
        public void eraseOvals(Bitmap bmp)
        {
            for (int i = 0; i < bmp.Height; i++)
                for (int j = 0; j < bmp.Width; j++)
                    if (isSnow(bmp.GetPixel(j, i)))
                        bmp.SetPixel(j, i, Color.White);
        }

        public bool detectCircles(Bitmap input, Bitmap output, Graph g)
        {
            bool flag = false;
            bool anyOvals = false;
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
            return anyOvals;
        }

        // CONSTRUCCIÓN DE GRAFO //

        public void buildGraph(Bitmap bmp, Graphics graB, Graphics graG, Graph g)
        {
            setEdges(bmp, g);
            drawGraph(bmp, graB, graG, g);
        }

        private void setEdges(Bitmap bmp, Graph g)
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

        private void drawGraph(Bitmap bmp, Graphics graB, Graphics graG, Graph g)
        {
            int size = 40;

            Font f = new Font(FontFamily.GenericSerif, size / 2);
            StringFormat format = new StringFormat(StringFormatFlags.NoClip);
            format.LineAlignment = StringAlignment.Center;
            format.Alignment = StringAlignment.Center;

            foreach (Vertex v in g.getVertices())
            {
                v.drawCenter(bmp, Color.Red);
                graG.FillEllipse(Brushes.White, v.getPoint().X - (size / 2), v.getPoint().Y - (size / 2), size, size);
                foreach (Edge e in v.getEdges())
                {
                    Point point = e.getDestination().getPoint();
                    graB.DrawLine(Pens.Red, v.getPoint().X, v.getPoint().Y, point.X, point.Y);
                    graG.DrawLine(Pens.White, v.getPoint().X, v.getPoint().Y, point.X, point.Y);
                }
                graB.DrawString(v.getID().ToString(), f, Brushes.White, v.getPoint(), format);
                graG.DrawString(v.getID().ToString(), f, Brushes.Black, v.getPoint(), format);
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
