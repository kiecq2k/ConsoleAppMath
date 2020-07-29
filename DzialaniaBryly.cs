using System;
using System.Collections.Generic;
using System.Text;

namespace Bryly
{
    interface DzialaniaBryly
    {
        public abstract void wprowadzDane();
        public abstract void wyswietlDlugosciKrawedzi();
        public abstract double obliczPoleCalkowite();
        public abstract double obliczObjetosc();
        public abstract void wyswietlPoleObjetosc();
        public abstract void ustawKolor(ConsoleColor kolor);

    }
}
