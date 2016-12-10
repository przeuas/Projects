using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace demoTypyRefer
{
    class Program
    {
        public class Punkt
        {
            public int X, Y; 
        }
        static void Main(string[] args)
        {
            Punkt p1 = new Punkt();
            WriteLine(p1.X);

            p1.X = 7;
            Punkt p2 = new Punkt();
            p2 = p1;

            WriteLine(p1.X);
            WriteLine(p2.X);

            p1.X = 13;

            WriteLine(p1.X);
            WriteLine(p2.X);

            WriteLine(p1.Y);
            WriteLine(p2.Y);

            Read();
        }
    }
}
