using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iP_Etapa5
{
    public partial class MainWindow : Form
    {
        Library lib = new Library();
        Bitmap pbmp, sbmp, gbmp;
        Graphics graB, graG;
        Graph g = new Graph();
        public MainWindow()
        {
            InitializeComponent();
        }

        // BOTONES //
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "Imagen (*.PNG; *.JPG) | *.PNG; *.JPG";
            if(DialogResult.OK == file.ShowDialog())
            {
                g.clear();

                pbmp = new Bitmap(file.FileName);
                sbmp = new Bitmap(file.FileName);
                gbmp = new Bitmap(pbmp.Width, pbmp.Height);
                graB = Graphics.FromImage(pbmp);
                graG = Graphics.FromImage(gbmp);

                pictureBox.Image = pbmp;
                buttonProcess.Enabled = true;
                buttonDijkstra.Enabled = false;
                buttonSave.Enabled = false;
            }
        }
        private void buttonProcess_Click(object sender, EventArgs e)
        {
            lib.processImage(sbmp, pbmp, graB, graG, g);
            pictureBox.Image = pbmp;

            buttonProcess.Enabled = false;
            buttonDijkstra.Enabled = true;
            buttonSave.Enabled = true;
        }
        private void buttonDijkstra_Click(object sender, EventArgs e)
        {
            Bitmap canvas = new Bitmap(gbmp.Width, gbmp.Height);
            Graphics canvasG = Graphics.FromImage(canvas);

            DijkstraWindow newWindow = new DijkstraWindow(gbmp, graG, canvas, canvasG, g);
            newWindow.ShowDialog();
            newWindow.Dispose();
        }
        private void buttonSave_Click(object sender, EventArgs e)
        {

        }
        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }        
    }
}
