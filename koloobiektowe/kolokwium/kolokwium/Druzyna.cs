using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kolokwium
{
    class Druzyna:Siatkarz, IDruzyna
    {
        string[,] druzyna = new string[4,2];
        string nazwa;


       public void UstawAtak(int numerNaKoszulce,string imie,string nazwisko,int druzyna)
        { 

        }
       public void UstawNazwe(string nazwa)
       {
           this.nazwa = nazwa;
       }
    }
}
