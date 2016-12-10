using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ConsoleApplication1
{
    public class A:ICloneable
    {
        public int a;
        public Object Clone()
        {
            return MemberwiseClone();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            A a1 = new A();
            A a2 = new A();
            a1.a = 7;
            a2 = (A)a1.Clone();
            WriteLine("a2.a = {0}", a2.a);

            a1.a = 100;
            WriteLine($"a2.a = {a2.a}\na1.a={a1.a}");

            if (Object.ReferenceEquals(a1, a2))
                WriteLine("referencje a1 i a2 odwoluja sie do tego samego obiektu");
            else
                WriteLine("referencje a1 i a2 nie odwoluja sie do tego samego obiektu");
            Read();
        }

    }
}
