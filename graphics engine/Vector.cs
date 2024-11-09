using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace graphics_engine
{
    internal class Vector
    {
        public Vector()
        {
            this.x = 0;
            this.y = 0;
        }
        public Vector(double x=0, double y=0):base()
        {
            this.x = x;
            this.y = y;
        }

        protected double x;
        protected double y;

        public double[] Point() => new[] { x, y };

        /// <summary>
        /// Клонирует объект Vector
        /// </summary>
        public Vector Clone()
        {
            try
            {
                return new Vector(x, y);
            }
            catch
            {
                return new Vector(1f, 1f);
            }
        }

        public static implicit operator Vector(double _)
        {
            return new Vector(_, _);
        }

        public double this[int i]
        {
            get
            {
                switch(i)
                {
                    case 0: return x;
                    case 1: return y;
                    default: return 0;
                }
            }
            set
            {
                switch (i)
                {
                    case 0: 
                        x = value; 
                        break;
                    case 1: 
                        y = value; 
                        break;
                }
            }
        }
    }
}