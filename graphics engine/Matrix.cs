using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace graphics_engine
{
    internal class Matrix
    {
        public static Vector4 Mult(Vector4 a, double[,] matrix)
        {
            double x, y, z, w;
            x = (matrix[0, 0] * a[0]) + (matrix[0, 1] * a[1]) + (matrix[0, 2] * a[2]) + (matrix[0, 3] * a[3]);
            y = (matrix[1, 0] * a[0]) + (matrix[1, 1] * a[1]) + (matrix[1, 2] * a[2]) + (matrix[1, 3] * a[3]);
            z = (matrix[2, 0] * a[0]) + (matrix[2, 1] * a[1]) + (matrix[2, 2] * a[2]) + (matrix[2, 3] * a[3]);
            w = (matrix[3, 0] * a[0]) + (matrix[3, 1] * a[1]) + (matrix[3, 2] * a[2]) + (matrix[3, 3] * a[3]);
            return new Vector4( x, y, z, w );
        }

        public static Vector4 Translate(Vector4 a, Vector4 b)
        {
            double[,] TranslateMatrix = new double[,]
            {
                {1, 0, 0, b[0] },
                {0, 1, 0, b[1] },
                {0, 0, 1, b[2] },
                {0, 0, 0, 1 }
            };       

            Vector4 c = Mult(a, TranslateMatrix);
            return c;
        }

        public static Vector4 Scale(Vector4 a, Vector4 b)
        {
            double[,] ScaleMatrix = new double[4, 4]
            {
                {b[0], 0, 0, 0 },
                {0, b[1], 0, 0 },
                {0, 0, b[2], 0 },
                {0, 0, 0, 1 }
            };

            return Mult(a, ScaleMatrix);
        }

        public static Vector4 RotationX(Vector4 a, double x)
        {
            double[,] RotationXMatrix = new double[4, 4]
            {
                {1, 0, 0, 0 },
                {0, Math.Cos(x), -1 * Math.Sin(x), 0 },
                {0, Math.Sin(x), Math.Cos(x), 0 },
                {0, 0, 0, 1 }
            };

            return Mult(a, RotationXMatrix);
        }

        public static Vector4 RotationY(Vector4 a, double y)
        {
            double[,] RotationYMatrix = new double[4, 4]
            {
                {Math.Cos(y), 0, Math.Sin(y), 0 },
                {0, 1, 0, 0 },
                {-1 * Math.Sin(y), 0, Math.Cos(y), 0 },
                {0, 0, 0, 1 }
            };

            return Mult(a, RotationYMatrix);
        }

        public static Vector4 RotationZ(Vector4 a, double z)
        {
            double[,] RotationZMatrix = new double[4, 4]
            {
                { Math.Cos(z), -1 * Math.Sin(z), 0, 0 },
                {Math.Sin(z), Math.Cos(z), 0, 0 },
                {0, 0, 1, 0 },
                {0, 0, 0, 1 }
            };

            return Mult(a, RotationZMatrix);
        }

        public static Vector4 Perspective(Vector4 a)
        {
            double fov = 90;
            double aspect = 4 / 3;
            double near = 0.1;
            double far = 10.0;

            fov = fov * Math.PI / 180.0;

            double f = 1.0 / Math.Tan(fov / 2.0);
            double depth = far - near;

            double[,] PerspectiveMatrix = new double[4, 4]
            {
                { f / aspect, 0,         0,                              0 },
                { 0,          f,         0,                              0 },
                { 0,          0,         (far + near) / depth,           2 * far * near / depth },
                { 0,          0,         -1,                             0 }
            };

            a[3] = 1; 

            var b = Mult(a, PerspectiveMatrix);

            /*if (b[3] != 0)
            {
                b[0] /= b[3];
                b[1] /= b[3];
                b[2] /= b[3];
            }*/

            return b;
        }
        public static Vector4 Rotation(Vector4 _, Vector3 r)
        {
            return RotationX(RotationY(RotationZ(_, r[2]), r[1]), r[0]);
        }
    }
}
