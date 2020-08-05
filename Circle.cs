using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iP
{
    public class Circle
    {
        private int id;
        private int centerX, centerY;
        private int upperY, lowestY, leftSideX, rightSideX;
        public int radiusH, radiusV, sizeX, sizeY;

        public Circle(int cx, int cy, int uy, int ly, int lsx, int rsx, int i)
        {
            centerX = cx;
            centerY = cy;
            upperY = uy;
            lowestY = ly;
            leftSideX = lsx;
            rightSideX = rsx;
            radiusH = rsx - cx;
            radiusV = ly - cy;
            sizeX = rsx - lsx;
            sizeY = ly - uy;
            id = i;
        }

        // RETORNA LA INFORMACION NECESARIA PARA MOSTRARSE EN UN LISTBOX
        // FORMATO -> "Circulo N. X, Centro (X,Y), Radio: 10"
        public string showInfo()
        {
            return "Circulo N. " + id + ", Centro (" + getCenterC() + "), " + "Radio: " + radiusH;
        }
        // RETORNA EL RADIO HORIZONTAL DE LA FIGURA
        public int getRadius()
        {
            return radiusH;
        }
        // RETORNA EL CENTRO DE LA FIGURA EN FORMATO DE COORDENADA
        // FORMATO -> "X, Y"
        public string getCenterC()
        {
            return centerX.ToString() + ", " + centerY.ToString();
        }

        // RETORNA EL IDENTIFICADOR DE LA FIGURA
        public int getID()
        {
            return id;
        }
        private bool isWhite(Color c)
        {
            return c.Name == "ffffffff";
        }
        public bool isCircle()
        {
            return (((radiusV - radiusH) <= 10) && ((radiusV - radiusH) >= -10));
        }

        // SE COLOREA LA FIGURA. 
        // SI ES CIRCULO SE PINTA DE MAGENTA
        // SI ES OVALO SE PINTA DE AMARILLO PARA POSTERIORMENTE SER ELIMINADO.
        public bool eraseShape(Bitmap b)
        {
            int up = centerY;
            int down = centerY;
            bool flag = false;
            // RECORRIDO IZQUIERDA A DERECHA
            // DESDE LOS EXTREMOS DE LA FIGURA (EXTREMO IZQ A EXTREMO DER)
            // SE COLOREA DEL CENTRO HACIA LOS EXTREMOS
            // CENTRO A EXT. SUPERIOR Y CENTRO A EXT. INFERIOR
            for(int x = leftSideX; x <= rightSideX; x++)
            {
                up = centerY;
                down = centerY;
                while(!isWhite(b.GetPixel(x, up)))
                {
                    b.SetPixel(x, up, Color.Magenta);
                    if (!isCircle())
                    {
                        flag = true;
                        b.SetPixel(x, up, Color.Yellow);
                    }
                    up++;
                }
                while (!isWhite(b.GetPixel(x, down)))
                {
                    b.SetPixel(x, down, Color.Magenta);
                    if (!isCircle())
                    {
                        b.SetPixel(x, down, Color.Yellow);
                    }
                    down--;
                }
            }
            return flag;
        }

        // SE COLOREA UNA CRUZ DE 3 PIXELES POR LADO PARTIENDO DEL CENTRO
        public void drawCenter(Bitmap b, Color c)
        {
            b.SetPixel(centerX, centerY, c);
            b.SetPixel(centerX, centerY + 1, c);
            b.SetPixel(centerX, centerY + 2, c);
            b.SetPixel(centerX, centerY + 3, c);
            b.SetPixel(centerX, centerY - 1, c);
            b.SetPixel(centerX, centerY - 2, c);
            b.SetPixel(centerX, centerY - 3, c);
            b.SetPixel(centerX + 3, centerY, c);
            b.SetPixel(centerX + 2, centerY, c);
            b.SetPixel(centerX + 1, centerY, c);
            b.SetPixel(centerX - 1, centerY, c);
            b.SetPixel(centerX - 2, centerY, c);
            b.SetPixel(centerX - 3, centerY, c);
        }

        // SE RESALTA LA FIGURA CIRCULAR EN TONO INDIGO
        public void highlightShape(Bitmap b)
        {
            int up, down;
            for (int x = leftSideX; x <= rightSideX; x++)
            {
                up = centerY;
                down = centerY;
                while (!isWhite(b.GetPixel(x, up)))
                {
                    b.SetPixel(x, up, Color.Indigo);
                    up++;
                }
                while (!isWhite(b.GetPixel(x, down)))
                {
                    b.SetPixel(x, down, Color.Indigo);
                    down--;
                }
            }
            drawCenter(b, Color.White);
        }
    }

    }
