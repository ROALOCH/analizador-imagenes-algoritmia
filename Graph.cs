using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace iP_Etapa2{

    public class Mark
    {
        private int iD;
        private int flag;
        public Mark(int i, int f)
        {
            iD = i;
            flag = f;
        }
        public int getID() => iD;
        public int getFlag() => flag;
        public void updateFlag() => flag++;
    }
    public class Bait
    {
        private Point pos;
        private int reward;

        public Bait(Point p)
        {
            pos = p;
            reward = 1;
        }
        public Point getPos() => pos;
        public void giveReward(Agent a) => a.updateVelocity(reward);
    }
    public class Agent
    {
        private Point pos;
        private Edge edge;
        private Vertex vA;
        private int iD;
        private int vel;
        private int index;

        public Agent(Point p, int i)
        {
            pos = p;
            iD = i;
            vel = 5;
            edge = null;
            vA = null;
            index = 0;
        }

        public Point getPosition() => pos;
        public int getiD() => iD;
        public void updateVelocity(int i) => vel = vel + i;
        private bool inVertex(Graph g)
        {
            foreach (Vertex v in g.getVertex())
                if (pos == v.getData())
                {
                    Mark m = v.getMark(iD);
                    if (m == null)
                        v.addMark(new Mark(iD, 1));
                    else
                        m.updateFlag();
                    vA = v;
                    return true;
                }
            return false;
        }
        private void chooseEdge(Graph g)
        {
            Point o = vA.getData();
            Point b = g.getBait().getPos();
            Point e;

            bool anyZeroEdge = false;
            Edge lowestFlagEdge = null;
            int tempFlag, lowestFlag = 100;

            double thetaBait, thetaEdge, tempDiff, diff = 100;

            foreach (Edge ed in vA.getEdges())
            {
                e = ed.getDestination().getData();
                thetaBait = Math.Atan2((b.Y - o.Y), (b.X - o.X));
                thetaEdge = Math.Atan2((e.Y - o.Y), (e.X - o.X));

                if ((thetaEdge > Math.PI) && (thetaBait == 0))
                    thetaBait = (2 * Math.PI);

                tempDiff = Math.Abs(thetaBait - thetaEdge);

                Mark m = ed.getDestination().getMark(iD);

                if (m == null)
                    tempFlag = 0;
                else
                    tempFlag = m.getFlag();

                if (tempFlag < lowestFlag)
                {
                    lowestFlagEdge = ed;
                    lowestFlag = tempFlag;
                }

                if ((tempDiff <= diff) && (tempFlag == 0))
                {
                    edge = ed;
                    diff = tempDiff;
                    anyZeroEdge = true;
                }

            }

            if (anyZeroEdge == false)
                edge = lowestFlagEdge;

        }
        public void move(Graph g)
        {
            if (inVertex(g))
                chooseEdge(g);
            if(edge != null)
            {
                pos = edge.getPointAt(index);
                if ((index + vel) <= edge.getPoints().Count - 1)
                    index = index + vel;
                else
                {
                    pos = edge.getLastPoint();
                    index = 0;
                }
            }
        }

        public void drawSolo(Graphics g, Bait b)
        {
            Pen p = new Pen(Color.GreenYellow, 1);

            g.FillEllipse(Brushes.Red, pos.X - 20, pos.Y - 20, 40, 40);
            g.DrawLine(p, pos, b.getPos()); // DIBUJAR LINEA AL SEÑUELO
        }
        public void draw(Graphics g, Bait b)
        {

            Pen p = new Pen(Color.GreenYellow, 1);

            g.FillEllipse(Brushes.Red, pos.X - 20, pos.Y - 20, 40, 40);
            g.DrawLine(p, pos, b.getPos()); // DIBUJAR LINEA AL SEÑUELO

            // DIBUJAR FLECHA DIRECCIONAL AL SEÑUELO

            /*double theta = Math.Atan2((b.getPos().Y - pos.Y), (b.getPos().X - pos.X));
            Point arrow = new Point();
            arrow.X = (int)Math.Round((40 * Math.Cos(theta) + pos.X));
            arrow.Y = (int)Math.Round((40 * Math.Sin(theta) + pos.Y));
            p.EndCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;
            g.DrawLine(p, pos, arrow);*/
        }
    }
    public class Edge{

        private Vertex destination;
        private List<Point> pL;
        public Edge(Vertex v, List<Point> list){
            destination = v;
            pL = list;
        }

        public Vertex Vertex
        {
            get => default;
            set
            {
            }
        }

        public Vertex getDestination() => destination;
        public List<Point> getPoints() => pL;
        public Point getPointAt(int i) => pL[i];
        public Point getLastPoint() => pL[pL.Count - 1];
    }
    public class Vertex{

        private List<Edge> eL;
        private List<Mark> mL;
        private Point data;
        private int iD;
        public Vertex(Point p, int id){
            data = new Point(p.X, p.Y);
            iD = id;
            eL = new List<Edge>();
            mL = new List<Mark>();
        }

        public Edge Edge
        {
            get => default;
            set
            {
            }
        }

        public Mark Mark
        {
            get => default;
            set
            {
            }
        }

        public Point getData() => data;
        public int getID() => iD;
        public string getInfo(){
            return "Vértice N. " + iD + ", Centro (" + data.X + ", " + data.Y + ")";
        }
        public List<Edge> getEdges() => eL;
        public Edge getEdgeAt(int i) => eL[i];
        public int getEdgesCount() => eL.Count;
        public void addEdge(Vertex v, List<Point> pl){
            Edge e = new Edge(v, pl);
            eL.Add(e);
        }
        public void addMark(Mark m) => mL.Add(m);
        public void clearMarks() => mL.Clear();
        public Mark getMark(int i)
        {
            foreach (Mark m in mL)
                if (m.getID() == i)
                    return m;
            return null;
        }
        public List<Mark> getMarks() => mL;
    }
    public class Graph{

        private List<Vertex> vL;
        private List<Agent> aL;
        private Bait bait;
        private bool baitBool;
        public Graph(){
            vL = new List<Vertex>();
            aL = new List<Agent>();
            bait = null;
            baitBool = false;
        }
        public Graph(Graph g)
        {
            vL = new List<Vertex>(g.getVertex());
            aL = new List<Agent>(g.getAgents());
            bait = null;
            baitBool = false;
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

        public Bait Bait
        {
            get => default;
            set
            {
            }
        }

        public int getVertexCount() => vL.Count;
        public Vertex getVertexAt(int i) => vL[i];
        public List<Vertex> getVertex() => vL;
        public void addVertex(Point p){
            vL.Add(new Vertex(p, vL.Count));
        }
        public Vertex findVertex(Point p){
            foreach (Vertex v in vL)
                if (v.getData() == p)
                    return v;
            return null;
        }
        public void addAgent(Agent a){
            aL.Add(a);
        }
        public List<Agent> getAgents() => aL;
        public void addBait(Bait b)
        {
            bait = b;
            baitBool = true;
        }
        public void deleteBait()
        {
            bait = null;
            baitBool = false;
        }
        public Bait getBait() => bait;
        public bool hasBait() => baitBool;
        public void clearMarks()
        {
            foreach (Vertex v in vL)
                v.clearMarks();
        }
    }
}
