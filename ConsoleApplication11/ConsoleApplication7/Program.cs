using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ConsoleApplication7
{
    class Para<T>
    {
        private T _first = default(T), _second = default(T);

        //konstruktor
        public Para(T first, T second)
        {
            this._first = first;
            this._second = second;
        }
        public override string ToString()
        {
            return _first.ToString() +"\t " + _second.ToString();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            const int ile = 5;
            Random r = new Random();
            Para<int>[] pint = new Para<int>[ile];
            for(int i=0; i< pint.Length; i++)
            {
                pint[i] = new Para<int>(r.Next(10), r.Next(100));
            }
            WriteLine("demo para<int>");
            foreach (Para<int> para in pint)
                WriteLine(para.ToString());
                 

        }
        

    }
}
