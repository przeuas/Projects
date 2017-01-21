using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication13
{
    class Program
    {
        public delegate int BinaryOp(int x, int y);
        public class Licz
        {
            public int Add(int x,int y) { return x + y;}
            public int Sub(int x,int y) { return x - y;}
        }
        static void Main(string[] args)
        {
            Console.WriteLine("delegat- demo metod instancyjnych");

            Licz m = new Licz();
            BinaryOp b = m.Add;
            Console.WriteLine("2+2= {0}", b(2, 2));
            b = m.Sub;
            Console.WriteLine("5-1 ={0}", b(5, 1));
            Console.Read();
        }
    }
}
