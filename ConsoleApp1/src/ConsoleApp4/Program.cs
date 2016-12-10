using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static System.Console;
namespace ConsoleApp4
{
    public class Program
    {
        public static void Main(string[] args)
        {
            DateTime teraz = DateTime.Now;
            WriteLine("teraz:{0:U}", teraz);
            WriteLine("teraz:{0:s}", teraz);
            WriteLine();
           DateTime data = new DateTime(2016, 12, 31, 21,35, 15, 789);
            WriteLine("d:{0:d}", data);
            WriteLine("d:{0:D}", data);

            Read();
        }
    }
}
