#define DEBUG

#undef DEBUG
using System;

using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ConsoleApplication12
{
    
    class Program
    {
        static void Main(string[] args)
        {
#if(DEBUG)
            
                WriteLine("siemano");
                
            Person p = new Person();
            WriteLine("imię\t");
            p.FirstName = ReadLine();
            WriteLine("nazwisko\t");
            p.LastName = ReadLine();
            WriteLine("podaj datę w formacie >> 1988-01-18");
            p.birthdayDate = ReadLine();

            WriteLine(p.ToString());
            WriteLine(p.birthdayDate);
            Read();

#endif

        }
    }
}
