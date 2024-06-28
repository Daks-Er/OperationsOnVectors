using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperationsOnVectors
{
    class Vektor
    {
        public int X { get; private set; }
        public int Y { get; private set; }

        public Vektor(int X, int Y)
        {
            this.X = X;
            this.Y = Y;
        }
        public static Vektor operator +(Vektor a, Vektor b)
        {
            Vektor s = new Vektor(0, 0);
            s.X = a.X + b.X;
            s.Y = a.Y + b.Y;
            return s;
        }
        public static Vektor operator -(Vektor a, Vektor b)
        {
            Vektor s = new Vektor(0, 0);
            s.X = a.X - b.X;
            s.Y = a.Y - b.Y;
            return s;
        }
        public static Vektor operator *(Vektor a, int n)
        {
            Vektor s = new Vektor(0, 0);
            s.X = a.X * n;
            s.Y = a.Y * n;
            return s;
        }
        public static double operator /(Vektor a, Vektor b)
        {
            double c = a.X * b.X + a.Y * b.Y;
            double zn = Math.Sqrt(a.X * a.X + a.Y * a.Y) * Math.Sqrt(b.X * b.X + b.Y * b.Y);
            return c/zn;
        }
        public static double operator *(Vektor a, Vektor b)
        {
            return a.X*b.X+a.Y*b.Y;
        }
        public double Length()
        {
            return Math.Sqrt(X * X + Y * Y);
        }
        public static bool operator ==(Vektor a, Vektor b)
        {
            return (double)a.X / (double)b.X == (double)a.Y / (double)b.Y;
        }
        public static bool operator !=(Vektor a, Vektor b)
        {
            return !((double)a.X / (double)b.X == (double)a.Y / (double)b.Y);
        }
        public override string ToString()
        {
            return $"(" + X + ";" + Y + ")";
        }
    }
}
