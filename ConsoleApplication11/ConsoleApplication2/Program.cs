using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ConsoleApplication2
{
    class A
    {
        public int a;
        public B objB;

        public A()
        {
            objB = new B();
        }
        public A DeepCopy()
        {
            A tempA = new A();
            tempA.a = this.a;
            tempA.objB.word1 = this.objB.word1;
            tempA.objB.word2 = this.objB.word2;
            return tempA;
        }
    }
    class B
    {
            public string word1;
            public string word2;
        
    }

    
    class Program
    {
        static void Main(string[] args)
        {
            A a1 = new A();
            A a2 = new A();

            a1.a = 7;
            a1.objB.word1 = "prtosty przyklad";
            a1.objB.word2 = "kopii glebokiej";

            a2 = a1.DeepCopy();

            WriteLine($"a2.a = {a2.a}");
            WriteLine($"a2.objB.word1 = {a2.objB.word1 }");
            WriteLine($"a2.objB.word2 = {a2.objB.word2 }");

            if (Object.ReferenceEquals(a1, a2))
                WriteLine("referencje a1 i a2 odwoluja sie do tego samego obiektu \n");
            else
                WriteLine("refereencje a1 i a2 nie odwoluja sie do tego samego obiektu\n");
            ReadKey();
        }
    }
}
