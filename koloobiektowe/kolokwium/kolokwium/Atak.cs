using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kolokwium
{
    class Atak : Siatkarz, IDruzyna
    {

        public Atak(string imie, string nazwisko, int numerNaKoszulce)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.numerNaKoszulce = numerNaKoszulce;
        }
        public override string ToString()
        {
            return "Atak:" + imie + " " + nazwisko + " " + numerNaKoszulce + " ";
        }
    }
}