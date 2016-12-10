using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace demoKalkulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            WriteLine("aplikacja kalkulator");
            Write("a");
            try
            {
                a = Int32.Parse(ReadLine());
                Write("b:");
                b = Int32.Parse(ReadLine());

                Kalk k = new Kalk();

                WriteLine($"n{a} + {b} = {k.Add(a, b)}");
                WriteLine($"n{a} - {b} = {k.Sub(a, b)}");
                WriteLine($"n{a} * {b} = {k.Mul(a, b)}");
                WriteLine($"n{a} / {b} = {k.Div(a, b)}");
                WriteLine($"n{a} % {b} = {k.Rem(a, b)}");
                WriteLine($"n{a} ^ {b} = {k.Pow(a, b)}");

                a = Int32.Parse(ReadLine());
            }
            catch(Exception e)
            {
                WriteLine("niepoprawny argument");
            }


        }
        internal class Kalk
        {
            public int Add(int x,int y)
            {
                return x + y;
            }
            public int Sub(int x, int y)
            {
                return x - y;
            }
            public int Mul(int x, int y)
            {
                return x * y;
            }
            public int Div(int x, int y)
            {
                return x / y;
            }
            public int Rem(int x, int y)
            {
                return x % y;
            }
            public int Pow(int x, int y)
            {
                int tmp = x;
                for (int i = 1; i <= y; i++)
                    tmp *= i;

                   return tmp;
            }

        }
    }
}
