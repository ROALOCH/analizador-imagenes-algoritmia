using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace R
{
    public class Agent
    {
        List<Vertex> path;
        int iD, velocity, edgeIndex;
        Point position;
        Vertex aV;
        Edge aE;
        public Agent(Vertex v, int i, List<Vertex> p)
        {
            iD = i;
            aV = v;
            aE = null;
            velocity = 10;
            edgeIndex = 0;
            position = v.getPoint();
            path = p;
        }
        public int getID() => iD;
        public Point getPosition() => position;
        public Vertex getActualVertex() => aV;
        private bool inVertex() => aV != null;
        private bool chooseEdge()
        {

            if (path.Count == 0)
                return false;

            Vertex origin = path.First();
            path.Remove(origin);

            if (path.Count == 0)
                return false;

            Vertex destination = path.First();

            foreach (Edge e in origin.getEdges())
                if (e.getDestination() == destination)
                    aE = e;

            aV = null;
            return true;
        }
        public bool move()
        {
            bool flag = true;

            if (inVertex())
                flag = chooseEdge();

            if (flag == false)
                return false;

            else
            {
                position = aE.getPointAt(edgeIndex);
                if ((edgeIndex + velocity) <= aE.getLastIndex())
                    edgeIndex = edgeIndex + velocity;
                else
                {
                    position = aE.getDestination().getPoint();
                    aV = aE.getDestination();
                    edgeIndex = 0;
                }
            }
            return true;
        }
        public void draw(Graphics g)
        {
            int size = 32;
            g.FillEllipse(Brushes.White, position.X - (size / 2), position.Y - (size / 2), size, size);
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

        public Edge Edge
        {
            get => default;
            set
            {
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
    }
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

        public Vertex Vertex
        {
            get => default;
            set
            {
            }
        }

        public Agent Agent
        {
            get => default;
            set
            {
            }
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
        public List<Edge> getDirectionalEdges()
        {
            List<Edge> eL = new List<Edge>();
            List<Vertex> vL = new List<Vertex>();

            foreach (Vertex v in getVertices())
            {
                vL.Add(v);
                foreach (Edge e in v.getEdges())
                    if (!vL.Contains(e.getDestination()))
                        eL.Add(e);
            }

            var listOrdenada = eL.OrderBy(x => x.getWeight()).ToList();
            return listOrdenada;
        }

    }
}
