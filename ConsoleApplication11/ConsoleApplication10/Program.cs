using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ConsoleApplication10
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public override string ToString()
        {
            return String.Format($"{FirstName}{LastName}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person[] per1 = new Person[2];
            per1[0] = new Person { LastName = "abacki", FirstName = "Adam" };
            per1[1] = new Person { FirstName = "Karolina", LastName = "Kabacka" };
            foreach (var i in per1) WriteLine(i.ToString());
            WriteLine();

            Person[] per2 =
            {
                new Person {FirstName = "Witold" ,LastName = "Wbowski" },
                new Person {FirstName= "Irena" , LastName = "ibowska" },
                new Person {FirstName = "Marek" , LastName = "Mabowski" }
            };
            foreach (var i in per2) WriteLine(i.ToString());
            WriteLine();

            int[] intArray1 = { 10, 11 };
            int[] intArray2 = (int[])intArray1.Clone();
            intArray2[0] = 20;

            foreach (var i in intArray1) Console.WriteLine(i);
            foreach (var i in intArray2) Console.WriteLine(i);
            Console.WriteLine();
            Person[] per11 =
           {
                new Person {FirstName = "Witold" ,LastName = "Wbowski" },
                new Person {FirstName= "Irena" , LastName = "ibowska" },
                new Person {FirstName = "Marek" , LastName = "Mabowski" }
            };
            Person[] per22 = (Person[])per11.Clone();
            foreach (var i in per11) Console.WriteLine(i);
            Console.WriteLine();
            foreach (var i in per22) Console.WriteLine(i);
            /////////////////////////////////////

            int[] losy = new int[20];
            Random r = new Random();
            for (int indeks = 0; indeks < losy.Length; indeks++)
                losy[indeks] = r.Next(100);
            WriteLine("tablica nieposortowana");
            foreach (int los in losy)
                WriteLine(" " + los.ToString());
            Array.Sort(losy);

            WriteLine("\n\n\nTablica posortowana: \n");
            foreach (int los in losy)
                Write(" " + los.ToString());

            Read();



        }
    }
}
