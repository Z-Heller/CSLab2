using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szkola
{
    class Nauczyciel : Uczen
    {
        public String TytulNaukowy;
        public List<Uczen> PodwladniUczniowie = new List<Uczen>();

        public void SetTytulNaukowy(String tytul)
        {
            this.TytulNaukowy = tytul;
        }

        public new void SetSchool(String school)
        {
            this.szkola = school;
        }

        public new void ChangeSchool(String school)
        {
            this.szkola = school;
        }

        public new void SetCanGoHomeAlone(Boolean can)
        {
            this.MozeSamWracacDoDomu = can;
        }

        public override void CanGoAloneToHome()
        {
            if (this.GetAge(DateTime.Now) > 11) MozeSamWracacDoDomu = true;
            else MozeSamWracacDoDomu = false;
        }

        public override int GetAge(DateTime data)
        {
            int rok = int.Parse(pesel.ElementAt(0) + pesel.ElementAt(1).ToString());
            int wiek = 0;
            if (rok < data.Year % 100) wiek = data.Year % 100 - rok;
            else wiek = data.Year - (1900 + rok);
            return wiek;
        }

        public override void GetEducationInfo()
        {
            Console.WriteLine("Szkoła: " + szkola);
        }

        public override void GetFullName()
        {
            Console.WriteLine("Imię i nazwisko: " + imie + " " + nazwisko);
        }

        public override void GetGender()
        {
            Console.Write("Płeć: ");
            int plec = (int)pesel.ElementAt(9);
            if (plec % 2 == 0) Console.Write("K\n");
            else Console.Write("M\n");
        }

        public override void SetFirstName(String im)
        {
            this.imie = im;
        }

        public override void SetLastName(String naz)
        {
            this.nazwisko = naz;
        }

        public override void SetPesel(String pes)
        {
            this.pesel = pes;
        }

        public new void info()
        {
            this.GetFullName();
            Console.WriteLine("Tytuł naukowy: " + this.TytulNaukowy);
            this.GetGender();
            Console.WriteLine("Wiek: " + this.GetAge(DateTime.Now));
            this.GetEducationInfo();

        }

        public void ListaUczniow()
        {
            Console.Write("Podwładni uczniowie: ");
            for (int i = 0; i < this.PodwladniUczniowie.Count; i++)
            {
                Console.WriteLine("\n" + (i + 1) + ".");
                PodwladniUczniowie[i].info();
            }
        }


        public void WhichStudentCanGoHomeAlone(DateTime dateToCheck)
        {
            Console.Write("Podwładni uczniowie, którzy ze względu na wiek mogą iść sami do domu: \n");
            for (int i = 0; i < this.PodwladniUczniowie.Count; i++)
            {
                if (PodwladniUczniowie[i].GetAge(dateToCheck) > 11)
                {
                    Console.Write((i + 1) + ". ");
                    PodwladniUczniowie[i].GetFullName();
                }
            }
        }
    }
}
