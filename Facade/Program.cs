using Facade.Classes;
using System;



namespace Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            CiastkoFacade facade = new CiastkoFacade();

            facade.UpieczenieCiastka();
            Console.ReadKey();
        }
    }
}

