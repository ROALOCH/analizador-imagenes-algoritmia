using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iP_Etapa2
{
    public class Circle
    {
        private int iD;
        private int upperY, lowestY, leftSideX, rightSideX;
        private int radiusH, radiusV, sizeX, sizeY;
        private Point center;

        public Circle(int cx, int cy, int uy, int ly, int lsx, int rsx, int id)
        {
            iD = id;
            center.X = cx;
            center.Y = cy;
            upperY = uy;
            lowestY = ly;
            leftSideX = lsx;
            rightSideX = rsx;
            radiusH = rsx - cx;
            radiusV = ly - cy;
            sizeX = rsx - lsx;
            sizeY = ly - uy;
        }

        public int getID() => iD;
        public int getRadius() => radiusH;
        public Point getCenter() => center;
        public string showInfo() => "Círculo N. " + iD + ", Centro (" + center.X + ", " + center.Y + "), Radio: " + radiusH + " pixeles"; 
        public bool isCircle() => (((radiusV - radiusH) <= 10) && ((radiusV - radiusH) >= -10));
        public static bool operator >(Circle a, Circle b) => a.getRadius() > b.getRadius();
        public static bool operator <(Circle a, Circle b) => a.getRadius() < b.getRadius();
        private bool isWhite(Color c)
        {
            if (c.R == 255)
                if (c.G == 255)
                    if (c.B == 255)
                        return true;
            return false;
        }
        public bool eraseShape(Bitmap b)
        {
            int up;
            int down;
            bool flag = false;

            for(int x = leftSideX - 5; x <= rightSideX + 5; x++)
            {
                up = center.Y;
                down = center.Y;
                while(!isWhite(b.GetPixel(x, up)))
                {
                    if (isCircle())
                        b.SetPixel(x, up, Color.Magenta);
                    else
                    {
                        flag = true;
                        b.SetPixel(x, up, Color.Snow);
                    }
                    up++;
                }
                while(!isWhite(b.GetPixel(x, down)))
                {
                    if (isCircle())
                        b.SetPixel(x, down, Color.Magenta);
                    else
                        b.SetPixel(x, down, Color.Snow);
                    down--;
                }
            }
            drawCenter(b, Color.White);
            return flag;
        }
        public void drawCenter(Bitmap b, Color c)
        {
            for(int i = -3; i <= 3; i++)
            {
                b.SetPixel(center.X - i, center.Y, c);
                b.SetPixel(center.X, center.Y - i, c);
            }
        }
        public void highlightShape(Bitmap b, Color cir, Color ctr)
        {
            int up;
            int down;
            for(int x = leftSideX - 5; x <= rightSideX + 5; x++)
            {
                up = center.Y;
                down = center.Y;
                while(!isWhite(b.GetPixel(x, up)))
                {
                    b.SetPixel(x, up, cir);
                    up--;
                }
                while(!isWhite(b.GetPixel(x, down)))
                {
                    b.SetPixel(x, down, cir);
                    down++;
                }
            }
            drawCenter(b, ctr);
        }
    }
}
