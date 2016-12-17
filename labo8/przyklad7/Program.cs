using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace przyklad7
{
    class Program
    {
        static void Main(string[] args)
        {
            var alphabet = new Stack<char>();
            alphabet.Push('A');
            alphabet.Push('B');
            alphabet.Push('C');
            Write("przegladanie stosu");

            foreach(char item in alphabet)
            {
                Write(item);
            }
            WriteLine("\n stos nie pusty? {0} ", alphabet.Contains('A'));

            Write("\n Sciaganie ze stosu: ");
            while(alphabet.Count > 0)
            {
                Write(alphabet.Pop());
            }
            WriteLine("\n stos nie pusty? {0} ", alphabet.Contains('A'));


            var books = new SortedList<string, string>();
            books.Add("podstawy architektury i technologii uslug XML sieci web","16165161");
            books.Add("asp.net tubo programowanie", "5156135156");

            books["asdfasdfasdf"] = "asdfasdfasdfvvasdf";
            books["uslugi azure"] = "djsmasinggaz";

            WriteLine("lista posotrowane wg klucza");
            foreach (string isbnn in books.Values)
            {
                WriteLine(isbnn);
            }
            WriteLine("klucze tytuly ksiazek");
            foreach (string titlee in books.Keys)
                WriteLine(titlee);
            WriteLine();
            string isbn;
            string title = "jezyk c# 7.0";
            if(!books.TryGetValue(title,out isbn))
            {
                WriteLine("{0} - nie znaleziono", title);
            }


            string[] colors = { "red", "blue", "green", "orange" };
            LinkedList<string> ll = new LinkedList<string>(colors);

            Display(ll, "wartosc listy: ");
            ll.AddFirst("white");
            Display(ll, "test 1");

            LinkedListNode<string> mark1 = ll.First;
            ll.RemoveFirst();
            ll.AddLast(mark1);
            Display(ll, "test 2 ");

            LinkedListNode<string> mark2 = ll.First.Next;

            ll.Remove(mark2);

            Display(ll, "test 3");

         





            Read();

        }
        private static void Display(LinkedList<string> words, string test)
        {
            WriteLine(test);
            foreach (string word in words)
            {
                Write(word + " ");
            }
            WriteLine();
            WriteLine();

        }



    }
}
