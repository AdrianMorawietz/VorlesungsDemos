using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SummenDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Eingabe 
            Console.WriteLine("Geben Sie eine Zahl n ein: ");
            String n_Zeichenkette = Console.ReadLine();
            int n = Convert.ToInt32(n_Zeichenkette); 

            // Initialisiern der Variablen
            int sum = 0;
            int ii = 1;

            // Summe durch Wiederholung 
            while (ii <= n)
            {
                sum = sum + ii;
                ii = ii + 1;
            }

            // Ausgabe
            Console.WriteLine("Ergebnis: " + sum);
            Console.ReadKey();

        }
    }
}
