using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication9
{
    public delegate void DemoDeleg();
    class Program
    {
        static void Met1()
        {
            Console.WriteLine("Metoda 1");
            throw new Exception("blad w metoda 1");
        }
        static void Met2()
        {
            Console.WriteLine("metoda 2");

        }
        static void Met3()
        {
            Console.WriteLine("metoda 3");
        }
        static void Main(string[] args)
        {
            DemoDeleg deleg1;
            deleg1 = Met1;
            deleg1 += Met1;
            deleg1 += Met3;

            Delegate[] deleg = deleg1.GetInvocationList();
            
            foreach(DemoDeleg d2 in deleg)
            try
                {
                    d2();
            }catch(Exception e)
            {
                Console.Write("wyjatek info" + e.Message);
            }
            Console.WriteLine("\nPrzyklad 2- delegat Action");
            Action deleg2;
            deleg2 = Met1;
            deleg2 += Met2;
            deleg2 += Met3;

            Delegate[] delegA = deleg2.GetInvocationList();
            foreach(Action d2 in delegA)
                try
                {
                    d2();
                }catch(Exception e)
                {
                    Console.WriteLine("wyjatek info" + e.Message);
                }


            Console.ReadKey();
        }
    }
}
