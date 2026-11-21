
using System;

namespace klasa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Utworzenie obiektu samochod
            Samochod samochod = new Samochod(0, 0);

            // Wyswietlenie poczatkowego polozenia
            samochod.WyswietlPolozenie();

            // Przemieszczanie samochodu
            samochod.Jedz(5, 3);
            samochod.WyswietlPolozenie();

            samochod.Jedz(2, 4);
            samochod.WyswietlPolozenie();

            samochod.Jedz(-3, -2);
            samochod.WyswietlPolozenie();
        }

        class Samochod
        {
            private int wspolrzednaX = 0;
            private int wspolrzednaY = 0;

            // Konstruktor
            public Samochod(int x, int y)
            {
                this.wspolrzednaX = x;
                this.wspolrzednaY = y;
            }

            // Metoda zmieniajaca polozenie samochodu
            public void Jedz(int x, int y)
            {
                Console.WriteLine("Samochod zmienia polozenie o x: " + x + ", y: " + y);

                wspolrzednaX = wspolrzednaX + x;
                wspolrzednaY = wspolrzednaY + y;
            }

            // Metoda wyswietlajaca aktualne polozenie
            public void WyswietlPolozenie()
            {
                Console.WriteLine("Aktualne polozenie x:" + wspolrzednaX + ", y:" + wspolrzednaY);
            }
        }
    }
}
