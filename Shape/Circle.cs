using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape
{
    internal class Circle : Shape
    {
        double r;
        public Circle(double r,string color) : base(color)
        {
            this.r = r;
        }

        public Circle(double r,bool isHoley, string color) : base(isHoley, color)
        {
            this.r = r;
        }


        public double R { get => r; set => r = value; }

        public override double Area()
        {
            return Math.PI * Math.Pow(r,2);
        }

        public override double Perimeter()
        {
            return 2 * Math.PI* r;
        }
    }
}
