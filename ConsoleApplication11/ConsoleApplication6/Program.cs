using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace ConsoleApplication6
{
    class Para<T>
    {
        private T _first = default(T), _second = default(T);

        public Para(T first,T second)
        {
            this._first = first;
            this._second = second;
        }
        public override string ToString()
        {
            return _first.ToString() + "\t" + _second.ToString();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            const int ile = 5;
            Random r = new Random();
            Para<int>[] pint = new Para<int>[ile];

            for (int i = 0; i < pint.Length; i++)
                pint[i] = new Para<int>(r.Next(10), r.Next(100));
            WriteLine("Demo para<int>");
            foreach (Para<int> para in pint)
                WriteLine(para.ToString());

            Para<string>[] pstr = new Para<string>[ile];

            pstr[0] = new Para<string>("ola", "olowska");
            pstr[1] = new Para<string>("uta", "utowska");
            pstr[2] = new Para<string>("web", "weboswki");
            pstr[3] = new Para<string>("ewa", "ebowska");
            pstr[4] = new Para<string>("jan", "jasinski");

            WriteLine("\nDemo Para<string>");
            foreach (Para<string> para in pstr)
                WriteLine(para.ToString());

            Read();
            
        }
    }
}
