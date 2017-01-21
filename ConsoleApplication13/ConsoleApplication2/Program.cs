using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    public class MathOp
    {
        public double MultiplyBy3(double x) => x *3;
        public double Square(double x) => x * x;
    }
    delegate double DoubleOp(double x);
    class Program
    {
        static void Main(string[] args)
        {
           // OutputEncoding = GetEncoding("UTF-8");
            MathOp mo = new MathOp();

            DoubleOp[] operations =
            {
                mo.MultiplyBy3,
                mo.Square
            };
            for(int i = 0; i < operations.Length;i++)
            {
                Console.WriteLine($"Wywolanie operations{i}:");
                ProcessAndDisplay(operations[i], 2.0);
                ProcessAndDisplay(operations[i], 2.71);
                ProcessAndDisplay(operations[i], 3.14);
                Console.WriteLine();
               
            }
            Console.Read();
        }
        static void ProcessAndDisplay(DoubleOp action,double value)
        {
            double result = action(value);
            Console.WriteLine($"argument:{value};wynik operacji: {result}");
        }
    }
}
