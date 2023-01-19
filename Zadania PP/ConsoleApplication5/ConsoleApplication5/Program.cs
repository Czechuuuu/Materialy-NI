using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Random rand = new Random();
            Boolean ok = true;
            Int32 rozmiar = 0;
            Console.Write("Podaj rozmiar tablicy: ");
            rozmiar = Int32.Parse(Console.ReadLine());
            Int32[] tablica = new Int32 [rozmiar];

            Console.WriteLine("Nieposortowane: ");

            for (Int32 i = 0; i < rozmiar; i++)
            {
                tablica[i] = rand.Next(0, 100);
                Console.Write(tablica[i] + ", ");
            }
            Console.WriteLine();
            Console.WriteLine("Posortowane: ");

            for(Int32 i = 0; i < rozmiar - 1; i++) //sortowanie
                for(Int32 j = 0; j < rozmiar - 1; j++)
                    if(tablica[j] > tablica[j+1])
                    {
                        Int32 pomoc = tablica[j];
                        tablica[j] = tablica[j+1];
                        tablica[j+1] = pomoc;
                    }

            for (Int32 i = 0; i < rozmiar; i++)
                Console.Write(tablica[i] + ", ");

            Console.WriteLine();

            for (Int32 i = 0; i < rozmiar - 1; i++)
                if (tablica[i] > tablica[i + 1])
                {
                    ok = false;
                }
            Console.WriteLine(ok ? "Wynik posortowane " : "Wynik nieposortowane ");*/

            //////////////////////////////////////////////////////////////////////////////////////Bąbelkowe

            /*Stopwatch watch;
            Random rand = new Random();
            Boolean ok = true;
            Int32 rozmiar = 0;
            Console.Write("Podaj rozmiar tablicy: ");
            rozmiar = Int32.Parse(Console.ReadLine());
            Int32[] tablica = new Int32[rozmiar];

            for (Int32 i = 0; i < rozmiar; i++)
            {
                tablica[i] = rand.Next(0, 100);
                //Console.Write(tablica[i] + ", ");
            }

            watch = Stopwatch.StartNew();

            for (Int32 i = 0; i < rozmiar - 1; i++) //sortowanie
                for (Int32 j = 0; j < rozmiar - 1; j++)
                    if (tablica[j] > tablica[j + 1])
                    {
                        Int32 pomoc = tablica[j];
                        tablica[j] = tablica[j + 1];
                        tablica[j + 1] = pomoc;
                    }

            watch.Stop();

            /*for (Int32 i = 0; i < rozmiar; i++)
                Console.Write(tablica[i] + ", ");

            for (Int32 i = 0; i < rozmiar - 1; i++)
                if (tablica[i] > tablica[i + 1])
                {
                    ok = false;
                }
            Console.WriteLine(ok ? "Wynik posortowane " : "Wynik nieposortowane ");
            Console.WriteLine("Czas : {0}", watch.Elapsed);*/

            ///////////////////////////////////////////////////////////////////////////////////////////Bąbelkowe1

            /*Stopwatch watch;
            Random rand = new Random();
            Boolean ok1 = true;
            Boolean ok2 = true;
            Int32 rozmiar = 0;
            Console.Write("Podaj rozmiar tablicy: ");
            rozmiar = Int32.Parse(Console.ReadLine());
            Int32[] tablica = new Int32[rozmiar];

            for (Int32 i = 0; i < rozmiar; i++)
            {
                tablica[i] = rand.Next(0, 100);
                //Console.Write(tablica[i] + ", ");
            }

            watch = Stopwatch.StartNew();

            for (; ; ) //sortowanie
            {
                ok1 = false;
                for (Int32 j = 0; j < rozmiar - 1; j++)
                    if (tablica[j] > tablica[j + 1])
                    {
                        Int32 pomoc = tablica[j];
                        tablica[j] = tablica[j + 1];
                        tablica[j + 1] = pomoc;
                        ok1 = true;
                    }
                if (!ok1) break;
            }

            watch.Stop();

            /*for (Int32 i = 0; i < rozmiar; i++)
                Console.Write(tablica[i] + ", ");

            for (Int32 i = 0; i < rozmiar - 1; i++)
                if (tablica[i] > tablica[i + 1])
                {
                    ok2 = false;
                }
            Console.WriteLine(ok2 ? "Wynik posortowane " : "Wynik nieposortowane ");
            Console.WriteLine("Czas : {0}", watch.Elapsed);*/

            /////////////////////////////////////////////////////////////////////////////////////Bąbelkowe2

            /*topwatch watch;
            Random rand = new Random();
            Boolean ok = true;
            Int32 rozmiar = 0;
            Console.Write("Podaj rozmiar tablicy: ");
            rozmiar = Int32.Parse(Console.ReadLine());
            Int32[] tablica = new Int32[rozmiar];

            for (Int32 i = 0; i < rozmiar; i++)
            {
                tablica[i] = rand.Next(0, 100);
                //Console.Write(tablica[i] + ", ");
            }

            watch = Stopwatch.StartNew();

            for (Int32 i = 0; i < rozmiar - 1; i++ ) //sortowanie
                for (Int32 j = 0; j < rozmiar - i - 1; j++)
                    if (tablica[j] > tablica[j + 1])
                    {
                        Int32 pomoc = tablica[j];
                        tablica[j] = tablica[j + 1];
                        tablica[j + 1] = pomoc;
                    }

            watch.Stop();

            /*for (Int32 i = 0; i < rozmiar; i++)
                Console.Write(tablica[i] + ", ");

            for (Int32 i = 0; i < rozmiar - 1; i++)
                if (tablica[i] > tablica[i + 1])
                {
                    ok = false;
                }
            Console.WriteLine(ok ? "Wynik posortowane " : "Wynik nieposortowane ");
            Console.WriteLine("Czas : {0}", watch.Elapsed);*/

            /////////////////////////////////////////////////////////////////////////////////////////////////////////Bąbelkowe3

            Stopwatch watch;
            Random rand = new Random();
            Boolean ok1 = true;
            Boolean ok2 = true;
            Int32 rozmiar = 0;
            Console.Write("Podaj rozmiar tablicy: ");
            rozmiar = Int32.Parse(Console.ReadLine());
            Int32[] tablica = new Int32[rozmiar];

            for (Int32 i = 0; i < rozmiar; i++)
            {
                tablica[i] = rand.Next(0, 100);
                //Console.Write(tablica[i] + ", ");
            }

            watch = Stopwatch.StartNew();

            Int32 lewo = 0;
            Int32 prawo = rozmiar - 1;

            do //sortowanie
            {
                ok1 = false;
                for (Int32 i = lewo; i < prawo; i++)
                    if (tablica[i] > tablica[i + 1])
                    {
                        Int32 pomoc = tablica[i];
                        tablica[i] = tablica[i + 1];
                        tablica[i + 1] = pomoc;
                        ok1 = true;
                    }
                prawo--;
                for (Int32 i = prawo; i > lewo; i--)
                    if (tablica[i] < tablica[i - 1])
                    {
                        Int32 pomoc = tablica[i];
                        tablica[i] = tablica[i - 1];
                        tablica[i - 1] = pomoc;
                        ok1 = true;
                    }
                lewo++;
            }
            while (ok1);

            watch.Stop();

            //for (Int32 i = 0; i < rozmiar; i++)
                //Console.Write(tablica[i] + ", ");

            for (Int32 i = 0; i < rozmiar - 1; i++)
                if (tablica[i] > tablica[i + 1])
                {
                    ok2 = false;
                }
            Console.WriteLine(ok2 ? "Wynik posortowane " : "Wynik nieposortowane ");
            Console.WriteLine("Czas : {0}", watch.Elapsed);

            ////////////////////////////////////////////////////////////////////Gnom1

            /*Stopwatch watch;
            Random rand = new Random();
            Boolean ok2 = true;
            Int32 rozmiar = 0;
            Console.Write("Podaj rozmiar tablicy: ");
            rozmiar = Int32.Parse(Console.ReadLine());
            Int32[] tablica = new Int32[rozmiar];

            for (Int32 i = 0; i < rozmiar; i++)
            {
                tablica[i] = rand.Next(0, 100);
                //Console.WriteLine(tablica[i] + ", ");
            }

            watch = Stopwatch.StartNew();
            Int32 p = 0;
            while (p < rozmiar)
            {
                if (p == 0 || tablica[p] >= tablica[p - 1]) p = p + 1;
                else
                {
                    Int32 pomoc = tablica[p];
                    tablica[p] = tablica[p - 1];
                    tablica[p - 1] = pomoc;
                    p = p - 1;
                }
            }
            watch.Stop();
            
            //for (Int32 i = 0; i < rozmiar; i++)
                //Console.Write(tablica[i] + ", ");

            for (Int32 i = 0; i < rozmiar - 1; i++)
                if (tablica[i] > tablica[i + 1])
                {
                    ok2 = false;
                }
            Console.WriteLine(ok2 ? "Wynik posortowane " : "Wynik nieposortowane ");
            Console.WriteLine("Czas : {0}", watch.Elapsed);*/

            /////////////////////////////////////////////////////////////////////Gnom2

            /*Stopwatch watch;
            Random rand = new Random();
            Boolean ok2 = true;
            Int32 rozmiar = 0;
            Console.Write("Podaj rozmiar tablicy: ");
            rozmiar = Int32.Parse(Console.ReadLine());
            Int32[] tablica = new Int32[rozmiar];

            for (Int32 i = 0; i < rozmiar; i++)
            {
                tablica[i] = rand.Next(0, 100);
                //Console.WriteLine(tablica[i] + ", ");
            }

            watch = Stopwatch.StartNew();
            Int32 p = 0;
            Int32 ostp = 0;
            while (p < rozmiar - 1)
            {
                if (p == 0 || tablica[p] >= tablica[p - 1])
                {
                    p = ostp + 1;
                    ostp = p;
                }
                else
                {
                    Int32 pomoc = tablica[p];
                    tablica[p] = tablica[p - 1];
                    tablica[p - 1] = pomoc;
                    p = p - 1;
                }
            }
            watch.Stop();

            //for (Int32 i = 0; i < rozmiar; i++)
                //Console.Write(tablica[i] + ", ");

            for (Int32 i = 0; i < rozmiar - 1; i++)
                if (tablica[i] > tablica[i + 1])
                {
                    ok2 = false;
                }
            Console.WriteLine(ok2 ? "Wynik posortowane " : "Wynik nieposortowane ");
            Console.WriteLine("Czas : {0}", watch.Elapsed);*/

            ///////////////////////////////////////////////////////////////////////////Wstawianie

            /*Stopwatch watch;
            Random rand = new Random();
            Boolean ok2 = true;
            Int32 rozmiar = 0, pomoc = 0, j = 0;
            Console.Write("Podaj rozmiar tablicy: ");
            rozmiar = Int32.Parse(Console.ReadLine());
            Int32[] tablica = new Int32[rozmiar];

            for (Int32 i = 0; i < rozmiar; i++)
            {
                tablica[i] = rand.Next(0, 100);
                //Console.WriteLine(tablica[i] + ", ");
            }

            watch = Stopwatch.StartNew();
            for (Int32 i = 0; i < rozmiar; i++)
            {
                pomoc = tablica[i];
                j = i - 1;
                while (j >= 0 && tablica[j] > pomoc)
                {
                    tablica[j + 1] = tablica[j];
                    j = j - 1;
                }
                tablica[j + 1] = pomoc;
            }
            watch.Stop();

            /*for (Int32 i = 0; i < rozmiar; i++)
                Console.Write(tablica[i] + ", ");

            for (Int32 i = 0; i < rozmiar - 1; i++)
                if (tablica[i] > tablica[i + 1])
                {
                    ok2 = false;
                }
            Console.WriteLine(ok2 ? "Wynik posortowane " : "Wynik nieposortowane ");
            Console.WriteLine("Czas : {0}", watch.Elapsed);*/

            Console.ReadKey(true);
        }
    }
}
