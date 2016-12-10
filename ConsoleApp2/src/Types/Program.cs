using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static System.Console;
using static System.Text.Encoding;

namespace Types
{
    public class Program
    {
        public static void Main(string[] args)
        {
            OutputEncoding = GetEncoding("UTF-8");
            InputEncoding = GetEncoding("UTF-8");

            dynamic d = 5;
            WriteLine("Aktualny typ zmiennej d {0}", d.GetType().FullName);
            d++;
            WriteLine("bieżaca wartosc zmiennej d {0}", d);
            d = 5.5;
            WriteLine("Aktualny typ zmiennej d {0}", d.GetType().FullName);
            d++;
            WriteLine("bieżaca wartosc zmiennej d {0}", d);

            d = 'A';

            WriteLine("Aktualny typ zmiennej d {0}", d.GetType().FullName);
            d++;
            WriteLine("bieżaca wartosc zmiennej d {0}", d);

            d = "To napis";

            WriteLine("Aktualny typ zmiennej d {0}", d.GetType().FullName);
                   WriteLine("bieżaca wartosc zmiennej d {0}", d);

            WriteLine("Nacisnij enter aby wywolac wyjatek");
            ReadLine();
            try
            {
                d++;
                WriteLine("bierzaca wartosc d : {0}" + d + "\n");
            }
            catch(Exception e)
            {
                WriteLine("Zmienna dynamiczna/wyjatek" + e.Message);
            }
            ReadLine();

        }
    }
}
