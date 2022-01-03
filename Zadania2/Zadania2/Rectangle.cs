using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadania2
{
    class Rectangle : Shape
    {
        public override void Draw()
        {
            base.Draw();
            Console.Write("prostokąt\n");
        }
    }
}
