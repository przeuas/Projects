using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ConsoleApplication12
{
    public class View
    {
        
        Class1 c;
        public View()
        {
            c = new Class1();
        }
        public int DisplayMenu()
        {
            Console.WriteLine("Zarządzanie osobami");
            Console.WriteLine();
            Console.WriteLine("1. dodaj obiekt do tablicy A");
            Console.WriteLine("2. sortowanie obiektu w tablicy A");
            Console.WriteLine("3. kopiowanie wycinka tablicy A do tablicy B");
            Console.WriteLine("4. zmiana rozmiaru tablicy A");
            Console.WriteLine("5. dodawanie/usuwanie obiektu/ów do tablicy B");
            Console.WriteLine("6. sortowanie obiektu w tablicy B");
            Console.WriteLine("7. wyposuwanie zawartosci tablicy A na monitor");
            Console.WriteLine("8. wyprowadzanie  zawartosci tablicy B na monitor");
            Console.WriteLine("9. zakonczenie programu");
           
            var result = Console.ReadLine();

            return Convert.ToInt32(result);
        }
        public void addItem()
        {
            
            Console.WriteLine("Enter a name  of  Person: \t");
            c.addPerson(ReadLine(), ReadLine());
        }
        public void printTableA()
        {
            WriteLine(c.printA());

        }
        public void printTableB()
        {
            WriteLine(c.printB());
        }
        public void sortTableA()
        {
            c.sort();
        }


    }
}
