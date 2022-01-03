using System;
using System.Collections.Generic;

namespace Zadania2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shape> Lista = new List<Shape>();

            Rectangle prost = new Rectangle();
            Triangle troj = new Triangle();
            Circle kol = new Circle();

            Lista.Add(prost);
            Lista.Add(troj);
            Lista.Add(kol);

            for(int i=0; i<Lista.Count; i++)
            {
                Lista[i].Draw();
            }
        }
    }
}
