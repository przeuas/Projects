using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static System.Text.Encoding;
using static System.Console;
using System.Collections;

namespace ConsoleApp1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            WriteLine("\n#################instrukcja if#####################\n");
            string dzien;
            OutputEncoding = GetEncoding("UTF-16");
            InputEncoding = GetEncoding("UTF-16");
            dzien = ReadLine();
            if (dzien == "poniedzialek")
                WriteLine(".Net-labo\u263A\n");
            else if (dzien == "wtorek")
                WriteLine(".Net-labo\u263A\n");
            else if (dzien == "środa")
                WriteLine(".Net-wyklad\u263A\n");
            else if (dzien == "czwartek")
                WriteLine(".Nuda\n");
            else if (dzien == "piątek")
                WriteLine(".prawie Weekend\n");
            else if (dzien == "sobota")
                WriteLine(".Weekend\n");
            else if (dzien == "niedziela")
                WriteLine(".Weekend\n");
            else
                WriteLine("Nazwa nie znana");


            
            WriteLine("\n################# instrukcja switch #####################\n");
            string dzien2;
            dzien2 = ReadLine();
            switch(dzien2)
            {
                case "poniedzialek":
                case "wtorek":
                    WriteLine(".Net-labo");break;
                case "sroda":
                    WriteLine(".Net-wyklad"); goto case "piatek";
                case "Czwartek":
                    WriteLine("Jakies wyklady"); break;
                case "piatek":
                    WriteLine(".prawie Weekend\n");break;
                case "sobota":
                case "niedziela":
                    WriteLine("Weekend");break;
            
             }
            int i = 0;
            do
            {
                WriteLine(i + "kocham dotNeta");
                ++i;
            } while (i < 10);

            for ( i = 0; i < 10; i++)
                WriteLine(i);


            i = 0;
            while(i < 10)
            {
                WriteLine(i);
                i++;
            }
            

            const int max = 100;
            const int kol = 10;
            OutputEncoding = GetEncoding("UTF-8");
            WriteLine("Przyklad zagniezdzonego for");

            for (int ii = 0; ii <= 9; ii++) 
                for (int j = 0; j <= 9; j++)
                {
                    Write($"{j,-4}");
                }



            WriteLine("\n\nprzyklad  z tablica foreach z Tablica 2d");
            int [,] tab2D = new int[3, 2]{ { 1,11},{ 2,22},{ 3,33} };
            foreach (int m in tab2D)
            {
                Write($"{m,4}");
            }

            WriteLine("przyklad z tablica 1d");
            int[] tab1D = new int[10];
            for ( i = 0; i < 10; tab1D[i++] = i) ;
            foreach(int k in tab1D)
            {
                Write($"{k,4}");
            }
            ArrayList anArrayList = new ArrayList();
            for(int n = 0; n< 10;++i)
            {
                anArrayList.Add(tab1D[i]);

            }
            anArrayList.Add(100);

            WriteLine("\n\nprzyklad 'foreach' listy z kolekcja ArrayList:");

            foreach(int number in anArrayList)
            {
                Write($"{ number,4}");
            }
            

            Read();
        }
    }
}
