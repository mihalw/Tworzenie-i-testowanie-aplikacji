
using System;

class Program
{
    static void Main()
    {
        // Utworzenie obiektu za pomoca konstruktora bezparametrowego
        Czlowiek czlowiek = new Czlowiek();

        // Ustawienie pol obiektu
        czlowiek.imie = "Jan";
        czlowiek.rokUrodzenia = 2005;
        czlowiek.plec = "Mezczyzna";

        // Wywolanie metody
        czlowiek.PrzywitajSie();
    }

    class Czlowiek
    {
        public string imie;
        public int rokUrodzenia;
        public string plec;

        public void PrzywitajSie()
        {
            Console.WriteLine("Imie: " + imie);
            Console.WriteLine("Data urodzenia: " + rokUrodzenia);
            Console.WriteLine("Plec: " + plec);
        }
    }
}
