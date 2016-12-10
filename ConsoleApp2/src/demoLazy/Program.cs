using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static System.Console;

namespace demoLazy
{
    class Test
        {
        int[] _array;
        public Test()
        {
            WriteLine("Test()");
            _array = new int[100];
        }
        public int Length
        {
            get
            {
                return _array.Length;
            }
        }
        }


    public class Program
    {
        public static void Main(string[] args)
        {
            Lazy<int> li = new Lazy<int>(() => 1);
            WriteLine(li.IsValueCreated);
            WriteLine("odwolanie do zmiennej li" + li.Value);
            WriteLine(li.IsValueCreated);

            WriteLine(li);

            Lazy<Test> lazy = new Lazy<Test>();

            WriteLine("is value created = {0}", lazy.IsValueCreated);

            Test test = lazy.Value;

            WriteLine("is value created = {0}", lazy.IsValueCreated);

            WriteLine("rozmiar = {0}", test.Length);
            ReadLine();
        }
    }
}
