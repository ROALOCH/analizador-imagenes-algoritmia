using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HUNT
{
    // CLASE CÍRCULO NECESARIA PARA DETECTAR FORMAS EN LA IMAGEN //
    public class Circle
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



    // LIBRERÍA DE FUNCIONES GENERALES UTILIZADAS EN EL PROGRAMA //
    public class Functions
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

            Font f = new Font(FontFamily.GenericSansSerif, size / 2);
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

    // CLASE GRAFO //
    public class Graph
    {
        private List<Vertex> vL;
        private List<Pray> prays;
        private List<Predator> predators;

        private eD[] vector;
        private double maxW, tempW, prevW;
        private List<Vertex> vertexRoute;

        public Graph()
        {
            vL = new List<Vertex>();
            prays = new List<Pray>();
            predators = new List<Predator>();
        }
        public Graph(Graph g)
        {
            this.vL = g.vL;
            this.prays = g.prays;
            this.predators = g.predators;
            this.vertexRoute = g.vertexRoute;
        }
        public List<Vertex> getVertices() => vL;
        public int getVerticesCount() => vL.Count;
        public Vertex getVertexAt(int i) => vL.ElementAt(i);
        public void addVertex(Point p) => vL.Add(new Vertex(p, vL.Count));
        public void clearPP()
        {
            prays.Clear();
            predators.Clear();
        }
        public Vertex findVertex(Vertex v)
        {
            foreach (Vertex vr in vL)
                if (vr.getPoint() == v.getPoint())
                    return vr;
            return null;
        }
        public List<Edge> getEdges()
        {
            List<Edge> eL = new List<Edge>();

            foreach (Vertex v in getVertices())
                foreach (Edge e in v.getEdges())
                    eL.Add(e);

            return eL;
        }
        public double getGraphWeight()
        {
            double w = 0;
            List<Vertex> temp = new List<Vertex>();
            foreach (Vertex o in vL)
            {
                temp.Add(o);
                foreach (Edge e in o.getEdges())
                {
                    Vertex d = e.getDestination();
                    if (!temp.Contains(d))
                    {
                        w = w + e.getWeight();
                    }
                }
            }
            return w;
        }

        // PRESA //
        public void addPray(Pray p) => prays.Add(p);
        public List<Pray> getPrays() => prays;
        public int getPraysCount() => prays.Count;
        public void drawPrays(bool route, bool health, Graphics g)
        {
            foreach (Pray p in prays)
                p.draw(route, health, g);
        }
        public bool drawNMovePrays(bool route, bool health, Graphics g)
        {
            List<Pray> deadPrays = new List<Pray>();
            bool flag = false;
            foreach (Pray p in prays)
            {
                if(p.getHealth() > 0)
                {
                    p.draw(route, health, g);
                    if (p.move())
                        flag = true;
                }
                else
                {
                    deadPrays.Add(p);
                }
            }

            foreach (Pray pr in deadPrays)
                prays.Remove(pr);

            return flag;
        }

        // DEPREDADOR //
        public void addPredator(Predator p) => predators.Add(p);
        public List<Predator> getPredators() => predators;
        public int getPredatorsCount() => predators.Count;
        public void drawPredators(bool radar, bool relation, Graphics g)
        {
            foreach (Predator p in predators)
                p.draw(radar, relation, g);
        }
        public void drawNMovePredators(bool radar, bool relation, Graphics g)
        {
            foreach (Predator p in predators)
            {
                p.draw(radar, relation, g);
                p.move();
            }
        }

        // ALGORITMO DIJKSTRA //
        public List<Vertex> Dijkstra(Vertex vA, Vertex vO)
        {
            initializeVector(vA);

            while (!solution())
            {
                Vertex vD = selectDefinitive();
                updateVector(vD);
            }

            vertexRoute = new List<Vertex>();
            
            if(vector[vO.getID()].getFrom() != null)
            {
                getPath(vA, vO);
                vertexRoute.Reverse();
            }

            return vertexRoute;
        }
        private void initializeVector(Vertex v0)
        {
            maxW = getGraphWeight() + 1;
            vector = new eD[vL.Count];

            foreach (Vertex v in vL)
                vector[v.getID()] = new eD(null, maxW, false);

            vector[v0.getID()].setWeight(0);
            vector[v0.getID()].setFrom(v0);
        }
        private bool solution()
        {
            foreach (eD e in vector)
                if (!e.isDefinitive())
                    return false;
            return true;
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
            return vL[indexDef];
        }
        private void updateVector(Vertex vS)
        {
            foreach (Edge e in vS.getEdges())
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

            getPath(origin, vector[destination.getID()].getFrom());
        }
    }

    // CLASE VÉRTICE //
    public class Vertex
    {
        List<Edge> eL;
        int safeZoneTimer;
        bool safeZone;
        bool occupied;
        Point point;
        int iD;
        public Vertex(Point p, int i)
        {
            eL = new List<Edge>();
            point = new Point(p.X, p.Y);
            iD = i;
            safeZone = true;
            occupied = false;
            safeZoneTimer = 100;
        }
        public bool isSafeZone() => safeZone;
        public void isOccupied(bool b) => occupied = b;
        public void updateTimer()
        {
            if (occupied)
            {
                safeZoneTimer = safeZoneTimer - 10;
                if (safeZoneTimer < 0)
                    safeZone = false;
            }
            else
            {
                safeZone = true;
                safeZoneTimer = 100;
            }
        }
        public List<Edge> getEdges() => eL;
        public Point getPoint() => point;
        public int getID() => iD;
        public void addEdge(Vertex o, Vertex d, double w, List<Point> l) => eL.Add(new Edge(o, d, w, l));
        public void drawCenter(Bitmap bmp, Color c)
        {
            for (int i = -3; i <= 3; i++)
            {
                bmp.SetPixel(point.X - i, point.Y, c);
                bmp.SetPixel(point.X, point.Y - i, c);
            }
        }
        public override string ToString()
        {
            return "Vértice " + iD;
        }
    }

    // CLASE ARISTA //
    public class Edge
    {
        Vertex origin;
        Vertex destination;
        List<Point> pL;
        double weight;

        public Edge(Edge e)
        {
            this.origin = e.origin;
            this.destination = e.destination;
            this.pL = e.pL;
            this.weight = e.weight;
        }
        public Edge(Vertex o, Vertex d, double w, List<Point> l)
        {
            pL = new List<Point>(l);
            origin = o;
            destination = d;
            weight = w;
        }
        public Vertex getOrigin() => origin;
        public Vertex getDestination() => destination;
        public List<Point> getPoints() => pL;
        public Point getPointAt(int i) => pL.ElementAt(i);
        public int getLastIndex() => pL.Count - 1;
        public double getWeight() => weight;
    }


    // CLASE ELEMENTO DIJKSTRA //
    public class eD
    {
        private Vertex fromV;
        private double weight;
        private bool definitive;

        public eD(Vertex from, double w, bool d)
        {
            fromV = from;
            weight = w;
            definitive = d;
        }

        public Vertex getFrom() => fromV;
        public double getWeight() => weight;
        public bool isDefinitive() => definitive;
        public void setFrom(Vertex f) => fromV = f;
        public void setWeight(double w) => weight = w;
        public void setDefinitive(bool d) => definitive = d;
    }

    // CLASE PRESA //

    public class Pray
    {
        private int iD, velocity, index, health;
        private Point position;
        private Vertex vO, vA;
        private Edge edge;
        private List<Point> pLRoute;
        private List<Vertex> vertexRoute;
        private List<Edge> edgeRoute;
        private Predator predator;
        private Graph g;
        private bool existPath;

        private Pen pen;
        private Font font;
        private StringFormat format;
        private Random random;

        public Pray(int iD, Vertex vA, Vertex vO, Graph g)
        {
            this.iD = iD;
            this.velocity = 5;
            this.index = 0;
            this.health = 100;
            this.position = vA.getPoint();
            this.vO = vO;
            this.vA = vA;
            this.edge = null;
            this.existPath = true;
            this.vertexRoute = new List<Vertex>();
            this.pLRoute = new List<Point>();
            this.edgeRoute = new List<Edge>();
            this.predator = null;
            this.g = g;
            this.random = new Random();

            pen = new Pen(Brushes.Gold, 3);
            font = new Font(FontFamily.GenericSansSerif, 20);
            format = new StringFormat(StringFormatFlags.NoClip);
            format.LineAlignment = StringAlignment.Center;
            format.Alignment = StringAlignment.Center;

            vertexRoute = g.Dijkstra(vA, vO);

            if (vertexRoute.Count > 0)
                getPointList();
            else
                existPath = false;
            
        }
        public void updateObjective(Vertex vO)
        {
            this.vO = vO;

            if (index == 0)
            {
                pLRoute.Clear();
                edgeRoute.Clear();
                vertexRoute = g.Dijkstra(vA, vO);

                if (vertexRoute.Count > 0)
                {
                    getPointList();
                    existPath = true;
                }
                else
                    existPath = false;

                vA.isOccupied(true);
                vA.updateTimer();
            }
            else
            {
                edgeRoute.Clear();
                vertexRoute = g.Dijkstra(edge.getDestination(), vO);
                int difference = edge.getPoints().Count - index;

                if(difference < pLRoute.Count)
                    pLRoute.RemoveRange(difference, pLRoute.Count - difference);

                if (vertexRoute.Count > 0)
                {
                    getPointList();
                    existPath = true;
                }
                else
                    existPath = false;
            }
        }
        private void getPointList()
        {
            Vertex vA, vB;

            while (vertexRoute.Count != 0)
            {
                vA = vertexRoute.ElementAt(0);
                vertexRoute.RemoveAt(0);

                if (vertexRoute.Count == 0)
                    break;

                vB = vertexRoute.ElementAt(0);

                if (vertexRoute.Count == 0)
                    break;

                foreach (Edge e in vA.getEdges())
                    if (e.getDestination() == vB)
                    {
                        edgeRoute.Add(e);
                        foreach (Point p in e.getPoints())
                            pLRoute.Add(p);
                    }
            }
        }
        public Point getPosition() => position;
        public Edge getEdge() => edge;
        public void setPredator(Predator p) => predator = p;
        public void gainsHealth() => health += 10;
        public void losesHealth() => health -= 10;
        public int getHealth() => health;
        public bool isHunted() => predator != null;
        public void draw(bool showRoute, bool showHealth, Graphics g)
        {
            int size = 36;
            if (showRoute)
                if(pLRoute.Count > 2)
                    g.DrawLines(pen, pLRoute.ToArray());

            if (isHunted())
                g.FillEllipse(Brushes.Red, position.X - size / 2, position.Y - size / 2, size, size);
            else
            {
                g.FillEllipse(Brushes.DarkRed, position.X - size / 2, position.Y - size / 2, size, size);
            }

            if (showHealth)
                g.DrawString(health.ToString(), font, Brushes.White, position, format);
        }
        public bool move()
        {
            predator = null;

            if (!isHunted())
            {
                if ((vA != vO) && existPath)
                {
                    if (pLRoute.Count < velocity)
                        pLRoute.Clear();

                    else
                        pLRoute.RemoveRange(0, velocity);

                    if (index == 0)
                    {
                        vA.isOccupied(true);
                        vA.updateTimer();
                        if (edgeRoute.Count != 0)
                        {
                            edge = edgeRoute.First();
                            edgeRoute.RemoveAt(0);
                        }
                    }

                    vA.isOccupied(false);
                    vA.updateTimer();

                    if ((index + velocity) < edge.getPoints().Count)
                    {
                        index = index + velocity;
                        position = edge.getPointAt(index);
                    }
                    else
                    {
                        vA = edge.getDestination();
                        position = vA.getPoint();
                        index = 0;
                    }
                }
            }

            else
            {
                if ((vA != vO) && existPath)
                {
                    if (pLRoute.Count < velocity)
                        pLRoute.Clear();

                    else
                        pLRoute.RemoveRange(0, velocity);

                    if (index == 0)
                    {
                        vA.isOccupied(true);
                        vA.updateTimer();

                        Point pred = predator.getPoint();

                        if(pred != position)
                        {
                            if (edgeRoute.Count != 0)
                            {
                                edge = edgeRoute.First();
                                edgeRoute.RemoveAt(0);
                            }
                        }
                        else
                        {
                            pLRoute.Clear();
                            edgeRoute.Clear();
                            Edge edg = predator.getEdge();

                            foreach(Edge ed in vA.getEdges())
                            {
                                if(ed != edg)
                                {
                                    edge = ed;
                                    pLRoute.AddRange(ed.getPoints());
                                }
                            }
                        }
                    }

                    vA.isOccupied(false);
                    vA.updateTimer();

                    if(edge != null)
                    {
                        if ((index + velocity) < edge.getPoints().Count)
                        {
                            index = index + velocity;
                            position = edge.getPointAt(index);
                        }
                        else
                        {
                            vA = edge.getDestination();
                            position = vA.getPoint();
                            index = 0;
                        }
                    }
                }
            }

            if(vA == vO)
            {
                gainsHealth();
                return true;
            }

            return false;
        }
    }

    // CLASE DEPREDADOR //

    public class Predator
    {
        private int iD, velocity, index, size, sizeR, radius;
        private Point position, objective;
        private Vertex vA;
        private Edge edge;
        private List<Point> pointList;
        private List<Pray> prays;
        private Pray pray;

        private Color color;
        private SolidBrush brush;
        private Pen pen;

        private Random random;

        public Predator(int iD, int radarSize, Vertex vA, List<Pray> prays)
        {
            this.iD = iD;
            this.velocity = 6;
            this.index = 0;
            this.size = 36;
            this.radius = radarSize / 2;
            this.sizeR = radius * 2;
            this.position = vA.getPoint();
            this.objective = new Point();
            this.vA = vA;
            this.edge = null;
            this.pointList = new List<Point>();
            this.prays = prays;
            this.pray = null;
            this.color = Color.FromArgb(50, 124, 252, 0);
            this.brush = new SolidBrush(color);
            this.pen = new Pen(Color.LawnGreen, 5);
            this.random = new Random();
        }
        public Point getPoint() => position;
        public Edge getEdge() => edge;
        public void draw(bool showRadar, bool showRelation, Graphics g)
        {
            if (showRadar)
                g.FillEllipse(brush, position.X - radius, position.Y - radius, sizeR, sizeR);

            if (showRelation && isHunting())
                g.DrawLine(pen, position, objective);

            g.FillEllipse(Brushes.LawnGreen, position.X - size / 2, position.Y - size / 2, size, size);
        }
        private bool isHunting() => pray != null;
        private void checkForPraysInRadar()
        {
            pray = null;
            velocity = 8;
            double deltaX, deltaY, distance, percentage;

            foreach(Pray p in prays)
            {
                deltaX = (p.getPosition().X - position.X);
                deltaY = (p.getPosition().Y - position.Y);
                distance = Math.Sqrt(((Math.Pow(deltaX, 2)) + (Math.Pow(deltaY, 2))));
                if ((distance < radius) && (!p.isHunted()) && (!isHunting()))
                {
                    pray = p;
                    pray.setPredator(this);

                    if (distance < size / 2)
                        pray.losesHealth();

                    percentage = ((distance * 100) / radius);
                    percentage = Math.Abs(percentage - radius);
                    velocity = velocity + ((int)((percentage * velocity) / 100));
                    objective = pray.getPosition();
                }
            }
        }
        public void move()
        {
            checkForPraysInRadar();
            if (isHunting())
            {
                if (index == 0)
                {
                    Point o = vA.getPoint();
                    Point d = pray.getPosition();
                    Point e;

                    double thetaPray, thetaEdge, tempDiff, diff = 100;

                    foreach(Edge ed in vA.getEdges())
                    {
                        e = ed.getDestination().getPoint();
                        thetaPray = Math.Atan2((d.Y - o.Y), (d.X - o.X));
                        thetaEdge = Math.Atan2((e.Y - o.Y), (e.X - o.X));

                        tempDiff = Math.Abs(thetaPray - thetaEdge);

                        if(tempDiff <= diff)
                        {
                            edge = ed;
                            diff = tempDiff;
                        }
                    }

                    vA.isOccupied(true);
                    vA.updateTimer();
                }

                if ((index + velocity) < edge.getPoints().Count)
                {
                    index = index + velocity;
                    position = edge.getPointAt(index);
                }
                else
                {
                    vA = edge.getDestination();
                    position = vA.getPoint();
                    index = 0;
                }
            }
            else
            {
                if(index == 0)
                {
                    edge = vA.getEdges().ElementAt(random.Next(0, vA.getEdges().Count));
                }

                if ((index + velocity) < edge.getPoints().Count)
                {
                    index = index + velocity;
                    position = edge.getPointAt(index);
                }
                else
                {
                    vA = edge.getDestination();
                    position = vA.getPoint();
                    index = 0;
                }
            }
        }
    }
}
