using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerwisWymianyOpon1
{
  public  interface IObserwator
    {
        void update(string nazwa, bool dostepnosc);
    }
}
