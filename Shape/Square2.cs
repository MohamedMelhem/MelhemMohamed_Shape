using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape
{
    internal class Square2 : Shape
    {
        double heigthwidth;
        public Square2(double heigthwidth,string color) : base(color)
        {
            this.heigthwidth = heigthwidth;
        }

        public Square2(double heigthwidth,bool isHoley, string color) : base(isHoley, color)
        
        {

            this.heigthwidth=heigthwidth;
        }

        public double Heigthwidth { get => heigthwidth; set => heigthwidth = value; }

        public override double Area()
        {
            return heigthwidth* heigthwidth;
        }

        public override double Perimeter()
        {
            
            return heigthwidth*4;
        }

        public override string? ToString()
        {
            return $"Négyzet :\n{base.ToString()}";
        }
    }
}
