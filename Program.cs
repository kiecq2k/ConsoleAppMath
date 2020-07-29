using System;

namespace Bryly
{
    class Program
    {
        static void Main(string[] args)
        {
            DzialaniaBryly[] bryly = { new Prostopadloscian(), new Kula(), new OstroslupCzworokatny()};

            foreach(var bryla in bryly)
            {
                bryla.wyswietlDlugosciKrawedzi();
                bryla.wyswietlPoleObjetosc();
            }
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
