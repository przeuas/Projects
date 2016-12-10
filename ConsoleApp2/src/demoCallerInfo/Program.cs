using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static System.Text.Encoding;
using static System.Console;

namespace demoCallerInfo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Info info = new Info();
            OutputEncoding = GetEncoding("UTF-16");
            InputEncoding = GetEncoding("UTF-16");

            WriteLine("witaj, spytam ci o imie i wiek!");
            Write("podaj imie");
            string imie = ReadLine();

            if(imie.Length == 0)
            {
                Error.WriteLine("\n Blad, nie podales imienia!\n");
                info.WyswietlDane("test 1");
                return;
            }
            Write("ile masz lat?");

            int wiek;

            try
            {
                wiek = int.Parse(ReadLine());
            }catch(Exception e)
            {
                Error.WriteLine("\n Blad nie podales liczby całkowitej\n");
                info.WyswietlDane("test 2");
                return;
            }
            WriteLine("\n witaj" + imie + "\n podales ze masz lat: {0:D}\n", wiek);
            info.WyswietlDane("test 3 - koniec");
            ReadLine();
        }
    }
}
