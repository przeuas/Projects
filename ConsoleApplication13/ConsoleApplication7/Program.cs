using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7
{

    public delegate int BinaryOp(int x,int y);
    
    public class Licz
    {
        public int Add(int x, int y)
        {
            Console.WriteLine("dodawanie");
            return x + y;
        }
        public int Sub(int x, int y)
        {
            Console.WriteLine("odejmowanie");
            return x - y;
        }
        public int Div(int x, int y)
        {
            Console.WriteLine("dzielenie");
            return x / y;
        }


    }
    class MultiDemo
    {
        static void DelegateInfo(Delegate deleg)
        {
            Console.WriteLine("\ninfo 1 - własciowawosc target");
            foreach (Delegate d in deleg.GetInvocationList())
            {
                Console.WriteLine("Nazwa typu : {0}", d.Target);
            }
            Console.WriteLine("\ninfo 2 - wlasciwosc Method");
            foreach (Delegate d in deleg.GetInvocationList())
            {
                Console.WriteLine("Nazwa metody : {0}", d.Method);
            }
        }
   
        static void Main(string[] args)
        {
            Console.WriteLine("info o metodach zerejestrowanych w delegacie");

            Licz m = new Licz();

            BinaryOp b;
            b = m.Add;
            b += m.Div;
            b += m.Sub;

            DelegateInfo(b);
            
            Console.WriteLine("\nWywolalnie metod docelowych delegatu");

            Console.WriteLine("5 -1 = {0}", b(5, 2));
            Console.ReadKey();

            b -= m.Div;
            DelegateInfo(b);
            Console.ReadKey();


        }
    }
}
