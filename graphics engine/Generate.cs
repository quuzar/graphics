using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace graphics_engine
{
    internal class Generate
    {
        public static void Line(Vector4 x, Vector4 y, Bitmap bitmap)
        {
            int width = bitmap.Width;
            int height = bitmap.Height;

            Vector4 X = Matrix.Perspective(x);
            Vector4 Y = Matrix.Perspective(y);
            int x1 = (int)x[0];
            int x2 = (int)y[0];
            int y1 = (int)x[1];
            int y2 = (int)y[1];

            

            int dx = (x2 - x1);
            int dy = (y2 - y1);

            if (dx < 0)
                dx *= -1;
            if (dy < 0)
                dy *= -1;
            int sx = x1 < x2 ? 1 : -1;
            int sy = y1 < y2 ? 1 : -1;
            int err = dx - dy;

            while (true)
            {
                if (x1 >= 0 && x1 < width && y1 >= 0 && y1 < height) bitmap.SetPixel(x1, y1, Color.Black);

                if (x1 == x2 && y1 == y2) break;

                int e2 = 2 * err;
                if (e2 > -dy)
                {
                    err -= dy;
                    x1 += sx;
                }
                if (e2 < dx)
                {
                    err += dx;
                    y1 += sy;
                }
            }
        }

        public static void Triangle(Vector4 x, Vector4 y, Vector4 z, Bitmap bitmap)
        {
            Line(x, y, bitmap);
            Line(y, z, bitmap);
            Line(z, x, bitmap);
        }
    }
}
