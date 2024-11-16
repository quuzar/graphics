using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace graphics_engine
{
    internal class Vector3 : Vector
    {
        public Vector3() : base() { }
        public Vector3(double x = 0, double y = 0, double z = 0) : base(x, y)
        {
            this.z = z;
        }

        protected double z;

        new public Vector3 Clone() 
        {
            try
            {
                return new Vector3(x, y, z);
            }
            catch
            {
                return new Vector3(1f, 1f, 1f);
            }
        }

        public static implicit operator Vector4(Vector3 _)
        {
            return new Vector4(_[0], _[1], _[2], 1);
        }

        public static implicit operator Vector3(double _)
        {
            return new Vector3(_, _, _);
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
                    default: return 0;
                }
            }
            set
            {
                switch (i)
                {
                    case 0: this.x = value; break;
                    case 1: this.y = value; break;
                    case 2: this.z = value; break;
                }
            }
        }
    }
}
