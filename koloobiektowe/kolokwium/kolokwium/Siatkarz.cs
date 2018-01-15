using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kolokwium
{
    abstract class Siatkarz
    {
        protected string imie;
        protected string nazwisko;
        protected int numerNaKoszulce;

        public Siatkarz()
        {

        }

        public Siatkarz(string imie,string nazwisko,int numerNaKoszulce)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.numerNaKoszulce = numerNaKoszulce;
        }

        public override string ToString()
        {
            return imie + " " + nazwisko + " " + numerNaKoszulce;
        }
    }
}
