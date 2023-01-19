using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {

            //1

            /*Int32 [] tab1 = new Int32[20];
            Random liczba = new Random();
            for (Int32 i = 0; i < 20; i++)
            {
                tab1[i] = liczba.Next(0, 9);
                Console.Write(i);
                Console.Write(":");
                Console.Write(tab1[i]);
                Console.Write(" ");
            }*/

            //2

            /*Int32[] tab1 = new Int32[10] {9,8,7,6,5,4,3,2,1,0};
            for (Int32 i = 0; i < 10; i++)
            {
                Console.Write(i);
                Console.Write(":");
                Console.Write(tab1[i]);
                Console.Write(" ");
            }*/

            //4

            /*Int32[,] tab1 = new Int32[4, 6];
            Random liczba = new Random();
            Int32 a;
            for (Int32 i = 0; i < 4; i++)
            {
                for (Int32 j = 0; j < 6; j++)
                {
                    tab1[i, j] = liczba.Next(100, 999);
                }
            }
            for (Int32 i = 0; i < 4; i++)
            {
                for (Int32 j = 0; j < 6; j++)
                {
                    Console.Write(tab1[i, j] + " ");
                }
                Console.WriteLine();
            }
             * 
            //wersja druga zadania 4
             * 
            Int32[,] tab1 = new Int32[4, 6];
            Random liczba = new Random();
            for (Int32 i = 0; i < 4; i++)
            {
                for (Int32 j = 0; j < 6; j++)
                {
                    tab1[i, j] = liczba.Next(100, 999);
                    Console.Write(tab1[i, j] + " ");
                }
                Console.WriteLine();
            }*/

            //5

            /*Int32[,] tab1 = new Int32[4, 6];
            Int32[,] tab2 = new Int32[6, 4];
            Random liczba = new Random();
            Int32 suma = 0, maks = 100 ,mini = 1000 , a = 0, b = 0, c = 0, d = 0;
            for (Int32 i = 0; i < 4; i++)
            {
                for (Int32 j = 0; j < 6; j++)
                {
                    tab1[i, j] = liczba.Next(100, 999);
                    tab2[j, i] = tab1[i, j];
                    suma += tab1[i, j];
                    if (tab1[i, j] > maks)
                    {
                        maks = tab1[i, j];
                        a = i; 
                        b = j;
                    }
                    if (tab1[i, j] < mini)
                    {
                        mini = tab1[i, j];
                        c = i;
                        d = j;
                    }
                    Console.Write(tab1[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            for (Int32 i = 0; i < 6; i++)
            {
                for (Int32 j = 0; j < 4; j++)
                {
                    Console.Write(tab2[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("Suma= " + suma);
            Console.WriteLine("Maks= " + maks);
            Console.WriteLine("Wiersz: " + a + " Kolumna: " + b);
            Console.WriteLine("Mini= " + mini);
            Console.WriteLine("Wiersz: " + c + " Kolumna: " + d);
            Console.ReadKey(true);*/

            //6

            /*Int32[,] tab1 = new Int32[10, 10];
            Random liczba = new Random();
            String tekst;
            for (Int32 i = 0; i < 10; i++)
            {
                for (Int32 j = 0; j < 10; j++)
                {
                    tab1[i, j] = liczba.Next(0, 999);
                    Int32 a = tab1[i, j];
                    tekst = a.ToString();
                    if (tekst.Length == 1) tekst += "  ";
                    if (tekst.Length == 2) tekst += " ";
                    Console.Write(tekst + " ");
                }
                Console.WriteLine();
            }*/
            Console.ReadKey(true);
        }
    }
}
