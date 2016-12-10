using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("witaj, spytam Cie o imie iwiek");
            Console.Write("podaj imię");
            string imie = Console.ReadLine();
            if(imie.Length ==0)
            {
                Console.Error.WriteLine("\n\nBlad, nie podales imienia");
                return;
            }
            Console.Write("ile masz lat");
            int wiek;
            try
            {
                wiek = Convert.ToInt32(Console.ReadLine());

            }
            catch(Exception)
            {
                Console.Error.WriteLine("blad! nie podales liczby calkowitej");
                return;
         
            }
            Console.WriteLine("Nacisni enter");
            Console.Read();
        }
    }
}
