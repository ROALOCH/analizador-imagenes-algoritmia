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
    public partial class MainWindow : Form
    {
        Functions library = new Functions();
        Bitmap shapeD, processed, graph;
        Graphics processedG, graphG;
        Graph g;

        public MainWindow()
        {
            InitializeComponent();
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "Imagen (*.PNG; *.JPG) | *.PNG; *.JPG";
            if(DialogResult.OK == file.ShowDialog())
            {
                shapeD = new Bitmap(file.FileName);
                processed = new Bitmap(file.FileName);
                graph = new Bitmap(shapeD.Width, shapeD.Height);

                processedG = Graphics.FromImage(processed);
                graphG = Graphics.FromImage(graph);

                g = new Graph();

                pictureBox.Image = processed;
                buttonProcess.Enabled = true;
            }
        }
        private void buttonProcess_Click(object sender, EventArgs e)
        {
            buttonProcess.Enabled = false;
            library.processImage(shapeD, processed, processedG, graphG, g);
            buttonSave.Enabled = true;
            buttonSimulate.Enabled = true;
            pictureBox.Refresh();
        }
        private void buttonSave_Click(object sender, EventArgs e)
        {

        }
        private void buttonSimulate_Click(object sender, EventArgs e)
        {
            ConfigWindow configWindow = new ConfigWindow();
            if (DialogResult.OK == configWindow.ShowDialog())
            {
                bool radar = configWindow.getRadar();
                bool relation = configWindow.getRelation();
                bool route = configWindow.getRoute();
                bool health = configWindow.getHealth();
                int radarSize = configWindow.getRadarSize();

                SimulationWindow simulationWindow = new SimulationWindow(radar, relation, route, health, radarSize, g, graph, graphG);
                simulationWindow.ShowDialog();
                g.clearPP();
            }
        }
        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
