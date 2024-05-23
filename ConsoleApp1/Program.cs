using System;
using System.Reflection;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int primoEstremo, secondoEstremo, tempEstremo, numPari;

            Console.WriteLine(" === Programma dei Numeri pari === \n");

            do {
                Console.Write("Leggi il primo estremo : ");
                primoEstremo = Convert.ToInt32(Console.ReadLine());
            } while (primoEstremo < 0);

            do
            {
                Console.Write("Leggi il secondo estremo : ");
                secondoEstremo = Convert.ToInt32(Console.ReadLine());
            } while (secondoEstremo < 0);

            if (primoEstremo > secondoEstremo) {
                tempEstremo = primoEstremo;
                primoEstremo = secondoEstremo;
                secondoEstremo = tempEstremo;
            }

            Console.WriteLine(" === Numeri pari === \n");

            numPari = 0;
            for (int i = primoEstremo; i <= secondoEstremo; i++)
            {
                if (i % 2 == 0) {
                    Console.WriteLine($"Il numero: {i} è pari");
                    numPari++; 
                }
            }

            Console.WriteLine($"I numeri pari sono = {numPari}");
        }
    }
}
