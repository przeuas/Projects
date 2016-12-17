using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace labo8
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList();
            al.Add("ala");
            al.Add("ma");
            al.Add("kota");

            WriteLine("ilosc elementow: \t {0}", al.Count);
            WriteLine("Pojemnosc\t\t{0}", al.Capacity);
            Write("Wartosc: \t");
            foreach (Object obj in al)
                Write("{0}", obj);

            al.Add("a Ola");
            al.Add("ma ");
            al.Add("Asa ");

            al.Reverse();
            WriteLine("ilosc elementow: \t {0}", al.Count);
            WriteLine("Pojemnosc\t\t{0}", al.Capacity);
            Write("Wartosc po odwroceniu: \t");

            Write("Wartosc: \t");
            foreach (Object obj in al)
                Write("{0}", obj);
            al.Sort();
            Write("\n Wartosc po sortowaniu: \t");

            foreach (Object obj in al)
                Write("{0}", obj);

            Hashtable ht = new Hashtable();
            ht.Add("txt", "notepad.exe");
            ht.Add("bmp", "paint.exe");
            ht.Add("rtf", "wordpad.exe");

            WriteLine("ilosc elementow: \t {0}", ht.Count);
            WriteLine($"klucz {"bmp"}, wartosc{ht["bmp"]}");
            WriteLine();
            foreach(DictionaryEntry de in ht)
            {
                WriteLine($"klucz: { de.Key}, wartosc {de.Value}");

            }
            WriteLine("zawiera klucz? \t \t {0}", ht.ContainsKey("doc"));
            WriteLine("zawiera watosc? \t \t {0}", ht.ContainsValue("paint.exe"));


            ht.Clear();
            WriteLine($"ilosc elementow { ht.Count}");
            WriteLine("\n\n");


            NameValueCollection nvc = new NameValueCollection();
            nvc.Add("ssak", "człowiek");
            nvc.Add("płaz", "żaba");
            nvc.Add("gad", "krokodyl");
            nvc.Add("ssak", "małpa");

            WriteLine("wyswietlanie elementow z pomoca allkeys i item");
            PrintKeysAndValues(nvc);
            WriteLine("wyswietlanie elementow z pomoca GetKey i Get");
            PrintKeysAndValues2(nvc);

            WriteLine("indeks 1 zawira wartosc:  {0}", nvc[1]);
            WriteLine("klucz \"ssak\" zawiera wartosc {0}", nvc["ssak"]);
            String[] strArr = new String[nvc.Count];
            nvc.CopyTo(strArr, 0);
            WriteLine("tablica napisow zawaiera");
            foreach (String s in strArr)
                WriteLine("\t{0}", s);
            WriteLine();

            nvc.Remove("płaz");
            WriteLine("kolekcja po wyczyszczeniu");
            PrintKeysAndValues(nvc);


            Read();


        }
        private static void PrintKeysAndValues(NameValueCollection myCol)
        {
            IEnumerator myEnum = myCol.GetEnumerator();
            WriteLine("\t klucz \t wartosc");
            foreach (String s in myCol.AllKeys)
                WriteLine("t{0} \t{1}", s, myCol[s]);
            WriteLine();
        }
        private static void PrintKeysAndValues2(NameValueCollection myCol)
        {
            WriteLine("\t klucz \t wartosc");
            for(int i = 0; i< myCol.Count; i++)
            
                WriteLine("\t[{0}] \t{1}\t[{2}]", i, myCol.GetKey(i), myCol.Get(i));
            WriteLine();
            
        }
    }
}
