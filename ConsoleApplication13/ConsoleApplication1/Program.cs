using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public delegate void TestDeleg(string s);
    class Program
    {
        static void StringPrinter(string s)
        {
            Console.Write(s);
        }
        static void Main(string[] args)
        {
            TestDeleg delegA = new TestDeleg(StringPrinter);
            TestDeleg delegAA = StringPrinter;

            TestDeleg delegB = delegate (string s) { Console.WriteLine(s); };

            TestDeleg delegC = (x) => { Console.WriteLine(x); };

            delegA("Mam nazwe");
            delegAA("mam nazwe v2");
            delegB("jestem anonimowa");
            delegC("jestem wyrazeniem lambda");
            delegA = null;
            delegB = null;
            delegC = null;

            int? a = 3;
            int? b = null;

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(a*b);

            Console.Read();
        }
    }
}
