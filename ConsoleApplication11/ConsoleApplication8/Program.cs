using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ConsoleApplication8
{
    class Para<T>: IComparable<Para<T>> where T: IComparable<T>
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
        public int CompareTo(Para<T> innaPara)
        {
            int wart = this._first.CompareTo(innaPara._first);
            if (wart != 0) return wart;
            else return this._second.CompareTo(innaPara._second);
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
            WriteLine("ParaInt");
            foreach (Para<int> para in pint)
                WriteLine($"\t{para.ToString()}");
            Array.Sort(pint);

            Para<string>[] pstr = new Para<string>[ile];

            pstr[0] = new Para<string>("ola", "olowska");
            pstr[1] = new Para<string>("uta", "utowska");
            pstr[2] = new Para<string>("web", "weboswki");
            pstr[3] = new Para<string>("ewa", "ebowska");
            pstr[4] = new Para<string>("xan", "jasinski");

            WriteLine("\nPara<string>");
            foreach (Para<string> para in pstr)
                WriteLine($"\t {para.ToString()}");
            Array.Sort(pstr);
            WriteLine("\nPara<string> po posortowaniu");
            foreach(Para<string> para in pstr)
                WriteLine($"\t{para.ToString()}");
            Read();

        }
    }
}
