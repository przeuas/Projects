using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    public delegate void Dodaj(ref int z);
    public class Licz
    {
        public void Add1(ref int z)
        {
            z++;
        }
        public void Add2(ref int z)
        {
            z += 2;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("Delegat wielokrotny, param ref");

            Licz m = new Licz();
            Dodaj deleg1;
            deleg1 = m.Add1;
            deleg1 += m.Add2;

            a = b = 1;
            deleg1(ref a);
            Console.WriteLine("a ={0},b = {1}",a,b);


            deleg1(ref a);
            Console.WriteLine("a ={0},b = {1}", a, b);

            deleg1 -= m.Add2;
            deleg1(ref a);
            
            Console.WriteLine("a ={0},b = {1}", a, b);

            Console.Read();

        }
    }
}
