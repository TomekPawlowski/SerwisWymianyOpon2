using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerwisWymianyOpon1
{
    class ZamowienieStacjonarne : ZamowienieTemplate
    {
        public override void doDostawa()
        {
            Console.WriteLine("Zamowienie zostanie odebrane w sklepie");
        }

        public override void doKoszyk()
        {
            Console.WriteLine("Zamowienie zostaje przekazane do odebrania w magazynie");
        }

        public override void doPlatnosc()
        {
            Console.WriteLine("Platnosc w sklepie");
        }
    }
}
