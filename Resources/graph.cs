using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemploGrafo
{

    public class Edge
    {
        Vertex destination;
        public Edge(Vertex v) {
            destination = v;
        }
    }
    public class Vertex
    {
        List<Edge> eL;
        Point data;
        int id;
        public Vertex(Point p, int id) {
            data = new Point(p.X, p.Y);
            this.id = id;
            eL = new List<Edge>();
        }
        public Point getData()
        {
            return data;
        }

        public void addEdge(Vertex v)
        {
            Edge e = new Edge(v);
            this.eL.Add(e);
        }
    }
    class Graph
    {
        List<Vertex> vL;
        public Graph() {
            vL = new List<Vertex>();
        }

        public void addVertex(Point p)
        {
            vL.Add(new Vertex(p, vL.Count));
        }

        public Vertex FindVertex(Point p)
        {
            foreach(Vertex v in vL)
            {
                if (v.getData() == p)
                    return v;
            }
            return null;
        }

        public int getVertexCount()
        {
            return vL.Count;
        }

        public Vertex getVertexAt(int i)
        {
            return vL[i];
        }
    }
}
