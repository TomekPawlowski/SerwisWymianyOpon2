using SerwisWymianyOpon1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerwisWymianyOpon1
{
    abstract class AbstrakcyjnyDekoratorOpon : AbstrakcyjneOpony
    {

        protected AbstrakcyjneOpony abstrakcyjneOpony;

        public AbstrakcyjnyDekoratorOpon(AbstrakcyjneOpony abstrakcyjneOpony)
    {
            this.abstrakcyjneOpony = abstrakcyjneOpony;

    }

        

    }
}
