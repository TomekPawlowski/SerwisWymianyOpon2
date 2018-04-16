using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerwisWymianyOpon1
{
  public interface IOpony
    {

        void dodajObserwatora(IObserwator obserwator);

        void usunObserwatora(IObserwator obserwator);

        void powiadomObserwatorow();
    }
}
