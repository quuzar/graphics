using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace graphics_engine
{
    class Vector4:Vector
    {
        public Vector4() : base() 
        {
            z = 0;
            w = 1;
        }
        public Vector4(double x = 0, double y = 0, double z = 0, double w = 1) 
        {
            this.x = x;
            this.y = y;
            this.z = z;
            this.w = w;
        }

        protected double z;
        protected double w;

        new public Vector4 Clone()
        {
            try
            {
                return new Vector4(x, y, z, w);
            }
            catch
            {
                ErrorString.Input("ERROR: Class->Vector4 [не удалось создать Vector4 с помощью Clone()]");
                return new Vector4(1f, 1f, 1f, 1f);
            }
        }

        public static explicit operator Vector3(Vector4 _)
        {
            try
            {
                return new Vector3(_[0], _[1], _[2]);
            }
            catch
            {
                ErrorString.Input("ERROR: Class->Vector4 [передан пустой Vector4 для преобразования в Vector3]");
                return new Vector3(0d, 0d, 0d);
            }
        }

        public static explicit operator Vector4(double _)
        {
            try
            {
                return new Vector4(_, _, _, 1);
            }
            catch
            {
                ErrorString.Input("ERROR: Class->Vector4 [не удалось создать Vector4 с помощью переменной Double]");
                return new Vector4(0, 0, 0, 1);
            }
        }

        public static Vector4 operator +(Vector4 v1, Vector4 v2)
        {
            try
            {
                return new Vector4(v1[0] + v2[0], v1[1] + v2[1], v1[2] + v2[2], 1);
            }
            catch
            {
                ErrorString.Input("ERROR: Class->Vector4 [не удалось сложить два объекта Vector4]");
                return new Vector4(0, 0, 0, 1);
            }
        }

        public static Vector4 operator -(Vector4 v1, Vector4 v2)
        {
            try
            {
                return new Vector4(v1[0] - v2[0], v1[1] - v2[1], v1[2] - v2[2]);
            }
            catch
            {
                ErrorString.Input("ERROR: Class->Vector4 [не удалось вычесть два объекта Vector4]");
                return new Vector4(0, 0, 0, 1);
            }
        }

        public static bool operator ==(Vector4 v1, Vector4 v2)
        {
            try
            {
                return v1[0] == v2[0] && v1[1] == v2[1] && v1[2] == v2[2];
            }
            catch
            {
                ErrorString.Input("ERROR: Class->Vector4 [не удалось сравнить два объекта Vector4 ==");
                return false;
            }
        }

        public static bool operator !=(Vector4 v1, Vector4 v2)
        {
            try
            {
                return v1[0] != v2[0] && v1[1] != v2[1] && v1[2] != v2[2];
            }
            catch
            {
                ErrorString.Input("ERROR: Class->Vector4 [не удалось сравнить два объекта Vector4 !=");
                return false;
            }
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
                    case 3: return w;
                    default:
                        ErrorString.Input("ERROR: Class->Vector4 [неправильный индекс для получения значений]");
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
                    case 3: w = value; break;
                    default:
                        ErrorString.Input("ERROR: Class->Vector3 [неправильный индекс для записи значений]");
                        break;
                }
            }
        }
    }
}