using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape
{
    internal abstract class Shape
    {
        bool isHoley;
        string color;

        protected Shape(bool isHoley, string color)
        {
            this.isHoley = isHoley;
            this.color = color;
        }

        protected Shape(string color)
        {
            this.color = color;
            isHoley = false;
        }

        public string Color { get => color; set => color = value; }

        public void MakeHoley()
        {
            this.isHoley = true;

        }


        public abstract double Perimeter();
        public abstract double Area();

        public override string? ToString()
        {
            return $" Szin : {color}\n Lyukas-e? : {isHoley} \n Kerület {Perimeter()}\nTerület: {Area()}";
        }

    }
}
