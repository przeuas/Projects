using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    public delegate int BinaryOp(int x, int y);
    public class Licz
    {
        public int Add(int x,int y)
        {
            return x + y;
        }
        public int Sub(int x, int y)
        {
            return x - y;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("delegat wielokrotny- typ zdefiniowany");
            Licz m = new Licz();
            BinaryOp deleg1;
            deleg1 = m.Add;
            deleg1 += m.Sub;
            Console.WriteLine("2+2 = {0},", deleg1(2, 2));
            Console.ReadKey();
            Console.WriteLine("Delegat wieloktrotny - typ geberyczny Func<>");
            Func<int, int, int> deleg2;
            deleg2 = m.Add;
            deleg2 += m.Sub;
            Console.WriteLine("2+2 = {0}", deleg2(2, 2));
            Console.Read();
            
        }
    }
}
