using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatModelPlanets
{
    public struct Vector
    {
        public double X;
        public double Y;

        public static Vector ortX = new Vector(1, 0);
        public static Vector ortY = new Vector(0, 1);

        public Vector(double x, double y)
        {
            X = x;
            Y = y;
        }

        public static Vector DotProduct(Vector v1, Vector v2)
        {
            return new Vector(v1.X * v2.X, v1.Y * v2.Y);
        }

        public double Abs()
        {
            return Math.Sqrt(this.X * this.X + this.Y * this.Y);
        }

        public double Cos()
        {
            double cos = Math.Abs(this.X * ortX.X + this.Y * ortX.Y) / (this.Abs() * ortX.Abs());
            if (this.X > 0)
            {
                return cos;
            }
            else
            {
                return -cos;
            }
        }

        public double Sin()
        {
            double sin = Math.Sqrt(1 - Math.Pow(this.Cos(), 2));

            if (this.Y > 0)
            {
                return sin;
            }
            else
            {
                return -sin;
            }
        }
    }
}
