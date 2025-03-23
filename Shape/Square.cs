using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape
{
    internal class Square : Rectangle
    {
        public Square(double heigth, double width, string color) : base(heigth, width, color)
        {
            
        }

        public Square(double heigth, double width, bool isHoley, string color) : base(heigth, width, isHoley, color)
        {
        }

        public double Heigth { get => Width; set => Width = value; }
        public double Width { get => Heigth; set => Heigth = value; }

        public override string ToString()
        {
            return $"Négyzet:\n{base.ToString()}";
        }
    }
}
