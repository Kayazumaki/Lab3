using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB3_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Podaj liczbę naturalną (co najmniej 3 cyfry): ");
                int liczba = Convert.ToInt32(Console.ReadLine());

                // Sprawdzenie, czy liczba ma przynajmniej 3 cyfry
                if (liczba >= 100)
                {
                    Console.WriteLine("Kolejne cyfry liczby:");

                    // Konwersja liczby na tekst
                    string liczbaTekst = liczba.ToString();

                    // Wypisanie kolejnych cyfr
                    foreach (char cyfra in liczbaTekst)
                    {
                        Console.WriteLine(cyfra);
                    }

                    break;
                }
                else
                {
                    Console.WriteLine("Podana liczba ma mniej niż 3 cyfry. Spróbuj ponownie.");
                }

            }
            Console.ReadKey();
        }
    }
}
