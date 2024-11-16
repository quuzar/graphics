using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace graphics_engine
{
    internal class Vector4:Vector
    {
        public Vector4() : base() { }
        public Vector4(double x = 0, double y = 0, double z = 0, double w = 0):base(x, y)
        {
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
                return new Vector4(1f, 1f, 1f, 1f);
            }
        }

        public static implicit operator Vector3(Vector4 _)
        {
            return new Vector3(_[0], _[1], _[2]);
        }

        public static implicit operator Vector4(double _)
        {
            return new Vector4(_, _, _, 1);
        }

        new public double this[int i]
        {
            get
            {
                switch (i)
                {
                    case 0: return x;
                    case 1: return y;
                    case 2: return z;
                    case 3: return w;
                    default: return 0;
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
                }
            }
        }
    }
}
