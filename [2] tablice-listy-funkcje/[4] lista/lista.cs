using System;

class Program
{
    static void Main(string[] args)
    {
        List<string> uczniowie = new List<string>();

        uczniowie.Add("Dawid");
        uczniowie.Add("Szymon");
        uczniowie.Add("Filip");
        uczniowie.Add("Eryk");
        uczniowie.Add("Maciej");

        // uczniowie.Count to liczba elementów w tablicy uczniowie czyli 5
        for (int i = 0; i < uczniowie.Count; i++)
        {
            Console.WriteLine(uczniowie[i]);
        }
    }
}