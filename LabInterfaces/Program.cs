using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabInterfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter radius");
            var radius = int.Parse(Console.ReadLine());

            IDrawable circle = new Circle(radius);
            circle.Draw();


            Console.WriteLine("enter rec width");
            var width = int.Parse(Console.ReadLine());
            Console.WriteLine("enter rec hieght");
            var height = int.Parse(Console.ReadLine());

            IDrawable rect = new Rectangle(width, height);

            rect.Draw();

            Console.ReadLine();
        }
    }
}
