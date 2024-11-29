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
        public static void Line(Vector4 x, Vector4 y, Bitmap bitmap, Color color)
        {
            
            int width = bitmap.Width;
            int height = bitmap.Height;


            Vector4 X = x;
            Vector4 Y = y;

            int x1 = (int)X[0];
            int x2 = (int)Y[0];
            int y1 = (int)X[1];
            int y2 = (int)Y[1];

            

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
                if (x1 >= 0 && x1 < width && y1 >= 0 && y1 < height) bitmap.SetPixel(x1, y1, color);

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

        public static void Triangle(Vector4 x, Vector4 y, Vector4 z, Bitmap bitmap, Color color)
        {
            Line(x, y, bitmap, color);
            Line(x, z, bitmap, color);
            Line(y, z, bitmap, color);


            /*Vector3 edge1 = (Vector3)y - (Vector3)x;
            Vector3 edge2 = (Vector3)z + (Vector3)x;
            Vector3 normal = Vector3.CrossProduct(edge1, edge2);

            normal = Vector3.Normalize(normal);

            double brightness = Vector3.CalculateBrightness(new Vector3(-100, -1000, 1000), normal);

            FillTriangle(x, y, z, bitmap, Color.FromArgb( (int)(200 *Math.Abs( Math.Cos(brightness))), (int)(200 * Math.Abs(Math.Cos(brightness))), (int)(200 * Math.Abs(Math.Cos(brightness)))));*/
        }

        public static void FillTriangle(Vector4 v1, Vector4 v2, Vector4 v3, Bitmap bitmap, Color color)
        {
            if (v2[1] < v1[1]) (v1, v2) = (v2, v1);
            if (v3[1] < v1[1]) (v1, v3) = (v3, v1);
            if (v3[1] < v2[1]) (v2, v3) = (v3, v2);

            int x1 = (int)v1[0], y1 = (int)v1[1];
            int x2 = (int)v2[0], y2 = (int)v2[1];
            int x3 = (int)v3[0], y3 = (int)v3[1];

            if (y2 == y3) 
            {
                FillFlatBottomTriangle(x1, y1, x2, y2, x3, y3, bitmap, color);
            }
            else if (y1 == y2) 
            {
                FillFlatTopTriangle(x1, y1, x2, y2, x3, y3, bitmap, color);
            }
            else 
            {
                int splitX = (int)(x1 + ((double)(y2 - y1) / (y3 - y1)) * (x3 - x1));
                int splitY = y2;

                FillFlatBottomTriangle(x1, y1, x2, y2, splitX, splitY, bitmap, color);
                FillFlatTopTriangle(x2, y2, splitX, splitY, x3, y3, bitmap, color);
            }
        }

        private static void FillFlatBottomTriangle(int x1, int y1, int x2, int y2, int x3, int y3, Bitmap bitmap, Color color)
        {
            double invslope1 = (double)(x2 - x1) / (y2 - y1);
            double invslope2 = (double)(x3 - x1) / (y3 - y1);

            double curx1 = x1;
            double curx2 = x1;

            for (int scanlineY = y1; scanlineY <= y2; scanlineY++)
            {
                DrawScanline((int)curx1, (int)curx2, scanlineY, bitmap, color);
                curx1 += invslope1;
                curx2 += invslope2;
            }
        }

        private static void FillFlatTopTriangle(int x1, int y1, int x2, int y2, int x3, int y3, Bitmap bitmap, Color color)
        {
            double invslope1 = (double)(x3 - x1) / (y3 - y1);
            double invslope2 = (double)(x3 - x2) / (y3 - y2);

            double curx1 = x3;
            double curx2 = x3;

            for (int scanlineY = y3; scanlineY >= y1; scanlineY--)
            {
                DrawScanline((int)curx1, (int)curx2, scanlineY, bitmap, color);
                curx1 -= invslope1;
                curx2 -= invslope2;
            }
        }

        private static void DrawScanline(int x1, int x2, int y, Bitmap bitmap, Color color)
        {
            if (x1 > x2) (x1, x2) = (x2, x1); 

            for (int x = x1; x <= x2; x++)
            {
                if (x >= 0 && x < bitmap.Width && y >= 0 && y < bitmap.Height)
                {
                    bitmap.SetPixel(x, y, color);
                }
            }
        }
    }
}
