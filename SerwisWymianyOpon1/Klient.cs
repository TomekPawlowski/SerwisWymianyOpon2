using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerwisWymianyOpon1
{
   public class Klient : IObserwator
    {

        string nazwa;

        public Klient(string nazwa)
        {
            this.nazwa = nazwa;
        }

        public string pobierzNazwe()
        {
            return nazwa;
        }

        public void ustawNazwe(string nazwa)
        {
            this.nazwa = nazwa;
        }
        public void update(string produkt, bool dostepnosc)
        {

            if(dostepnosc)
            {
                Console.WriteLine("Witaj " + nazwa + ", Produkt: " + produkt + " jest dostepny");
            }

            else
            {
                Console.WriteLine("Witaj " + nazwa + ", Produkt: " + produkt + " nie jest juz dostepny");
            }
           
        }
    }
}
