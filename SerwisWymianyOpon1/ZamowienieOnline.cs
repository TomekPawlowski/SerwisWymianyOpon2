using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerwisWymianyOpon1
{
    class ZamowienieOnline : ZamowienieTemplate
    {
        public override void doDostawa()
        {
            Console.WriteLine("Zamowienie jest wyslane kurierem");
        }

        public override void doKoszyk()
        {
            Console.WriteLine("Dodanie produktow do koszyka z produktami");
        }

        public override void doPlatnosc()
        {
            Console.WriteLine("Oplacenie produktow przelewem lub karta");
        }
    }
}
