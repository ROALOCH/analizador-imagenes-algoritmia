using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace iP_Etapa5
{
    public class Graph
    {
        List<Vertex> vL;
        List<Agent> aL;

        public Graph()
        {
            vL = new List<Vertex>();
            aL = new List<Agent>();
        }
        public Graph(Graph g)
        {
            vL = new List<Vertex>(g.getVertices());
            aL = new List<Agent>(g.getAgents());
        }
        public List<Vertex> getVertices() => vL;
        public int getVerticesCount() => vL.Count;
        public Vertex getVertexAt(int i) => vL.ElementAt(i);
        public List<Agent> getAgents() => aL;
        public int getAgentsCount() => aL.Count;
        public Agent getAgentAt(int i) => aL.ElementAt(i);
        public void addAgent(Agent a) => aL.Add(a);
        public void addVertex(Point p) => vL.Add(new Vertex(p, vL.Count));
        public void clear() => vL.Clear();
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
            foreach(Vertex o in vL)
            {
                temp.Add(o);
                foreach(Edge e in o.getEdges())
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
    }

    public class Vertex
    {
        List<Edge> eL;
        Point point;
        int iD;
        public Vertex(Point p, int i)
        {
            eL = new List<Edge>();
            point = new Point(p.X, p.Y);
            iD = i;
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
    }

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

    public class Agent
    {
        int velocity, index;
        List<Vertex> vertexPath;
        List<Point> pointPath;
        Point position;
        Vertex aV;
        bool finished;
        public Agent(Vertex v, List<Vertex> p)
        {
            aV = v;
            index = 0;
            velocity = 10;
            finished = false;
            vertexPath = p;
            position = v.getPoint();
            pointPath = new List<Point>();
            getPointList();
        }
        public bool reachedObjective() => finished;
        private void getPointList()
        {
            Vertex vA, vB;
            while (vertexPath.Count != 0)
            {
                vA = vertexPath.ElementAt(0);
                vertexPath.RemoveAt(0);
          
                if (vertexPath.Count == 0)
                    break;

                vB = vertexPath.ElementAt(0);

                foreach (Edge e in vA.getEdges())
                    if (e.getDestination() == vB)
                        foreach (Point p in e.getPoints())
                            pointPath.Add(p);
            }
        }
        public Point getPosition() => position;
        public void move()
        {
            if (pointPath.Count == 0)
            {
                finished = true;
                return;
            }

            if (index + velocity > pointPath.Count - 1)
            {
                position = pointPath[pointPath.Count() - 1];
                finished = true;
            }

            else
            {
                index = index + velocity;
                position = pointPath[index];
            }
        }
        public void draw(Graphics g)
        {
            int size = 40;
            g.FillEllipse(Brushes.Orange, position.X - (size / 2), position.Y - (size / 2), size, size);
        }
    }

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
}
