using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerwisWymianyOpon1
{
    class ZmianaStatusuZamowienia
    {
        private string statusZamowienia;

       public void ustawStanZamowienia(string statusZamowienia)
        {
            this.statusZamowienia = statusZamowienia;

        }

        public Memento zapiszaStanZamowienia()
        {
            Console.WriteLine("Zmiana statusu na: " + statusZamowienia);
            Console.WriteLine("Status zamowienia zapisany");
            return (new Memento(statusZamowienia));
        }

        public void przywrocWczesniejszyStatusZamowienia(Memento memento)
        {
            statusZamowienia = memento.pobierzStatus();
            Console.WriteLine("Przywrocono status zamowienia: " + statusZamowienia);
        }

        public class Memento
        {

            private string statusZamowienia;

            public Memento(string statusZamowienia)
            {
                this.statusZamowienia = statusZamowienia;
            }

            public string pobierzStatus()
            {
                return statusZamowienia;
            }
        }
    }
}
