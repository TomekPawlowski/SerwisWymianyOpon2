using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerwisWymianyOpon1
{
    abstract class ZamowienieTemplate
    {
        public bool czyNalezyDodacProdukt;
        public void przetwarzajZamowienie(bool czyNalezyDodacProdukt)
        {
            doKoszyk();
            doPlatnosc();
            if (czyNalezyDodacProdukt)
            {
                dodanieGratisu();
            }
            doDostawa();
        }

        public abstract void doDostawa();

        private void dodanieGratisu()
        {
            Console.WriteLine("Dodano bon na zakupy w sklopie w wysokosci 20 zl");
        }

        public abstract void doPlatnosc();


        public abstract void doKoszyk();



    }
}
