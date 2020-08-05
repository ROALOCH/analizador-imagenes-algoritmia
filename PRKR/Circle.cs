using System.Drawing;

namespace R
{
    public class Circle
    {
        Point center;
        int iD, upperY, lowestY, leftSideX, rightSideX, radiusH, radiusV, sizeX, sizeY;
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
        public int getRadius()
        {
            if (radiusH > radiusV)
                return radiusH;
            return radiusV;
        }
        public Point getCenter() => center;
        public bool isCircle() => (((radiusV - radiusH) <= 10) && ((radiusV - radiusH) >= -10));
        private bool isWhite(Color c)
        {
            if (c.R == 255)
                if (c.G == 255)
                    if (c.B == 255)
                        return true;
            return false;
        }
        public bool eraseShape(Bitmap sD, Bitmap bmp)
        {
            int up, down;
            bool flag = false;

            for (int x = leftSideX - 5; x <= rightSideX + 5; x++)
            {
                up = center.Y;
                down = center.Y;

                while (!isWhite(sD.GetPixel(x, up)))
                {
                    if (isCircle())
                        sD.SetPixel(x, up, Color.Magenta);
                    else
                    {
                        flag = true;
                        sD.SetPixel(x, up, Color.Snow);
                        bmp.SetPixel(x, up, Color.Snow);
                    }
                    up++;
                }

                while (!isWhite(sD.GetPixel(x, down)))
                {
                    if (isCircle())
                        sD.SetPixel(x, down, Color.Magenta);
                    else
                    {
                        sD.SetPixel(x, down, Color.Snow);
                        bmp.SetPixel(x, down, Color.Snow);
                    }
                    down--;
                }
            }
            return flag;
        }
    }
}
