using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace graphics_engine
{
    class Vector3 : Vector
    {
        public Vector3() : base() 
        {
            z = 0;
        }
        public Vector3(double x = 0, double y = 0, double z = 0)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        new protected double x;
        new protected double y;
        protected double z;

        new public Vector3 Clone() 
        {
            try
            {
                return new Vector3(x, y, z);
            }
            catch
            {
                ErrorString.Input("ERROR: Class->Vector3 [не удалось создать новый Vector3 при помощи функции Clone()]");
                return new Vector3(1f, 1f, 1f);
            }
        }

        public static Vector3 Normalize(Vector3 v)
        {
            double length = Math.Sqrt(v[0] * v[0] + v[1] * v[1] + v[2] * v[2]);
            if (length == 0) return new Vector3(0, 0, 0);
            return v / length;
        }

        public static double DotProduct(Vector3 v1, Vector3 v2)
        {
            return v1[0] * v2[0] + v1[1] * v2[1] + v1[2] * v2[2];
        }

        public static double CalculateBrightness(Vector3 lightDirection, Vector3 surfaceNormal)
        {

            Vector3 lightDirNormalized = Normalize(lightDirection);
            Vector3 normalNormalized = Normalize(surfaceNormal);

            double cosTheta = DotProduct(lightDirNormalized, normalNormalized);

            return Math.Max(0, cosTheta);
        }

        public static explicit operator Vector4(Vector3 _)
        {
            try
            {
                return new Vector4(_[0], _[1], _[2], 1);
            }
            catch
            {
                ErrorString.Input("ERROR: Class->Vector3 [передан пустой объект Vectot3 для преобразования в Vector4]");
                return new Vector4(0d, 0d, 0d, 0d);
            }
        }

        public static explicit operator Vector3(double _)
        {
            try
            {
                return new Vector3(_, _, _);
            }
            catch
            {
                ErrorString.Input("ERROR: Class->Vector3 [не удалось создать новый объект Vector3 при помощи переменной Double]");
                return new Vector3(0d, 0d, 0d);
            }
        }

        public static Vector3 operator +(Vector3 v1, Vector3 v2)
        {
            try
            {
                return new Vector3(v1[0] + v2[0], v1[1] + v2[1], v1[2] + v2[2]);
            }
            catch
            {
                ErrorString.Input("ERROR: Class->Vector3 [не удалось сложить два объекта Vector3]");
                return new Vector3(0d, 0d, 0d);
            }
        }

        public static Vector3 operator -(Vector3 v1, Vector3 v2)
        {
            try
            {
                return new Vector3(v1[0] - v2[0], v1[1] - v2[1], v1[2] - v2[2]);
            }
            catch
            {
                ErrorString.Input("ERROR: Class->Vector3 [не удалось вычисть два объекта Vector3]");
                return new Vector3(0d, 0d, 0d);
            }
        }

        public static Vector3 operator /(Vector3 v1, double _)
        {
            try
            {
                return new Vector3(v1[0] / _, v1[1] / _, v1[2] / _);
            }
            catch
            {
                ErrorString.Input("ERROR: Class->Vector3 [не удалось разделить объект Vector3 на double]");
                return new Vector3(0d, 0d, 0d);
            }
        }

        public static Vector3 operator *(Vector3 v1, double _)
        {
            try
            {
                return new Vector3(v1[0] * _, v1[1] * _, v1[2] * _);
            }
            catch
            {
                ErrorString.Input("ERROR: Class->Vector3 [не удалось умножить объект Vector3 на double]");
                return new Vector3(0d, 0d, 0d);
            }
        }

        public static Vector3 CrossProduct(Vector3 v1, Vector3 v2)
        {
            double x = v1[1] * v2[2] - v1[2] * v2[1];
            double y = v1[2] * v2[0] - v1[0] * v2[2];
            double z = v1[0] * v2[1] - v1[1] * v2[0];

            return new Vector3(x, y, z);
        }

        public override double this[int i]
        {
            get 
            {
                switch (i)
                {
                    case 0: return x; 
                    case 1: return y; 
                    case 2: return z;
                    default:
                        ErrorString.Input("ERROR: Class->Vector3 [неправильный индекс для получения значений]");
                        return 0;
                }
            }
            set
            {
                switch (i)
                {
                    case 0: x = value; break;
                    case 1: y = value; break;
                    case 2: z = value; break;
                    default:
                        ErrorString.Input("ERROR: Class->Vector3 [неправильный индекс для записи значений]");
                        break;
                }
            }
        }
    }
}
