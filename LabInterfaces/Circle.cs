using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabInterfaces
{
    class Circle : IDrawable
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            this.Radius = radius;
        }
        public void Draw()
        {
            double thickness = 0.4;
            ConsoleColor BorderColor = ConsoleColor.Red;
            Console.ForegroundColor = BorderColor;
            char symbol = '*';
            Console.WriteLine();
            double rIn = Radius - thickness, rOut = Radius + thickness;

            for (double y = this.Radius; y >= -this.Radius; --y)
            {
                for (double x = -this.Radius; x < rOut; x += 0.5)
                {
                    double value = x * x + y * y;
                    if (value >= rIn * rIn && value <= rOut * rOut)
                    {
                        Console.Write(symbol);
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}

