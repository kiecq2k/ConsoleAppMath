using System;
using System.Collections.Generic;
using System.Text;

namespace Bryly
{
    class Prostopadloscian : DzialaniaBryly
    {

        private double a; // krawedz podstawy
        private double b; // krawedz podstawy
        private double c; // wysokosc prostopadloscianu


        /// <summary>
        /// Konstruktor wywoluje metode wprowadzajaca dane 
        /// </summary>
        public Prostopadloscian()
        {
            Console.WriteLine("Podaj dane dla prostopadloscianu: ");
            wprowadzDane();
        }

        /// <summary>
        /// Metoda oblicza objetosc prostopadloscianu
        /// </summary>
        /// <returns>objetosc prostopadloscianu</returns>
        public double obliczObjetosc()
        {
            return a * b * c;
        }

        /// <summary>
        /// Metoda oblicza pole calkowite prostopadloscianu
        /// </summary>
        /// <returns>pole calkowite</returns>
        public double obliczPoleCalkowite()
        {
            double pole = 2 * a * b + 2 * a * c + 2 * b * c;
            return pole;
        }

        /// <summary>
        /// Metoda ustawia kolor konsoli
        /// </summary>
        /// <param name="kolor"></param>
        public void ustawKolor(ConsoleColor kolor)
        {
            Console.ForegroundColor = kolor;
        }

        /// <summary>
        /// Metoda wprowadza dane prostopadloscianu od uzytkownika
        /// </summary>
        public void wprowadzDane()
        {
            do
            {
                Console.Write("Podaj a: ");
                a = double.Parse(Console.ReadLine());

                Console.Write("Podaj b: ");
                b = double.Parse(Console.ReadLine());

                Console.Write("Podaj c: ");
                c = double.Parse(Console.ReadLine());

            } while (a <= 0 || b <= 0 || c <= 0);
        }

        /// <summary>
        /// Metoda wyswietla dlugosci krawedzi prostopadloscianu
        /// </summary>
        public void wyswietlDlugosciKrawedzi()
        {
            ustawKolor(ConsoleColor.Yellow);
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("\nDane prostopadloscianu:");
            Console.WriteLine($"a = {a}, b = {b}, c = {c}");
        }

        /// <summary>
        /// Metoda wyswietla pole i objetosc prostopadloscianu
        /// </summary>
        public void wyswietlPoleObjetosc()
        {
            Console.WriteLine($"Pole prostopadloscianu = {Math.Round(obliczPoleCalkowite(),2)}, Objetosc = {Math.Round(obliczObjetosc(),2)}\n");
        }

        /// <summary>
        /// Destruktor ustawia kolor na bialy
        /// </summary>
        ~Prostopadloscian()
        {
            ustawKolor(ConsoleColor.White);
        }
    }
}
