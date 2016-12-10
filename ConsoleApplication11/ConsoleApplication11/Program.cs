using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ConsoleApplication11
{
    public class A
    {
        public int a;
    }
    class Program
    {
        static void Main(string[] args)
        {
            A a1 = new ConsoleApplication11.A();
            a1.a = 5;

            A a2 = new A();
            a2 = a1;
            WriteLine("a2.a - {0}", a2.a);

            a1.a = 100;
            WriteLine("a2.a - {0}", a2.a);
            Read();
        }
    }
}
