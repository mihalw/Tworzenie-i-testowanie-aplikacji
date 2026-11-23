using System;

class Program
{
    static void Main(string[] args)
    {
        // Utworzenie pierwszego obiektu
        Produkt produkt1 = new Produkt("Laptop", 4800, "Laptopy i komputery", "dostępny");
        produkt1.WyswietlInformacje();
        produkt1.ObnizCene(20);
        produkt1.WyswietlInformacje();

        // Utworzenie drugiego obiektu
        Produkt produkt2 = new Produkt("Pralka", 2500, "AGD", "dostępny");
        produkt2.Sprzedaj();
        produkt2.WyswietlInformacje();
        produkt2.Sprzedaj();
    }
}

class Produkt
{
    private string nazwa;
    private double cena;
    private string kategoria;
    private string stan;

    public Produkt(string nazwa, double cena, string kategoria, string stan)
    {
        this.nazwa = nazwa;
        this.cena = cena;
        this.kategoria = kategoria;
        this.stan = stan;
    }

    public void WyswietlInformacje()
    {
        Console.WriteLine("Nazwa: " + nazwa);
        Console.WriteLine("Cena: " + cena + " zł");
        Console.WriteLine("Kategoria: " + kategoria);
        Console.WriteLine("Stan: " + stan);
        Console.WriteLine();
    }

    public void ObnizCene(int procentObnizki)
    {
        cena = cena - (cena * procentObnizki / 100);
    }

    public void Sprzedaj()
    {
        if (stan == "dostępny")
        {
            stan = "niedostępny";
            Console.WriteLine("Produkt został sprzedany.");
        }
        else
        {
            Console.WriteLine("Produkt jest niedostępny i nie można go kupić.");
        }
    }
}
