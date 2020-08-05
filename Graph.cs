using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iP_Etapa2
{
    public class Edge
    {
        Vertex destination;
        public Edge(Vertex v) => destination = v;
        public Vertex getDestination() => destination;
    }
    public class Vertex
    {
        List<Edge> eL;
        Point data;
        int iD;
        public Vertex(Point p, int id)
        {
            data = new Point(p.X, p.Y);
            iD = id;
            eL = new List<Edge>();
        }
        public Point getData() => data;
        public int getID() => iD;
        public string getInfo() => "Vértice N. " + iD + ", Centro (" + data.X + ", " + data.Y + ")";
        public List<Edge> getEdges() => eL;
        public void addEdge(Vertex v)
        {
            Edge e = new Edge(v);
            this.eL.Add(e);
        }
    }
    public class Graph
    {
        List<Vertex> vL;
        public Graph()
        {
            vL = new List<Vertex>();
        }
        public int getVertexCount() => vL.Count;
        public Vertex getVertexAt(int i) => vL[i];
        public List<Vertex> getVertex() => vL;
        public void addVertex(Point p)
        {
            vL.Add(new Vertex(p, vL.Count));
        }
        public Vertex findVertex(Point p)
        {
            foreach (Vertex v in vL)
                if (v.getData() == p)
                    return v;
            return null;
        }
    }
}
