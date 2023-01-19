using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            //1
            /*Console.WriteLine("Podaj argumenty a,b,c do równania ax^2+bx+c");
            Double a = 0, b = 0, c = 0, delta = 0, x1 = 0, x2 = 0, x0 = 0;
            Console.WriteLine("Podaj współczynnik a");
            a = Double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj współczynnik b");
            b = Double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj współczynnik c");
            c = Double.Parse(Console.ReadLine());
            delta = b * b - 4 * a * c;
            Console.WriteLine("Delta wynosi " + delta);
 
            if (delta > 0)
            {
                x1 = ((-b) - Math.Sqrt(delta)) / (2 * a);
                x2 = ((-b) + Math.Sqrt(delta)) / (2 * a);
                Console.Write("Rozwiązania równania to: ");
                Console.Write("{0:#.###}", x1);
                Console.Write(" i "); 
                Console.Write("{0:#.###}", x2);
            };

            if (delta == 0)
            {
                x0 = (-b) / (2 * a);
                Console.Write("Rozwiązanie równania wynosi ");
                Console.Write("{0:#.###}", x0);
            };

            if (delta < 0) Console.WriteLine("Nie ma rozwiązań");*/


            //4
            /*Console.WriteLine("Podaj argumenty a,b,c do równania ax^2+bx+c");
            Double a = 0, b = 0, c = 0, delta = 0, x1 = 0, x2 = 0, x0 = 0;
            Int32 d = 0; 
            Console.WriteLine("Podaj współczynnik a");
            a = Double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj współczynnik b");
            b = Double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj współczynnik c");
            c = Double.Parse(Console.ReadLine());
            delta = b * b - 4 * a * c;
            Console.WriteLine("Delta wynosi " + delta);

            if (delta < 0) d = 0;
            if (delta == 0) d = 1;
            if (delta > 0) d = 2;

            switch (d)
            {
                case 0:
                    {
                        Console.WriteLine("Nie ma rozwiązań");
                    } break;
                case 1:
                    {
                        x0 = (-b) / (2 * a);
                        Console.Write("Rozwiązanie równania wynosi ");
                        Console.Write("{0:#.###}", x0);
                    } break;
                case 2:
                    {
                        x1 = ((-b) - Math.Sqrt(delta)) / (2 * a);
                        x2 = ((-b) + Math.Sqrt(delta)) / (2 * a);
                        Console.Write("Rozwiązania równania to: ");
                        Console.Write("{0:#.###}", x1);
                        Console.Write(" i ");
                        Console.Write("{0:#.###}", x2);
                    } break;
            }*/


            //5
            /*for (Int32 a = 1; a < 21; a++)
            {
                Int32 b = 2 * a + 1;
                Console.Write(+ b + " ");
            }*/


            //6
            /*Int32 a = 1;
            do
            {
                Int32 b = 2 * a + 1;
                Console.Write(+ b + " ");
                a++;
            }
            while (a < 21);*/

            //8
            /*Int32 a = 1;
            while (a < 21)
            {
                Int32 b = 2 * a + 1;
                Console.Write(+ b + " ");
                a++;
            };*/

            //9
            /*Int32 ilosc = 0;
            String imie, nazwisko;
            Console.WriteLine("Podaj swoje imie");
            imie = Console.ReadLine();
            Console.WriteLine("Podaj swoje nazwisko"); 
            nazwisko = Console.ReadLine();
            Console.WriteLine("Ile razy mam wyswietlic?");
            ilosc = Int32.Parse(Console.ReadLine());

            for (Int32 i = 0; i < ilosc ; i++)
            {
                Console.WriteLine("Twoje imie i nazwisko to: " + imie + " " + nazwisko);
            }*/
            
            //10

            /*Random liczba = new Random();
            Int32 a, b;
            for (b = 0; b <= 20; b++)
            {
                a = liczba.Next(5, 25);
                Console.WriteLine(a);
            };*/

            //11

            Console.WriteLine("Odgadnij wylosowana liczbe z przedialu 0-100. Masz na to 6 prob");
            Random liczba = new Random();
            Int32 liczba_losowa = 0, liczba_gracza = 0, proby = 1;

            liczba_losowa = liczba.Next(0, 100);

            while (proby < 7 )
            {
                Console.WriteLine();
                liczba_gracza = Int32.Parse(Console.ReadLine());

                if(liczba_gracza == liczba_losowa)
                {
                    Console.WriteLine("Brawo odgadles liczbe! Wylosowana liczba to: " + liczba_losowa);
                    break;
                }
                if(liczba_gracza != liczba_losowa)
                {
                    Console.Write("Niestety, nie udalo Ci sie tym razem ");
                    Console.WriteLine("jest to twoja " + proby + " proba");
                    if (liczba_losowa > liczba_gracza) Console.WriteLine("Wylosowana liczba jest wieksza niz twoja");
                    else Console.WriteLine("Wylosowana liczba jest mniejsza niz twoja");
                };
                proby++;
            }; 
            Console.WriteLine();
            if(proby == 7) Console.WriteLine("Nie udalo sie. Wylosowana liczba to: " + liczba_losowa); 
            Console.WriteLine();
            Console.WriteLine("Nacisnij klawisz by wyjść z programu");
            Console.ReadKey(true);
        }
    }
}
