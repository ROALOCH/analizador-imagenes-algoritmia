using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HUNT
{
    public partial class SimulationWindow : Form
    {
        bool radar, relation, route, health;
        bool prayReady, predatorReady, repeat;
        int radarSize;
        Random random;
        List<int> index;

        Graph g;
        Vertex vObjective;
        Point pObjective;
        Bitmap backB, frontB;
        Graphics backG, frontG;
        public SimulationWindow(bool radar, bool relation, bool route, bool health, int radarSize, Graph g, Bitmap bmp, Graphics gra)
        {
            // DEFINIR PARAMETROS DE VISUALIZACIÓN //
            this.radar = radar;
            this.relation = relation;
            this.route = route;
            this.health = health;
            this.radarSize = radarSize;
            this.prayReady = false;
            this.predatorReady = false;
            this.random = new Random();

            this.g = new Graph(g);
            this.vObjective = null;
            this.backB = new Bitmap(bmp);
            this.backG = Graphics.FromImage(backB);
            this.frontB = new Bitmap(bmp.Width, bmp.Height);
            this.frontG = Graphics.FromImage(frontB);

            InitializeComponent();
            InitializeInput();

            pictureBox.BackgroundImage = backB;
            pictureBox.Image = frontB;
        }
        private void setRadioButtonConfig(bool b)
        {
            labelConfig.Enabled = b;
            radioButtonAuto.Enabled = b;
            radioButtonManual.Enabled = b;
        }
        private void drawElements()
        {
            frontG.Clear(Color.Transparent);
            frontG.FillRectangle(Brushes.Gold, pObjective.X - 20, pObjective.Y - 20, 40, 40);
            g.drawPrays(route, health, frontG);
            g.drawPredators(radar, relation, frontG);
            pictureBox.Refresh();
        }
        private bool drawNMove()
        {
            bool flag;
            frontG.Clear(Color.Transparent);
            frontG.FillRectangle(Brushes.Gold, pObjective.X - 20, pObjective.Y - 20, 40, 40);
            flag = g.drawNMovePrays(route, health, frontG);
            g.drawNMovePredators(radar, relation, frontG);
            pictureBox.Refresh();
            return flag;
        }
        private void InitializeInput()
        {
            comboBoxObjective.Items.Clear();

            foreach(Vertex v in g.getVertices())
            {
                comboBoxObjective.Items.Add(v);
                comboBoxPrayM.Items.Add(v);
                comboBoxPredatorM.Items.Add(v);
            }

            numericUpDownPray.Maximum = (g.getVerticesCount() - 2);
            numericUpDownPredator.Maximum = (g.getVerticesCount() - numericUpDownPray.Value - 1);
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            groupBoxAuto.Enabled = false;
            groupBoxManual.Enabled = false;

            bool reachedObjective = false;
            while (!reachedObjective)
            {
                if (g.getPraysCount() < 1)
                {
                    buttonStart.Enabled = false;
                    break;
                }
                reachedObjective = drawNMove();
            }

            if(g.getPraysCount() >= 1)
            {
                repeat = true;
                labelObjective.Enabled = true;
                comboBoxObjective.Enabled = true;
                buttonSetObjective.Enabled = true;
            }
        }

        private void buttonSetObjective_Click(object sender, EventArgs e)
        {
            if (!repeat)
            {
                index = new List<int>();
                labelObjective.Enabled = false;
                comboBoxObjective.Enabled = false;
                buttonSetObjective.Enabled = false;
                setRadioButtonConfig(true);
                groupBoxManual.Visible = true;
                groupBoxAuto.Visible = true;

                vObjective = (Vertex)comboBoxObjective.SelectedItem;
                pObjective = vObjective.getPoint();

                comboBoxPrayM.Items.Remove(comboBoxObjective.SelectedItem);
                comboBoxPredatorM.Items.Remove(comboBoxObjective.SelectedItem);
                index.Add(vObjective.getID());
                drawElements();
            }
            else
            {
                vObjective = (Vertex)comboBoxObjective.SelectedItem;
                pObjective = vObjective.getPoint();

                foreach (Pray p in g.getPrays())
                    p.updateObjective(vObjective);

                labelObjective.Enabled = false;
                comboBoxObjective.Enabled = false;
                buttonSetObjective.Enabled = false;
                drawElements();
                buttonStart.Enabled = true;
            }
        }

        // CONTROLES AUTOMÁTICOS //
        private void radioButtonAuto_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButtonAuto.Checked == true)
            {
                groupBoxAuto.Visible = true;
                groupBoxManual.Visible = false;
            }
            else
            {
                groupBoxAuto.Visible = false;
                groupBoxManual.Visible = true;
            }
        }
        private void buttonSetPrayA_Click(object sender, EventArgs e)
        {
            setRadioButtonConfig(false);
            numericUpDownPredator.Maximum = (g.getVerticesCount() - numericUpDownPray.Value - 1);
            labelPrayA.Enabled = false;
            numericUpDownPray.Enabled = false;
            buttonSetPrayA.Enabled = false;
            labelPredatorA.Enabled = true;
            numericUpDownPredator.Enabled = true;
            buttonSetPredatorA.Enabled = true;

            int generated;

            for (int i = 0; i < numericUpDownPray.Value; i++)
            {
                generated = random.Next(0, g.getVerticesCount());
                if (!index.Contains(generated))
                {
                    Vertex v = g.getVertexAt(generated);
                    g.addPray(new Pray(g.getPraysCount(), v, vObjective, g));
                    index.Add(generated);
                }
                else
                {
                    i--;
                }
            }
            drawElements();
        }
        private void buttonSetPredatorA_Click(object sender, EventArgs e)
        {
            labelPredatorA.Enabled = false;
            numericUpDownPredator.Enabled = false;
            buttonSetPredatorA.Enabled = false;
            buttonStart.Enabled = true;

            int generated;

            for (int i = 0; i < numericUpDownPredator.Value; i++)
            {
                generated = random.Next(0, g.getVerticesCount());
                if (!index.Contains(generated))
                {
                    Vertex v = g.getVertexAt(generated);
                    g.addPredator(new Predator(g.getPredatorsCount(), radarSize, v, g.getPrays()));
                    index.Add(generated);
                }
                else
                {
                    i--;
                }
            }
            drawElements();
        }

        // CONTROLES MANUALES //
        private void buttonPrayM_Click(object sender, EventArgs e)
        {
            setRadioButtonConfig(false);
            prayReady = true;
            if (prayReady && predatorReady)
                buttonStart.Enabled = true;

            Vertex vA = (Vertex) comboBoxPrayM.SelectedItem;
            g.addPray(new Pray(g.getPraysCount(), vA, vObjective, g));
            comboBoxPrayM.Items.Remove(vA);
            comboBoxPredatorM.Items.Remove(vA);
            drawElements();
        }
        private void buttonPredatorM_Click(object sender, EventArgs e)
        {
            setRadioButtonConfig(false);
            predatorReady = true;
            if (prayReady && predatorReady)
                buttonStart.Enabled = true;

            Vertex vA = (Vertex)comboBoxPredatorM.SelectedItem;
            g.addPredator(new Predator(g.getPredatorsCount(), radarSize, vA, g.getPrays()));
            comboBoxPrayM.Items.Remove(vA);
            comboBoxPredatorM.Items.Remove(vA);
            drawElements();
        }
    }
}
