using System;
using System.Collections.Generic;
using System.Text;

namespace Bryly
{
    class Kula : DzialaniaBryly
    {

        private double R; // promien kuli


        /// <summary>
        /// Konstruktor wywoluje metode wprowadzajaca dane
        /// </summary>
        public Kula()
        {
            Console.WriteLine("Podaj dane dla kuli: ");
            wprowadzDane();
        }

        /// <summary>
        /// Metoda oblicza objetosc kuli
        /// </summary>
        /// <returns>Objetosc kuli</returns>
        public double obliczObjetosc()
        {
            return (4.0 / 3.0 * Math.PI * Math.Pow(R, 3));
        }

        /// <summary>
        /// Metoda oblicza pole calkowite kuli
        /// </summary>
        /// <returns>Pole calkowite kuli</returns>
        public double obliczPoleCalkowite()
        {
            return (4 * Math.PI * R * R);
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
        /// Metoda wprowadza promien kuli od uzytkownika
        /// </summary>
        public void wprowadzDane()
        {
            do
            {
                Console.Write("Podaj R: ");
                R = double.Parse(Console.ReadLine());
            } while (R <= 0);
            
        }

        /// <summary>
        /// Metoda wyswietla promien kuli
        /// </summary>
        public void wyswietlDlugosciKrawedzi()
        {
            ustawKolor(ConsoleColor.Green);
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("\nDane kuli:");
            Console.WriteLine($"Promien kuli R = {R}");
        }

        /// <summary>
        /// Metoda wyswietla pole i objetosc kuli
        /// </summary>
        public void wyswietlPoleObjetosc()
        {
            Console.WriteLine($"\nPole kuli = {Math.Round(obliczPoleCalkowite(),2)}, Objetosc = {Math.Round(obliczObjetosc(),2)}\n");
        }

        /// <summary>
        /// Destruktor ustawia kolor na bialy
        /// </summary>
        ~Kula()
        {
            ustawKolor(ConsoleColor.White);
        }
    }
}
