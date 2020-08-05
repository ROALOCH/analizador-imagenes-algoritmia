using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iP
{
    public partial class mainWindow : Form
    {
        List<Circle> sL;
        Bitmap originalImage;
        Bitmap b;
        bool flagO;
        int nS, nC, nO;
        public mainWindow()
        {
            sL = new List<Circle>();
            InitializeComponent();
        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "Imagen (*.JPG; *.PNG) | *.jpg; *.png";
            if(DialogResult.OK == file.ShowDialog())
            {
                originalImage = new Bitmap(file.FileName);
                pictureBoxDisplay.Image = originalImage;
                nS = 0;
                nC = 0;
                nO = 0;
                sL.Clear();
                buttonProcess.Enabled = true;
                buttonBig.Enabled = false;
                buttonDetails.Enabled = false;
                buttonCompare.Enabled = false;
                buttonSave.Enabled = false;
            }
        }

        private void ButtonProcess_Click(object sender, EventArgs e)
        {
            imageProcessing();
            buttonProcess.Enabled = false;
            buttonBig.Enabled = true;
            buttonDetails.Enabled = true;
            buttonCompare.Enabled = true;
            buttonSave.Enabled = true;
        }

        private void imageProcessing()
        {
            b = new Bitmap(originalImage);
            // SE IDENTIFICAN PIXELES DIFERENTES A BLANCO Y SE COLOREAN DE NEGRO
            noiseReduction();
            // SE IDENTIFICAN LAS FIGURAS EN LA IMAGEN, TANTO CIRCULOS COMO OVALOS
            shapeDetection();
            // SI SE DETECTA UN OVALO EN LA IMAGEN, SE HACE UN PROCESO DE ELIMINADO DE OVALOS
            // SI NO SE DETECTA NINGUN OVALO, SE AHORRA ESTE PROCESO
            if (flagO)
                eraseOvals();
            nC = nS - nO;
            // SE UBICAN LOS CENTROS DE LAS FIGURAS CIRCULARES
            drawCenters();
            pictureBoxDisplay.Image = b;
        }

        private bool isWhite(Color c)
        {
            return c.Name == "ffffffff";
        }

        private bool isBlack(Color c)
        {
            return c.Name == "ff000000";
        }

        private bool isYellow(Color c)
        {
            return c.Name == "ffffff00";
        }

        private void drawCenters()
        {
            foreach(Circle sh in sL)
            {
                if(sh.isCircle())
                    sh.drawCenter(b, Color.Black);
            }
        }

        private void eraseOvals()
        {
            for (int i = 0; i < b.Height - 1; i++)
            {
                for (int j = 0; j < b.Width - 1; j++)
                {
                    if (isYellow(b.GetPixel(j, i)))
                    {
                        b.SetPixel(j, i, Color.White);
                    }
                }
            }
        }

        private void noiseReduction()
        {
            for(int i = 0; i < b.Height - 1; i++)
            {
                for(int j = 0; j < b.Width - 1; j++)
                {
                    if (!isWhite(b.GetPixel(j, i)))
                    {
                        b.SetPixel(j, i, Color.Black);
                    }
                }
            }
        }

        private void shapeDetection()
        {
            int lx, rx, uy, ly, cx, cy, lsx, rsx;
            bool flagS;
            for(int y = 0; y < b.Height; y++)
            {
                for(int x = 0; x < b.Width; x++)
                {
                    // SE ENCUENTRA UN PIXEL NEGRO
                    if(isBlack(b.GetPixel(x, y)))
                    {
                        lx = x;
                        rx = lx;
                        uy = y;
                        // SE RECORRE EL RENGLON EN X HASTA QUE SE ENCUENTRA UN PIXEL BLANCO
                        while(rx < b.Width && isBlack(b.GetPixel(rx, uy)))
                        {
                            rx++;
                        }
                        rx--;
                        // SE ESTABLECE EL CENTRO EN X DE LA FIGURA
                        cx = ((rx - lx) / 2) + lx;
                        ly = uy;
                        // SE RECORRE LA COLUMNA EN Y HASTA QUE SE ENCUENTRA UN PIXEL BLANCO
                        while(ly < b.Height && isBlack(b.GetPixel(cx, ly)))
                        {
                            ly++;
                        }
                        ly--;
                        // SE ESTABLECE EL CENTRO EN Y DE LA FIGURA
                        cy = ((ly - uy) / 2) + uy;
                        rsx = cx;
                        // SE RECORRE EL RENGLON EN X DESDE EL CENTRO HACIA LA DERECHA HASTA QUE SE ENCUENTRA UN PIXEL BLANCO
                        while(rsx < b.Width && isBlack(b.GetPixel(rsx, cy)))
                        {
                            rsx++;
                        }
                        rsx--;
                        // SE RECORRE EL RENGLON EN X DESDE EL CENTRO HACIA LA IZQUIERDA HASTA QUE SE ENCUENTRA UN PIXEL BLANCO
                        lsx = cx;
                        while (lsx > 0 && isBlack(b.GetPixel(lsx, cy)))
                        {
                            lsx--;
                        }
                        lsx++;
                        nS++;
                        // SE CREA UNA FIGURA CON LOS PUNTOS UBICADOS
                        Circle sh = new Circle(cx, cy, uy, ly, lsx, rsx, nS);
                        // SE AGREGA A LA LISTA DE FIGURAS ENCONTRADAS
                        sL.Add(sh);
                        flagS = sh.eraseShape(b);
                        if(flagS)
                        {
                            nO++;
                            flagO = true;
                        }
                    }
                }
            }
        }

        private void ButtonBig_Click(object sender, EventArgs e)
        {
            maxView newWindow = new maxView(b);
            newWindow.ShowDialog();
        }

        private void ButtonCompare_Click(object sender, EventArgs e)
        {
            compareWindow newWindow = new compareWindow(originalImage, b);
            newWindow.ShowDialog();
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            Image file = pictureBoxDisplay.Image;
            SaveFileDialog f = new SaveFileDialog();
            f.Filter = "Imagen (*.JPG) | *.jpg";
            if (DialogResult.OK == f.ShowDialog())
            {
                file.Save(f.FileName);
            }
        }

        private void ButtonDetails_Click(object sender, EventArgs e)
        {
            resultsWindow newWindow = new resultsWindow(b, sL, nS, nC, nO);
            this.Hide();
            newWindow.ShowDialog();
            this.Show();
            newWindow.Dispose();
        }
    }
}
