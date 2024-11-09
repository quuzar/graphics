using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace graphics_engine
{
    internal class Vector
    {
        public Vector(double x=0, double y=0)
        {
            this.x = x;
            this.y = y;
        }
        protected double x;
        protected double y;

        public double[] Point() => new[] { x, y };

        public virtual Vector Clone(double x, double y) => new Vector(x, y);
    }
}
