using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerwisWymianyOpon1
{
    class FasadaObliczanieCenyOpon
    {
        public void obliczanieCenyZamowienia(double cenaOpon, double iloscOpon)
        {
            ObliczanieCenyZamowienia ocz = new ObliczanieCenyZamowienia();
            ocz.cenaZamowienia(cenaOpon, iloscOpon);

        }
    }
}
