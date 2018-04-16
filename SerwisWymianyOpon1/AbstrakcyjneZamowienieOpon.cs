using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerwisWymianyOpon1
{
    public abstract class AbstrakcyjneZamowienieOpon
    {
        public enum OPONY { letnie, zimowe }

        public static AbstrakcyjneZamowienieOpon wybierzRodzajOpon(OPONY wybor)
        {
            switch (wybor)
            {
                case OPONY.letnie:
                    return new ZamowienieOponLetnich();
                case OPONY.zimowe:
                    return new ZamowienieOponZimowych();
                default:
                    throw new NotImplementedException();


            }

           
        }
        public abstract AbstrakcyjneOpony zamowOpony();
    }
}
