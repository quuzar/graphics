using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace graphics_engine
{
    class Vector
    {
        public Vector()
        {
            x = 0;
            y = 0;
        }
        public Vector(double x=0, double y=0):this()
        {
            this.x = x;
            this.y = y;
        }

        protected double x;
        protected double y;

        public double[] Point()
        {
            try
            {
                return new[] { x, y };
            }
            catch
            {
                ErrorString.Input("ERROR: Class->Vector [Double x, Double y не существуют в данном объекте]");
                return new[] { 0d, 0d };
            }
        }

        public Vector Clone()
        {
            try
            {
                return new Vector(x, y);
            }
            catch
            {
                ErrorString.Input("ERROR: Class->Vector [не удалось создать новый Vector при помощи функции Clone()]");
                return new Vector(1f, 1f);
            }
        } 

        public static explicit operator Vector(double _)
        {
            try
            {
                return new Vector(_, _);
            }
            catch
            {
                ErrorString.Input("ERROR: Class->Vector [не удалось создать новый Vector при помощи переменной Double]");
                return new Vector(0f, 0f);
            }
        }

        public virtual double this[int i]
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
                    default: 
                        return;
                }
            }
        }
    }
}