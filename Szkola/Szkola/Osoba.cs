using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szkola
{
    abstract class Osoba
    {
        protected String imie;
        protected String nazwisko;
        protected String pesel;

        public abstract void SetFirstName(String im);
        public abstract void SetLastName(String naz);
        public abstract void SetPesel(String pes);
        public abstract int GetAge(DateTime data);
        public abstract void GetGender();

        public abstract void GetEducationInfo();
        public abstract void GetFullName();
        public abstract void CanGoAloneToHome();

    }
}
