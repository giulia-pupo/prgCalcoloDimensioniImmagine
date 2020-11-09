using System;

namespace prgCalcoloDimensioniImmagine
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, calcolo;
            Console.WriteLine("Inserisci il numero di bit:");
            int risposta = Convert.ToInt32(Console.ReadLine());
            if (risposta == 1)
            {
                Console.WriteLine("Inserisci il primo valore:");
                n1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Inserisci il secondo valore:");
                n2 = Convert.ToInt32(Console.ReadLine());
                calcolo = ((n1 * n2) / 8) / 1024;
                Console.WriteLine($"L'immagine pesa {calcolo}KB");
            }
            else if (risposta == 8)
            {
                Console.WriteLine("Inserisci il primo valore:");
                n1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Inserisci il secondo valore:");
                n2 = Convert.ToInt32(Console.ReadLine());
                calcolo = (n1 * n2) / 1024;
                Console.WriteLine($"L'immagine pesa {calcolo}KB");
            }
            else if (risposta == 16)
            {
                Console.WriteLine("Inserisci il primo valore:");
                n1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Inserisci il secondo valore:");
                n2 = Convert.ToInt32(Console.ReadLine());
                calcolo = (n1 * n2) * 2 / 1024;
                Console.WriteLine($"L'immagine pesa {calcolo}KB");
            }
            else if (risposta == 16)
            {
                Console.WriteLine("Inserisci il primo valore:");
                n1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Inserisci il secondo valore:");
                n2 = Convert.ToInt32(Console.ReadLine());
                calcolo = (n1 * n2)*3 / 1024;
                Console.WriteLine($"L'immagine pesa {calcolo}KB");
            }
            else
            {
                Console.WriteLine("Vale solo per 1, 8, 16, 24 bit");
            }
        }
    }
}
