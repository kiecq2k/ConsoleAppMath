using System;
using System.Collections.Generic;
using System.Text;

namespace Bryly
{
    class OstroslupCzworokatny : DzialaniaBryly
    {

        private double a; // dlugosc krawedzi podstawy
        private double H; // wysokosc ostroslupa
        private double h; // wysokosc sciany bocznej


        /// <summary>
        /// Konstruktor wywoluje metode wprowadzajaca dane
        /// </summary>
        public OstroslupCzworokatny()
        {
            Console.WriteLine("Podaj dane dla ostroslupa prawidlowego czworokatnego: ");
            wprowadzDane();
        }

        /// <summary>
        /// Metoda oblicza objetosc ostroslupa prawidlowego czworokatnego
        /// </summary>
        /// <returns>Objetosc ostroslupa prawidlowego czworokatnego</returns>
        public double obliczObjetosc()
        {
            return (1.0 / 3.0 * a * a * H);
        }

        /// <summary>
        /// Metoda oblicza pole calkowite ostroslupa prawidlowego czworokatnego
        /// </summary>
        /// <returns>Pole calkowite ostroslupa prawidlowego czworokatnego</returns>
        public double obliczPoleCalkowite()
        {
            double pole = a * a + 2 * a * h;
            return pole;
        }

        /// <summary>
        /// Metoda wprowadza dlugosci bokow ostroslupa przez uzytkownika
        /// </summary>
        public void wprowadzDane()
        {
            do
            {
                Console.Write("Podaj dlugosc krawedzi podstawy: ");
                a = double.Parse(Console.ReadLine());

                Console.Write("Podaj dlugosc wysokosci sciany bocznej: ");
                h = double.Parse(Console.ReadLine());

                Console.Write("Podaj dlugosc wysokosci ostroslupa: ");
                H = double.Parse(Console.ReadLine());

            } while (a <= 0 || H <= 0 || h <= 0);
        }


        /// <summary>
        /// Metoda wyswietla dlugosci krawedzi ostroslupa
        /// </summary>
        public void wyswietlDlugosciKrawedzi()
        {
            ustawKolor(ConsoleColor.Red);
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("\nDane ostroslupa prawidlowego czworokatnego:");
            Console.WriteLine($"Krawedz podstawy = {a}, H = {H}, h = {h}");
        }

        /// <summary>
        /// Metoda wyswietla pole i objetosc ostroslupa prawidlowego czworokatnego
        /// </summary>
        public void wyswietlPoleObjetosc()
        {
            Console.WriteLine($"\nPole ostroslupa = {Math.Round(obliczPoleCalkowite(),2)}, Objetosc = {Math.Round(obliczObjetosc(),2)}\n");
        }

        /// <summary>
        /// Metoda ustawia kolor
        /// </summary>
        /// <param name="kolor"></param>
        public void ustawKolor(ConsoleColor kolor)
        {
            Console.ForegroundColor = kolor;
        }

        /// <summary>
        /// Destruktor ustawia kolor na bialy
        /// </summary>
         ~OstroslupCzworokatny()
        {
            ustawKolor(ConsoleColor.White);
        }
    }
}
