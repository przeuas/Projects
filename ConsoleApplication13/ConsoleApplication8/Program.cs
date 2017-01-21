using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication8
{

    public delegate void DemoDeleg();
    class Program
    {
        static void Met1()
        {
            Console.WriteLine("Metoda 1");
            throw new Exception("Bład w Metoda 1");

        }
        static void Met2()
        {
            Console.WriteLine("Metoda 2");
        }


        static void Main(string[] args)
        {
            DemoDeleg deleg1;
            deleg1 = Met1;
            deleg1 += Met2;

            try
            {
                deleg1();
            }catch(Exception)
            {
                Console.WriteLine("wyjatek przechwycony");
                Console.WriteLine("koniec iteracji w deleg 1");
            }
            Action deleg2;
            deleg2 = Met1;
            deleg2 = Met2;
            try
            {
                deleg2();
            }catch(Exception)
            {
                Console.WriteLine("wyjatek przechwycony");
                Console.WriteLine("koniec iteracji w deleg 2");
            }
            Console.ReadKey();
        }
    }
}
