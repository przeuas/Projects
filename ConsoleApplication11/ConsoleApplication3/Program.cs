using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ConsoleApplication3
{
    public static class MyExtension
    {

    
        public static int WordCount(this String str)
        {
            return str.Split(new char[] { ' ', '.', ',', '?' },
                StringSplitOptions.RemoveEmptyEntries).Length;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string s = "Demo metody rozszerzajacej";
            int i = s.WordCount();
            WriteLine("i:{0}", i);
            s = "jeden dwa,trzy.cztery pięć sześć?siedem?osiem!dziewieć";
            i = s.WordCount();
            WriteLine("i:{0}", i);
            Read();
        }
    }
}
