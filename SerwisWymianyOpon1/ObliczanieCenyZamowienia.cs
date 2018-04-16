using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerwisWymianyOpon1
{
   public class ObliczanieCenyZamowienia
    {
        public void cenaZamowienia(double cenaOpon, double iloscOpon)
        {
            double koszt = cenaOpon * iloscOpon;
            Console.WriteLine("Koszt opon to: {0}", koszt);
        }
    }
}
