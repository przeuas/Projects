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
           
            View view = new View();

            int userInput = 0;
            do
            {

                userInput = view.DisplayMenu();
                switch(userInput)
                {
                    case 1:
                        view.addItem();
                        break;
                    case 2:
                        view.sortTableA();
                        break;
                    case 3:
                        view.copyToB();
                        break;
                    case 4:
                        view.resizeTabA();
                        break;
                    case 5:
                        view.removePersonFromA();
                        break;
                    case 7:
                        view.printTableA();
                        break;
                    case 8:
                        view.printTableB();
                        break;

                    default:
                        Write("wpisz porawna wartosc");
                        break;

                }
                    

            } while (userInput != 9);
#if (DEBUG)

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
