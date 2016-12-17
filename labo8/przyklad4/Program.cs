using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace przyklad4
{
    class Program
    {
        static void Main(string[] args)
        {
            int rozmiar = 100;
            Random r = new Random();
            List<int> a = new List<int>(new int[rozmiar]);
            for (int i = 0; i < rozmiar; i++) a[i] = r.Next(100);

            WriteLine("początkowa kolekcja");
            foreach (int los in a) Write(" " + los.ToString());

            a.AddRange(new int[10]);
            int[] i5 = { -1, -1, -1, -1, -1 };

            a.InsertRange(rozmiar / 2, i5);
            a.Insert(0, 1);

            int j = 0;
            do
            {
                if ((int)a[j] > 20)
                    a.RemoveAt(j);
                else
                    j++;
            }
            while (j < a.Count);

            a.Sort();

            WriteLine("\n\n Końcówa kolekcja \n");
            foreach (int los in a) Write(" " + los.ToString());
            WriteLine("\n\n");
        }
    }
}
