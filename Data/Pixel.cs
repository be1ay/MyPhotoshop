using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPhotoshop
{
    public struct Pixel
    {
        public Pixel (double r, double g, double b):this()
        {
            R = r;
            G = g;
            B = b;
        }
        public static Pixel operator* (Pixel p, double x)
        {
            return new Pixel(Trim(p.R*x),Trim(p.G*x),Trim(p.B*x));
        }
        public static Pixel operator *(double x, Pixel p)
        {
            return p * x;
        }

            public static double Trim(double value)
        {
            if(value < 0) return 0;
            if (value > 1) return 1;
            return value;
        }
        double CheckValue(double value)
        {
            if(value < 0 || value > 1) throw new ArgumentException();
            else return value;
        }
        double r;
        public double R
        {
            get { return r; }
            set { r = CheckValue(value); }
        }

        double g;
        public double G
        {
            get { return g; }
            set { g = CheckValue(value); }
        }
        double b;
        public double B
        {
            get { return b; }
            set { b = CheckValue(value); }
        }
    }
}
