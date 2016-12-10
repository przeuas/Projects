using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication8
{
    class Para<T>: IComparable<Para<T>> where T: IComparable<T>
    {
        private T _first = default(T), _second = default(T);
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
