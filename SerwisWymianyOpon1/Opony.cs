using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerwisWymianyOpon1
{
  public  class Opony : IOpony
    {
        private List<IObserwator> obserwatorzy = new List<IObserwator>();
        private string nazwa;
        private bool dostepnosc;


        public Opony(string nazwa, bool dostepnosc)
        {
            this.nazwa = nazwa;
            this.dostepnosc = dostepnosc;
        }

        public List<IObserwator> getObservers()
        {
            return obserwatorzy;
        }

        public string pobierzNazwe()
        {
            return nazwa;
        }

        public void ustawNazwe(string nazwa)
        {
            this.nazwa = nazwa;
        }


        public bool pobierzDostepnosc()
        {
            return dostepnosc;
        }

        public void ustawDostepnosc(bool dostepnosc)
        {
            this.dostepnosc = dostepnosc;
            powiadomObserwatorow();
        }

        public void dodajObserwatora(IObserwator obserwator)
        {
            obserwatorzy.Add(obserwator);
        }

        public void powiadomObserwatorow()
        {
            Console.WriteLine("Powiadomienie wszystkich obserwatorow.");
            foreach (var obserwator in obserwatorzy)
            {
                obserwator.update(nazwa, dostepnosc);

            }
        }

        public void usunObserwatora(IObserwator obserwator)
        {

            obserwatorzy.Remove(obserwator);
        }
    }
}
