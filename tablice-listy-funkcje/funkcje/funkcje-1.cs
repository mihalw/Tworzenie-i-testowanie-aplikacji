namespace funkcje
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string imie = WczytajImie();
            PowitajUzytkownika(imie);

            int liczbaSztuk = WczytajLiczbeSztuk();
            WyswietlLacznaCene(liczbaSztuk);
        }

        static string WczytajImie()
        {
            Console.Write("Podaj imie: ");
            string imie = Console.ReadLine();
            return imie;
        }

        static void PowitajUzytkownika(string imie)
        {
            Console.WriteLine("Witaj " + imie);
        }

        static int WczytajLiczbeSztuk()
        {
            Console.Write("Ile sztuk roz chcesz kupic (cena za sztuke 8 zl): ");
            int liczbaSztuk = Int32.Parse(Console.ReadLine());
            return liczbaSztuk;
        }

        static void WyswietlLacznaCene(int liczbaSztuk)
        {
            int lacznaCena = liczbaSztuk * 8;
            Console.WriteLine("Laczna cena wynosi: " + lacznaCena);
        }
    }
}