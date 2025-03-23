using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape
{
    internal class Rectangle : Shape
    {
        double heigth;
        double width;

        public Rectangle(double heigth,double width,string color) : base(color)
        {
            this.heigth = heigth;
            this.width = width;
            
        }

        public Rectangle(double heigth, double width, bool isHoley, string color) : base(isHoley, color)
        {
            this.heigth = heigth;
            this.width = width;
            
        }

        public double Heigth { get => heigth; set => heigth = value; }
        public double Width { get => width; set => width = value; }

        public override double Area()
        {
            return heigth * width;
            
        }

        public override double Perimeter()
        {
           return 2*(heigth + width);
        }

        public override string ToString()
        {
            return $"Téglalap:\n {base.ToString()}";
        }
    }
}
