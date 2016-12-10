using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static System.Text.Encoding;
using static System.Console;

namespace Kalkulator2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int a, b;
            WriteLine("Aplikacja kalkulator v2");
            Write("a");

            try
            {
                a = Int32.Parse(ReadLine());
                Write("b");
                b = Int32.Parse(ReadLine());

                Kalk k = new Kalk();
                WriteLine($"\n{a} + {b} = {k.Add(a, b)}");
                WriteLine($"\n{a}  {b} = {k.Sub(a, b)}");
                WriteLine($"\n{a} * {b} = {k.Mul(a, b)}");
                WriteLine($"\n{a} / {b} = {k.Div(a, b)}");

                WriteLine($"\n{a} % {b} = {k.Rem(a, b)}");
                WriteLine($"\n{a} ^ {b} = {k.Pow(a, b)}");
            }
            catch(Exception e)
            {
                if (e.Message == "Attempted to dividde by zero")
                     WriteLine("nie mozna pliku znalezc");


                if (e.Message == "Input string was not in a correct format") 
                    WriteLine("niepoprawny foramat argumentu");
                else WriteLine("nieoczekiwany blad");
            }
        }
        internal class Kalk
        {
            public int Add(int x, int y) => x + y;
            public int Sub(int x, int y) => x - y;
            public int Mul(int x, int y) => x * y;
            public int Div(int x, int y) => x / y;

            public int Rem(int x, int y) => x % y;

            public int Pow(int x, int y)
            {
                int tmp = 1;
                for(int i = 1;  i <y; i++)
                {
                    tmp *= x;

                }
                return tmp;
            }
        }
    }
}
