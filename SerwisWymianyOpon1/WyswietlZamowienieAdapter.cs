using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerwisWymianyOpon1
{
    class WyswietlZamowienieAdapter : IAdapterListener
    {
        private WyswietlanieZamowienia adaptee;

        public WyswietlZamowienieAdapter(WyswietlanieZamowienia adaptee)
        {

            this.adaptee = adaptee;
        }

        public void Wyswietl(string rodzajOpon)
        {
            adaptee.WyswietlaZamwowioneOpony(rodzajOpon);
        }
    }
}
