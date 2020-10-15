using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatentypenDemo
{
    class Program
    {
        static void DatentypenCode()
        {
            // double ergebnis, divisor, zahl; // Deklaration
            int ii;     // Zählvariablen

            int ganzeZahl;
            short auchGanzeZahl;
            byte ganzeZahl2;
            long auchGanzeZahl2;

            ganzeZahl = 7;
            ganzeZahl = 10 + 54;
            ganzeZahl = ganzeZahl + 6;

            ganzeZahl++;

            double laenge = 1;
            double breite = 1;
            double rest = 1;

            // unärer Operator
            ganzeZahl = -ganzeZahl;

            // binärer arithmetischer Operator
            double gesuchteFlaeche = laenge * breite;

            Boolean istGrosseFlaeche = laenge * breite + rest >= 20;

            double divisor = 1;

            // Vergleichsoperatoren
            if (divisor != 0)
            {
                // mach was
            }

            /*
                String Laenge = Console.ReadLine();
                double Laenge = Convert.ToDouble(Laenge);


                int ii, jj, kk;     // Zählvariablen

                double ergebnis,    // Deklaration Ergebnis
                    divisor,        // Deklaration Divisor
                    zahl;           // Deklaration

                // Quiz 1
                const int konstante = 255; // Deklaration und Initalisierung 
                konstante += 1;

                // Quiz 2
                String Laenge = Console.ReadLine();
                double Laenge = Convert.ToDouble(Laenge);

                // Quiz 3
                integer = 5;
                double integer;
                Console.WriteLine(integer);
            */

        }

        static void StringSpielerei()
        {
            String firstString = "J";
            String lastString = "WHV";
            char myChar = 'A';
            int newChar = myChar + 3;
            char nextChar = (char)newChar;
            String myString = firstString + myChar + nextChar + ((char)(newChar + 1)) + lastString;
            Console.WriteLine(myString);

            // Das Ergebnis ist....?
        }

        static void Main(string[] args)
        {
            DatentypenCode();
            StringSpielerei();
            Console.ReadKey();
        }

    }
}
