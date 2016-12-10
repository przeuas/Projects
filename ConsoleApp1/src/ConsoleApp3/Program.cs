using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static System.Console;
using static System.Text.Encoding;
using static System.Console;
//using struct System.Decimal;
namespace ConsoleApp3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            OutputEncoding = GetEncoding("UTF-16");
            InputEncoding = GetEncoding("UTF-16");

            Write("Przyklad 1 - tylko indeks parametru\n");
            int i = 10;
            int j = 20;
            WriteLine("{0} {1} + {2} = {3} ", "dzialanie: ", i, j, i + j);

            Write("Przyklad 2 - tylko indeks parametru szerokosc pola\n");
             i = 940;
            j = 73;
            WriteLine("{0,4}\n + {1,4}\n----\n  ", i, j, i + j);



            Write("Przyklad 3 - tylko indeks parametru , szerokosc pola , łancuch formatu\n");
            decimal k = 940.23m;
            decimal  n= 73.7m;
            WriteLine($"{k,12:C1}\n + {n,12:C1}\n----\n  , { k + n,12:C1} ");

            Read();
         
        }
    }
}
