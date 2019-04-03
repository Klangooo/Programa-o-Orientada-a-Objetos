using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Vetor2D
    {
        private double x;
        private double y;

        public Vetor2D()
        {
            x = 0;
            y = 0;
        }

        public Vetor2D(double X, double Y)
        {
            x = X;
            y = Y;
        }

        public double comprimento()
        {
            return Math.Sqrt(Math.Pow(X, 2) + Math.Pow(Y, 2));
        }

        public double X
        {
            get { return x; }
            set { x = value; }
        }

        public double Y
        {
            get { return y; }
            set { y = value; }
        }
    }
}
