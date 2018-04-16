using System;

namespace SerwisWymianyOpon1
{
    internal class ZamowienieOponLetnich : AbstrakcyjneZamowienieOpon
    {
        public override AbstrakcyjneOpony zamowOpony()
        {
            return new OponyLetnie();
        }
    }
}