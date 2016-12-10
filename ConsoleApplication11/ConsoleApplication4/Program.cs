using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ConsoleApplication4
{
   
    class Program
    {
        static void Swap<T>(ref T x, ref T y)
        {
            T temp;
            temp = x;
            x = y;
            y = temp;
        }
        static void Main(string[] args)
        {
            double a = 1.234;
            double b = 5.567;
            //OutputEndocing = GetEncoding("UTF-8');

            WriteLine($"a,b  - przed zamiana \nna {a}\t b= {b}\n");
            Swap<double>(ref a, ref b);

            WriteLine($"a,b  - po zamianie \nna {a}\t b= {b}\n");

            decimal e = 2.7182818M;
            decimal pi = 3.1415926553M;
            WriteLine($"e,pi - przed zamiana\ne= {e}\t pi{pi}\n");
            Swap(ref e, ref pi);
            WriteLine($"e,pi - po zamianie\ne= {e}\t pi{pi}\n");
            Read();
               
        }
    }
}
