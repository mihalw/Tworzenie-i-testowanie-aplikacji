namespace klasa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Samochod samochod = new Samochod("Opel", "Astra", "1.0", 2007);
            samochod.WyswietlInformacje();
        }

        class Samochod
        {
            private string marka = "";
            private string model = "";
            private string silnik = "";
            private int rokProdukcji = 0;

            public Samochod(string marka2, string model2, string silnik, int rokProdukcji)
            {
                this.marka = marka2;
                this.model = model2;
                this.silnik = silnik;
                this.rokProdukcji = rokProdukcji;
            }

            public void WyswietlInformacje()
            {
                Console.WriteLine("Informacje o samochodzie: ");
                Console.WriteLine("Marka: " + marka);
                Console.WriteLine("Model: " + model);
                Console.WriteLine("Silnik: " + silnik);
                Console.WriteLine("Rok produkcji: " + rokProdukcji);
            }
        }
    }
}