using System;


namespace Facade.Classes
{
    class CiastkoFacade
    {
        CiastkoRodzaj rodzaj;
        CiastkoDodatki dodatki;
        CiastkoAkcesoria akcesoria;

        public CiastkoFacade()
        {
            rodzaj = new CiastkoRodzaj();
            dodatki = new CiastkoDodatki();
            akcesoria = new CiastkoAkcesoria();
        }

        public void UpieczenieCiastka()
        {
            Console.WriteLine("Podanie ciasteczka\n");
            rodzaj.SetRodzaj();
            
            dodatki.SetDodatki();
           
            akcesoria.SetAkcesoria();
            Console.WriteLine("Gotowe ciastko, smacznego!\n");

        }
    }
}
