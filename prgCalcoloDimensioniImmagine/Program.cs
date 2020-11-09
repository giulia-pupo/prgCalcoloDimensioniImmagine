using System;

namespace prgCalcoloDimensioniImmagine
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inserisci il primo valore:");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Inserisci il secondo valore:");
            int n2 = Convert.ToInt32(Console.ReadLine());
            int calcolo = ((n1 * n2) * 3) / 1024;
            Console.WriteLine($"L'immagine pesa {calcolo}KB");
        }
    }
}
