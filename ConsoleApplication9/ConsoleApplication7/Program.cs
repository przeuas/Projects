using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace ConsoleApplication7
{
    class Program
    {
        static void Main(string[] args)
        {
            Decimal ep = 1e-28M;
            WriteLine("byte\nmin: {0} ,max{1},rozmiar: {2},domsylna wartosc { 3}\n",
                Byte.MinValue, Byte.MaxValue, sizeof(Byte), default(byte));
            WriteLine("int\n min :{0},max:{1}\n", Int32.MinValue, Int32.MaxValue);

            WriteLine("ulong\n min :{0},max:{1}\n", UInt64.MinValue, UInt64.MaxValue);

            WriteLine("float\nepsilon min :{0},max:{1}\n", Single.Epsilon, Single.MinValue, Single.MaxValue);

            WriteLine("decimal min :{0},max:{1}\n domyslna wartosc", Decimal.MinValue, Decimal.MaxValue, default(Decimal));
            Read();
        }
    }
}
