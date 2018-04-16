using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerwisWymianyOpon1
{
    class OponyZimoweZKolcami : AbstrakcyjnyDekoratorOpon
    {
        public OponyZimoweZKolcami(AbstrakcyjneOpony abstrakcyjneOpony) : base(abstrakcyjneOpony)
        {
        }

        public override string wyswietlRodzajOpon()
        {
            return abstrakcyjneOpony.wyswietlRodzajOpon() + " z kolcami";
        }
    }
}
