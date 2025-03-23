using System.Security.Cryptography.X509Certificates;

namespace Shape
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Shape[] shapes = new Shape[5];

            shapes[0] = new Rectangle(5, 4, "red");
            shapes[1] = new Circle(5, "blue");
            shapes[2] = new Square2(4.5, "yellow");
            shapes[3] = new Rectangle(1, 2, "black");
            shapes[4] = new Circle(3, "white");

            Kilyukaszt(shapes[1]);
            Console.WriteLine(shapes[1].ToString());
            Shape letrehoz1 = Letrehoz(2, 2, "green");
            Console.WriteLine(letrehoz1.ToString());
            Console.WriteLine(Legnagyobb(shapes));

            

        }
        static void Kilyukaszt(Shape shape)
        {
            if (shape.Area() > shape.Perimeter())
            {
                shape.MakeHoley();
            }
        }
        static Shape Letrehoz(double heigth, double width,string color)
        {
            Shape shape = null;
            
            if (heigth == width)
            {
                shape = new Square2(heigth, color);
            }
            else { 
             shape = new Rectangle(heigth,width,color);
            }
            return shape;


        }
        static Shape Legnagyobb(Shape[] shape) 
        {
            int index = 0;
            for (int i = 0; i < shape.Length; i++)
            {
                if (shape[index].Area() < shape[i].Area())
                {
                    index = i;
                }
                
            }
            return shape[index];

        }
        
    }
}
