using System;

namespace SerwisWymianyOpon1
{
    internal class ZamowienieOponZimowych : AbstrakcyjneZamowienieOpon
    {
        public override AbstrakcyjneOpony zamowOpony()
        {
            return new OponyZimowe();
        }
    }
}