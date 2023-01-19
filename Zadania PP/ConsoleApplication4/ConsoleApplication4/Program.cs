using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
    

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1
            /*Int32 liczba1 = 0, liczba2 = 0, reszta = 0, liczba3 = 0, liczba4 = 0;
            Console.WriteLine("Podaj dwie liczby a ja oblicze ich NWD: ");
            liczba1 = Int32.Parse(Console.ReadLine());
            liczba2 = Int32.Parse(Console.ReadLine());
            liczba3 = liczba1;
            liczba4 = liczba2;
            while (liczba1 != liczba2)
            {
                if (liczba1 > liczba2)
                {
                    liczba1 = liczba1 - liczba2;
                }
                else
                {
                    liczba2 = liczba2 - liczba1;
                }
            }
            Console.WriteLine("NWD twoich liczb to: " + liczba1);
            while (liczba4 != 0)
            {
                reszta = liczba3 % liczba4;
                liczba3 = liczba4;
                liczba4 = reszta;
            }
            Console.WriteLine("NWD twoich liczb to: " + liczba3);*/

            // 2
            /*Int32 liczba1 = 0, liczba2 = 0, reszta = 0, liczba3 = 0, liczba4 = 0, ile1 = 0, ile2 = 0;
            Console.WriteLine("Podaj dwie liczby a ja oblicze ich NWD: ");
            liczba1 = Int32.Parse(Console.ReadLine());
            liczba2 = Int32.Parse(Console.ReadLine());
            liczba3 = liczba1;
            liczba4 = liczba2;
            while (liczba1 != liczba2)
            {
                if (liczba1 > liczba2)
                {
                    liczba1 = liczba1 - liczba2;
                }
                else
                {
                    liczba2 = liczba2 - liczba1;
                }
                ile1++;
            }
            Console.WriteLine("NWD twoich liczb to: " + liczba1 + " Liczba iteracji rowna :" + ile1);
            while (liczba4 != 0)
            {
                reszta = liczba3 % liczba4;
                liczba3 = liczba4;
                liczba4 = reszta;
                ile2++;
            }
            Console.WriteLine("NWD twoich liczb to: " + liczba3 + " Liczba iteracji rowna :" + ile2);*/

            // 3,4/a
            /*Stopwatch watch;
            Random rand = new Random();
            Int32 liczba1 = 0, liczba2 = 0, liczba3 = 0, liczba4 = 0, reszta = 0;
            Console.WriteLine("Podaj liczbe: ");
            liczba1 = Int32.Parse(Console.ReadLine()); liczba3 = liczba1;
            watch = Stopwatch.StartNew();

            while (liczba1 > 1)
            {
            liczba2 = rand.Next(liczba3, (liczba3 * 2));
            liczba4 = liczba2;
                while (liczba2 != 0)
                {
                    reszta = liczba1 % liczba2;
                    liczba1 = liczba2;
                    liczba2 = reszta;
                }
            }
            watch.Stop();
            Console.WriteLine("Para liczb wzglednie pierwszych to: " + liczba3 + " i " + liczba4);
            Console.WriteLine("Czas: {0}", watch.ElapsedTicks);*/

            // 3,4/b
            /*Stopwatch watch;
            Random rand = new Random();
            Int32 liczba1 = 0, liczba2 = 0, liczba4 = 0, liczba5 = 0, liczba6 = 0, reszta = 0;
            Console.WriteLine("Podaj liczbe: ");
            liczba1 = Int32.Parse(Console.ReadLine());
            watch = Stopwatch.StartNew();

            while (liczba2 != 1)
            {
                liczba2 = rand.Next(liczba1, (liczba1 * 2)); 
                liczba5 = liczba2;
                liczba4 = rand.Next(liczba1, (liczba1 * 2)); 
                liczba6 = liczba4;

                while (liczba4 != 0)
                {
                    reszta = liczba2 % liczba4;
                    liczba2 = liczba4;
                    liczba4 = reszta;
                }
            }
            watch.Stop();
            Console.WriteLine("Para liczb wzglednie pierwszych to: " + liczba5 + " i " + liczba6);
            Console.WriteLine("Czas: {0}", watch.ElapsedTicks);*/

            // 5
            /*Int32 liczba, wynik = 0;
            Console.WriteLine("Podaj ktory element ciagu fibonacciego mam obliczyc: ");
            liczba = Int32.Parse(Console.ReadLine());
            Console.WriteLine();

            if (liczba == 0) Console.WriteLine(+ liczba + " wyraz ciagu wynosi: " + liczba);
            else if (liczba == 1) Console.WriteLine(+liczba + " wyraz ciagu wynosi: " + liczba);
            else
            {
                Int32 a = 0, b = 1;
                for (Int32 i = 2; i <= liczba; i++)
                {
                    wynik = a + b;
                    a = b;
                    b = wynik;
                };
                Console.WriteLine(+liczba + " wyraz ciagu wynosi: " + wynik);
            }*/

            // 6
            /*Int32 ile;
            Console.WriteLine("Podaj ile elementow ciagu fibonacciego mam obliczyc: ");
            ile = Int32.Parse(Console.ReadLine());
            Int32 [] tab = new Int32 [ile];
            Console.WriteLine();

            tab[0] = 0;
            tab[1] = 1;
            for (Int32 i = 0; i < ile; i++)
            {
                if (i > 1)
                {
                    tab[i] = tab[i - 1] + tab[i - 2];
                }
                Console.Write(tab[i] + ", ");
            }*/

            // 7
            /*Int32 liczba1 = 0, ilosc1 = 2;
            Console.WriteLine("Podaj liczbe a ja sprawdze czy jest liczba pierwsza: ");
            liczba1 = Int32.Parse(Console.ReadLine());

            for (Int32 i = 2; i < liczba1; i++)
            {
                if (liczba1 % i == 0) ilosc1++;
            }
            if (ilosc1 == 2) Console.WriteLine( + liczba1 + " jest liczba pierwsza");
            else Console.WriteLine( + liczba1 + " nie jest liczba pierwsza");*/

            // 8
            /*Int32 liczba1 = 0, liczba2 = 0;
            Console.WriteLine("Podaj przedzial liczb a ja sprawdze ktore z nich sa liczbami pierwszymi");
            liczba1 = Int32.Parse(Console.ReadLine());
            liczba2 = Int32.Parse(Console.ReadLine());

            while (liczba1 <= liczba2)
            {
                Int32 ilosc = 2;
                for (Int32 i = 2; i < liczba1; i++)
                {
                    if (liczba1 % i == 0) ilosc++;
                }
                if (ilosc == 2) Console.WriteLine(+liczba1 + " jest liczba pierwsza");
                liczba1++;
            }*/

            // 9

            //Podstawowy

            
            Int32 liczba1a = 1, liczba2 = 0, ileliczba = 0;
            Console.WriteLine("Do jakiej liczby mam znalezc liczby pierwsze");
            liczba2 = Int32.Parse(Console.ReadLine());

            /*Stopwatch watcha;
            watcha = Stopwatch.StartNew();

            for(Int32 j = 0; j <= liczba2; j++)
            {
                Int32 ilosca = 0;
                for (Int32 i = 1; i <= liczba1a; i++)
                {
                    if (liczba1a % i == 0) ilosca++;
                }
                if (ilosca == 2) ileliczba++;
                liczba1a++;
            }
            watcha.Stop();
            Console.WriteLine("Ilosc liczb pierwszych w danym przedziale to: " + ileliczba);
            Console.WriteLine("Czas: {0}", watcha.Elapsed);
            Console.WriteLine();

            // 10
            
            //Bez 1 i N
            Stopwatch watchb;
            Int32 liczba1b = 2, ileliczbb = 0;
            watchb = Stopwatch.StartNew();

            for (Int32 j = 0; j <= liczba2; j++)
            {
                Int32 iloscb = 2;
                for (Int32 i = 2; i < liczba1b; i++)
                {
                    if (liczba1b % i == 0) iloscb++;
                }
                if (iloscb == 2) ileliczbb++;
                liczba1b++;
            }
            watchb.Stop();
            Console.WriteLine("Ilosc liczb pierwszych w danym przedziale to: " + ileliczbb);
            Console.WriteLine("Czas: {0}", watchb.Elapsed);
            Console.WriteLine();

            //Do pierwszej wpadki

            Stopwatch watchc;
            Int32 liczba1c = 2, ileliczbc = 0;
            watchc = Stopwatch.StartNew();

            for (Int32 j = 0; j <= liczba2; j++)
            {
                Int32 iloscc = 2;
                for (Int32 i = 2; i < liczba1c; i++)
                {
                    if (liczba1c % i == 0) iloscc++;
                    if (iloscc == 3) break;
                }
                if (iloscc == 2) ileliczbc++;
                liczba1c++;
            }
            watchc.Stop();
            Console.WriteLine("Ilosc liczb pierwszych w danym przedziale to: " + ileliczbc);
            Console.WriteLine("Czas: {0}", watchc.Elapsed);
            Console.WriteLine();

            //Pierwiastek N

            Stopwatch watchd;
            Int32 liczba1d = 2, ileliczbd = 0;
            watchd = Stopwatch.StartNew();

            for (Int32 j = 0; j <= liczba2; j++)
            {
                Int32 iloscd = 2;
                for (Int32 i = 2; i <= Math.Floor(Math.Sqrt(liczba1d)); i++)
                {
                    if (liczba1d % i == 0) iloscd++;
                }
                if (iloscd == 2) ileliczbd++;
                liczba1d++;
            }
            watchd.Stop();
            Console.WriteLine("Ilosc liczb pierwszych w danym przedziale to: " + ileliczbd);
            Console.WriteLine("Czas: {0}", watchd.Elapsed);
            Console.WriteLine();*/

            //Sito eratostenesa

            Stopwatch watche;
            Int32 ileliczbe = 0, b = 0;
            Int32 [] tab = new Int32 [liczba2+1];
            watche = Stopwatch.StartNew();

            for(Int32 i = 1; i <= liczba2; i++)
            {
                tab[i] = i;
            }
            for(Int32 i = 2; i <= Math.Floor(Math.Sqrt(liczba2)); i++)
            {
                if(tab[i] != 0)
                {
                    b = i + i;
                    while(b <= liczba2)
                    {
                        tab[b] = 0;
                        b += i;
                    }
                }
            }
            watche.Stop();
            for (Int32 i = 2; i <= liczba2; i++)
            {
                if (tab[i] != 0)
                {
                    ileliczbe++;
                }
            }
            Console.WriteLine("Ilosc liczb pierwszych w danym przedziale to: " + ileliczbe);
            Console.WriteLine("Czas: {0}", watche.Elapsed);

            Console.ReadKey(true);
        }
    }
}
