using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadania2
{
    class Shape
    {
        protected int X;
        protected int Y;
        protected int Height;
        protected int Width;

        public virtual void Draw()
        {
            Console.Write("Rysujemy figurę: ");
        }

    }
}
