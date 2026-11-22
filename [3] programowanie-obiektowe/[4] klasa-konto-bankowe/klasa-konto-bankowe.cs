
using System;

namespace klasa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            KontoBankowe konto = new KontoBankowe("Jan", "Nowak", "5522", 2000);

            konto.WyswietlSaldo();
            konto.Wyplata(500);
            konto.WyswietlSaldo();

            konto.ZmienPin();

            konto.Wyplata(1000);
            konto.WyswietlSaldo();
        }

        class KontoBankowe
        {
            private string imie = "";
            private string nazwisko = "";
            private string pin = "";
            private int saldo = 0;

            // Konstruktor
            public KontoBankowe(string imie, string nazwisko, string pin, int saldo)
            {
                this.imie = imie;
                this.nazwisko = nazwisko;
                this.pin = pin;
                this.saldo = saldo;
            }

            // Metoda wyplaty
            public void Wyplata(int kwotaWyplaty)
            {
                Console.Write("Podaj PIN: ");
                string podanyPin = Console.ReadLine();

                if (podanyPin == pin && kwotaWyplaty <= saldo)
                {
                    saldo = saldo - kwotaWyplaty;
                    Console.WriteLine("Wyplacono: " + kwotaWyplaty + " zl");
                }
                else
                {
                    Console.WriteLine("Nieprawidlowy PIN lub brak srodkow!");
                }

                Console.WriteLine();
            }

            public void WyswietlSaldo()
            {
                Console.WriteLine("Aktualne saldo: " + saldo + " zl");
            }

            public void ZmienPin()
            {
                Console.Write("Metoda zmiany PINu. Podaj aktualny PIN: ");
                string dotychczasowyPin = Console.ReadLine();

                if (dotychczasowyPin == pin)
                {
                    Console.Write("Podaj nowy PIN: ");
                    string nowyPin = Console.ReadLine();
                    pin = nowyPin;

                    Console.WriteLine("PIN zostal zmieniony!");
                }
                else
                {
                    Console.WriteLine("Nieprawidlowy PIN! Nie zmieniono PIN-u.");
                }

                Console.WriteLine();
            }
        }
    }
}
