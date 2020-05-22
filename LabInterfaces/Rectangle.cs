using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabInterfaces
{
    class Rectangle : IDrawable
    {
        public Rectangle(int width, int height)
        {
            Width = width;
            Height = height;
        }

        public int Width { get; set; }
        public int Height { get; set; }

        public void Draw()
        {
            var star = '*';
            var spc = ' ';
            DrawLine(this.Width, star, star);//width ==4 the line look like this "****"
            for (int i=1; i<this.Height-1; i++ )//hight == 4 draw 3 lines
            {
                Console.WriteLine("");
                DrawLine(this.Width, spc, star);//width ==4  the line looks like this " ** "
            }
            Console.WriteLine("");
            DrawLine(this.Width, star, star);//width ==4 the line look like this "****"
        }
        private void DrawLine(int width, char end, char mid)
        {
            Console.Write(end);
            for (int i = 1; i < width - 1; i++)
            {
                Console.Write(mid);
            }
            Console.Write(end);
        }
    }
}
