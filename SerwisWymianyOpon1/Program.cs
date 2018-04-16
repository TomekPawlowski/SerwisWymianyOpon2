using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SerwisWymianyOpon1.AbstrakcyjneZamowienieOpon;

namespace SerwisWymianyOpon1
{
    class Program
    {
     
        static void Main(string[] args)
        {

            //Program wykorzystuje wzorzec fabryka abstrakcyjna do tworzenia obiektów w zależności od tego czy opony są letnie czy  zimowe.
            //Program wykorzystuje wzorzec singelton do tworzenia tylko jednego obiektu obsługjącego zapis do pliku

            AbstrakcyjneZamowienieOpon azo = AbstrakcyjneZamowienieOpon.wybierzRodzajOpon(OPONY.letnie);
            AbstrakcyjneOpony ao = azo.zamowOpony();
            ZapisDoPlikuSingleton.Instance.ZapisDoPliku(ao.wyswietlRodzajOpon());

            AbstrakcyjneZamowienieOpon azo2 = AbstrakcyjneZamowienieOpon.wybierzRodzajOpon(OPONY.zimowe);
            AbstrakcyjneOpony ao2 = azo2.zamowOpony();
            Console.WriteLine(ao2.wyswietlRodzajOpon());

            //Adapter

            Console.WriteLine("Zastosowanie adaptera: ");
            WyswietlanieZamowienia wzam = new WyswietlanieZamowienia();
            IAdapterListener adapterListener = new WyswietlZamowienieAdapter(wzam);
            adapterListener.Wyswietl("zimowe");
            Console.WriteLine();

            //Dekorator

            Console.WriteLine("Zastosowanie dekoratora: ");

            AbstrakcyjneOpony oponyZimowe = new OponyZimowe();
            //Przed dekoracją
            Console.WriteLine(oponyZimowe.wyswietlRodzajOpon());
            Console.WriteLine();
            //Po dekoracji
            AbstrakcyjneOpony oponyZimoweZKolcami = new OponyZimoweZKolcami(oponyZimowe);
            Console.WriteLine(oponyZimoweZKolcami.wyswietlRodzajOpon());
            Console.WriteLine();

            //Fasada
            Console.WriteLine("Zastosowanie fasady: ");
            FasadaObliczanieCenyOpon foco = new FasadaObliczanieCenyOpon();
            foco.obliczanieCenyZamowienia(150, 4);
            Console.WriteLine();

            //Obserwator

            Console.WriteLine("Zastosowanie obserwatora");
            Klient klient1 = new Klient("Jan Nowak");
            Klient klient2 = new Klient("Barbara Kowalska");
            

            Opony opony = new Opony("Opony zimowe", false);
            opony.dodajObserwatora(klient1);
            opony.dodajObserwatora(klient2);

            opony.ustawDostepnosc(true);
            Console.WriteLine();

            //Pamiatka
            Console.WriteLine("Zastosowanie pamiatki");
            List<ZmianaStatusuZamowienia.Memento> zapisanStany = new List<ZmianaStatusuZamowienia.Memento>();
            ZmianaStatusuZamowienia zsz = new ZmianaStatusuZamowienia();

            zsz.ustawStanZamowienia("zarejestrowany");
            zapisanStany.Add(zsz.zapiszaStanZamowienia());
            zsz.ustawStanZamowienia("przekazany do reazlizacji");
            zapisanStany.Add(zsz.zapiszaStanZamowienia());
            zsz.ustawStanZamowienia("towar pakowany");
            zapisanStany.Add(zsz.zapiszaStanZamowienia());

            zsz.przywrocWczesniejszyStatusZamowienia(zapisanStany[1]);

            Console.WriteLine();

            //Metoda Szablonowa

            Console.WriteLine("Zastosowanie metody szablonowej");
            ZamowienieTemplate zamowienieOnline = new ZamowienieOnline();
            zamowienieOnline.przetwarzajZamowienie(true);

            Console.WriteLine();
            ZamowienieTemplate zamowienieStacjonarne = new ZamowienieStacjonarne();
            zamowienieStacjonarne.przetwarzajZamowienie(false);

       



        }
    }
}
