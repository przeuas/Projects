using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("demo kolekcji list<T> instantowanej typem 'string'");
            List<string> names = new List<string>();

            WriteLine($"\nTyp:{names.GetType()}");
            WriteLine($"Pojemnosc poczatkowa:{ names.Capacity}");

            names.Add("Tomasz");
            names.Add("Anna");
            names.Add("Marek");
            names.Add("Dariusz");
            names.Add("Calina");
            WriteLine();

            foreach(string name in names)
            {
                WriteLine(name);
            }
            WriteLine($"\nPojemnosc: { names.Capacity}");
            WriteLine("ilosc: {0}", names.Count);

            WriteLine("\nCzy zawiera? (\"Dariusz\" : {0}", names.Contains("Dariusz"));

            WriteLine("\nWstaw(2,\"Cezary\")");
            names.Insert(2, "Cezary");

            WriteLine();

            foreach(string name in names)
            {
                WriteLine(name);
            }
            names.TrimExcess();
            WriteLine("\nWyrownaj pojemnosc i licznosc()");
            WriteLine($"\nPOjemnosc:{names.Capacity}");
            WriteLine($"ilosc:{names.Count}");
            names.Clear();
            WriteLine("Usun wszystko!");
            WriteLine($"\nPojemnosc: {names.Capacity}");
            WriteLine($"ilosc:{names.Count}");
            Read();
        }
    }
}
