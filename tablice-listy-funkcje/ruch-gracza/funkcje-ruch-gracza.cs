
using System;

class Program
{
    static void Main()
    {
        int pozycjaX = 0;
        int pozycjaY = 0;

        Console.WriteLine("Twoim celem jest dotarcie do punktu 5, 5");
        WyswietlPozycje(pozycjaX, pozycjaY);

        for (int i = 0; i < 3; i++)
        {         
            Console.Write("Wybierz kierunek (wpisz prawo lub gora):");
            string kierunek = Console.ReadLine();

            if (kierunek == "prawo")
            {
                pozycjaX = IdzWPrawo(pozycjaX);
            }
            else if (kierunek == "gora")
            {
                pozycjaY = IdzWGore(pozycjaY);
            }
            else
            {
                Console.WriteLine("Nieprawidlowy kierunek!");
            }
        }

        WyswietlPozycje(pozycjaX, pozycjaY);
    }

    static void WyswietlPozycje(int x, int y)
    {
        Console.WriteLine("Aktualna pozycja: " + x + ", " + y);
    }

    static int IdzWPrawo(int pozycjaX)
    {
        System.Console.Write("O ile jednostek w prawo: ");
        int ileJednostekWPrawo = Int32.Parse(Console.ReadLine());
        return pozycjaX + ileJednostekWPrawo;
    }

    static int IdzWGore(int pozycjaY)
    {
        System.Console.Write("O ile jednostek w gore: ");
        int ileJednostekWGore = Int32.Parse(Console.ReadLine());
        return pozycjaY + ileJednostekWGore;
   }
}
