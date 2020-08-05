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
    public partial class SimulationWindow : Form
    {
        Graph tg, og;
        Bitmap bmp;
        Graphics gra;
        int agents, baitAte, limit;
        bool firstRound = true;
        bool manualSimulation = true;

        private void disableRadioButtons()
        {
            radioButtonAuto.Enabled = false;
            radioButtonManual.Enabled = false;
        }
        private void enableAnimateMode()
        {
            radioButtonAnimateManual.Enabled = true;
            radioButtonAnimateAuto.Enabled = true;
        }
        private void disableAnimateMode()
        {
            radioButtonAnimateManual.Enabled = false;
            radioButtonAnimateAuto.Enabled = false;
        }
        private void enableBaitControls()
        {
            comboBoxAutoBait.Enabled = true;
            buttonAutoBait.Enabled = true;
            comboBoxManualBait.Enabled = true;
            buttonManualBait.Enabled = true;
        }

        private void disableBaitControls()
        {
            comboBoxAutoBait.Enabled = false;
            buttonAutoBait.Enabled = false;
            comboBoxManualBait.Enabled = false;
            buttonManualBait.Enabled = false;
        }
        private void enableAgentControls()
        {
            comboBoxManualAgents.Enabled = true;
            buttonManualAgents.Enabled = true;
            numericUpDownAutoAgents.Enabled = true;
            buttonAutoAgents.Enabled = true;
        }
        private void disableAgentControls()
        {
            comboBoxManualAgents.Enabled = false;
            buttonManualAgents.Enabled = false;
            numericUpDownAutoAgents.Enabled = false;
            buttonAutoAgents.Enabled = false;
        }

        private void disableAllButtons()
        {
            disableRadioButtons();
            disableAgentControls();
            disableBaitControls();
            buttonStart.Enabled = false;
            buttonExit.Enabled = true;
        }
        private void RadioButtonManual_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonAuto.Checked)
            {
                panelAuto.Visible = true;
                panelManual.Visible = false;
            }
            if (radioButtonManual.Checked)
            {
                panelManual.Visible = true;
                panelAuto.Visible = false;
            }
        }
        private void resetBaitList()
        {
            comboBoxAutoBait.Items.Clear();
            comboBoxManualBait.Items.Clear();
            foreach (Vertex v in og.getVertex())
            {
                comboBoxAutoBait.Items.Add("Vértice " + v.getID());
                comboBoxManualBait.Items.Add("Vértice " + v.getID());
            }
        }
        private void setControls()
        {
            comboBoxAutoBait.Items.Clear();
            comboBoxManualBait.Items.Clear();
            comboBoxManualAgents.Items.Clear();
            foreach(Vertex v in tg.getVertex())
            {
                comboBoxAutoBait.Items.Add("Vértice " + v.getID());
                comboBoxManualBait.Items.Add("Vértice " + v.getID());
                comboBoxManualAgents.Items.Add("Vértice " + v.getID());
            }
            numericUpDownAutoAgents.Maximum = tg.getVertexCount() - 1;
            comboBoxAutoBait.SelectedIndex = 0;
            numericUpDownAutoAgents.Value = 1;
            comboBoxManualBait.SelectedIndex = 0;
            comboBoxManualAgents.SelectedIndex = 0;
        }

        private void drawGraphicsSolo()
        {
            gra.Clear(Color.Transparent);
            Point p = og.getBait().getPos();
            gra.FillEllipse(Brushes.GreenYellow, p.X - 20, p.Y - 20, 40, 40);
            foreach (Agent a in og.getAgents())
            {
                a.drawSolo(gra, og.getBait());
            }
            pictureBoxDisplay.Refresh();
        }

        private bool drawGraphics()
        {
            bool flag = false;
            gra.Clear(Color.Transparent);
            Point p = og.getBait().getPos();
            gra.FillEllipse(Brushes.GreenYellow, p.X - 20, p.Y - 20, 40, 40);
            foreach (Agent a in og.getAgents())
            {
                a.draw(gra, og.getBait());
                if (a.getPosition() == og.getBait().getPos())
                {
                    if(flag == false)
                    {
                        og.getBait().giveReward(a);
                        baitAte++;
                        labelAte.Text = baitAte.ToString();
                        labelAte.Update();
                    }
                    flag = true;
                }
                else
                    a.move(og);
            }
            pictureBoxDisplay.Refresh();
            return flag;
        }

        private void ButtonManualBait_Click(object sender, EventArgs e)
        {
            disableRadioButtons();
            disableBaitControls();
            labelBait.Text = "SÍ";

            Vertex v;

            if(firstRound)
                v = tg.getVertexAt(comboBoxManualBait.SelectedIndex);
            else
                v = og.getVertexAt(comboBoxManualBait.SelectedIndex);

            og.addBait(new Bait(v.getData()));

            if (firstRound)
            {
                comboBoxManualAgents.Items.RemoveAt(comboBoxManualBait.SelectedIndex);
                tg.getVertex().RemoveAt(comboBoxManualBait.SelectedIndex);
                comboBoxManualAgents.SelectedIndex = 0;
            }

            if (manualSimulation && firstRound)
                enableAgentControls();
            else
                buttonStart.Enabled = true;
            // drawGraphics();
            drawGraphicsSolo();
        }

        private void ButtonManualAgents_Click(object sender, EventArgs e)
        {
            Vertex v = tg.getVertexAt(comboBoxManualAgents.SelectedIndex);
            og.addAgent(new Agent(v.getData(), agents));
            agents++;

            tg.getVertex().RemoveAt(comboBoxManualAgents.SelectedIndex);
            comboBoxManualAgents.Items.RemoveAt(comboBoxManualAgents.SelectedIndex);

            labelAgents.Text = agents.ToString();
            enableAnimateMode();
            buttonStart.Enabled = true;

            if (tg.getVertexCount() == 0)
                disableAgentControls();
            //drawGraphics();
            drawGraphicsSolo();
        }

        private void ButtonAutoBait_Click(object sender, EventArgs e)
        {
            disableRadioButtons();
            disableBaitControls();
            labelBait.Text = "SÍ";

            Vertex v;

            if (firstRound)
                v = tg.getVertexAt(comboBoxManualBait.SelectedIndex);
            else
                v = og.getVertexAt(comboBoxManualBait.SelectedIndex);

            og.addBait(new Bait(v.getData()));

            if(firstRound)
                tg.getVertex().RemoveAt(comboBoxAutoBait.SelectedIndex);

            if (manualSimulation && firstRound)
                enableAgentControls();
            else
                buttonStart.Enabled = true;
            //drawGraphics();
            drawGraphicsSolo();
        }

        private void ButtonAutoAgents_Click(object sender, EventArgs e)
        {
            disableAgentControls();

            int numberOfAgents = (int)numericUpDownAutoAgents.Value;
            int index;
            Random random = new Random();
            for(int i = 0; i < numberOfAgents; i++)
            {
                index = random.Next(0, tg.getVertexCount());
                Vertex v = tg.getVertexAt(index);
                og.addAgent(new Agent(v.getData(), agents));
                tg.getVertex().RemoveAt(index);
                agents++;
                labelAgents.Text = agents.ToString();
            }
            enableAnimateMode();
            buttonStart.Enabled = true;
            //drawGraphics();
            drawGraphicsSolo();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonStart_Click(object sender, EventArgs e)
        {
            // ANIMACION AUTOMATICA
            if (radioButtonAnimateAuto.Checked)
            {
                manualSimulation = false;
                CustomMessageBox newWindow = new CustomMessageBox(true, "AVISO", "la simulación terminará al alcanzar\nel número de señuelos especificados", "OK");
                newWindow.ShowDialog();
                limit = newWindow.getLimit();

                while(og.hasBait() && (baitAte < limit))
                {
                    if (drawGraphics())
                    {
                        og.deleteBait();
                        og.clearMarks();
                        generateRandomBait();
                    }
                }

                CustomMessageBox newPopUp = new CustomMessageBox(false, "AVISO", "límite de señuelos alcanzado\nsimulación terminada", "OK");
                newPopUp.ShowDialog();
                disableAllButtons();
                disableAnimateMode();
            }

            // ANIMACION MANUAL (SEÑUELO POR SEÑUELO)
            if (radioButtonAnimateManual.Checked)
            {
                manualSimulation = true;
                disableBaitControls();
                disableAgentControls();
                buttonStart.Enabled = false;

                while (og.hasBait())
                {
                    if (drawGraphics())
                    {
                        og.deleteBait();
                        og.clearMarks();
                        firstRound = false;
                    }
                }

                resetBaitList();
                CustomMessageBox newPopUp = new CustomMessageBox(false, "AVISO", "un agente alcanzó el señuelo\nsimulación en espera\npara continuar agregue un nuevo señuelo", "OK");
                newPopUp.ShowDialog();
                buttonExit.Enabled = true;
                enableBaitControls();
                disableAnimateMode();
            }
        }
        private void generateRandomBait()
        {
            Random random = new Random();
            int r = random.Next(0, og.getVertexCount());
            og.addBait(new Bait(og.getVertexAt(r).getData()));
        }
        public SimulationWindow(Graph graph, Bitmap b)
        {
            graph.deleteBait();
            graph.getAgents().Clear();
            tg = new Graph(graph);
            og = graph;
            bmp = new Bitmap(b.Width, b.Height);
            gra = Graphics.FromImage(bmp);
            agents = 0;
            InitializeComponent();
            pictureBoxDisplay.BackgroundImage = b;
            pictureBoxDisplay.Image = bmp;
            setControls();
            numericUpDownAutoAgents.Value = og.getVertexCount() - 1;
        }
    }
}
