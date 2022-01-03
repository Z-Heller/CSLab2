using System;

namespace Szkola
{
    class Program
    {
        static void Main(string[] args)
        {
            Uczen ucz1 = new Uczen();
            Console.WriteLine("Uczeń 1: ");

            ucz1.SetFirstName("Adam");
            ucz1.SetLastName("Kowalski");
            ucz1.SetPesel("06290578796");
            ucz1.SetSchool("Szkoła podstawowa nr 1");
            ucz1.CanGoAloneToHome();

            ucz1.info();


            Uczen ucz2 = new Uczen();
            Console.WriteLine("\n\nUczeń 2: ");

            ucz2.SetFirstName("Anna");
            ucz2.SetLastName("Nowak");
            ucz2.SetPesel("11212172185");
            ucz2.SetSchool("Szkoła podstawowa nr 1");
            ucz2.CanGoAloneToHome();

            ucz2.info();

            Console.WriteLine("\n\nUczeń 2 po udzieleniu pozwolenia: ");
            ucz2.SetCanGoHomeAlone(true);

            ucz2.info();

            Nauczyciel nau = new Nauczyciel();
            Console.WriteLine("\n\nNauczyciel: ");

            nau.SetFirstName("Magdalena");
            nau.SetLastName("Lis");
            nau.SetPesel("75031423267");
            nau.SetSchool("Szkoła podstawowa nr 1");
            nau.SetTytulNaukowy("Mgr");

            nau.info();

            nau.PodwladniUczniowie.Add(ucz1);
            nau.PodwladniUczniowie.Add(ucz2);

            Console.WriteLine("\n");
            nau.ListaUczniow();

            Console.WriteLine("\n");

            nau.WhichStudentCanGoHomeAlone(DateTime.Now);
        }
    }
}
