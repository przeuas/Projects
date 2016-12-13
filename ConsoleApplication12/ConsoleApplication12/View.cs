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
            string s_temp_First_Name = ReadLine();
            Console.WriteLine("Enter a Last Name \t");
            string s_temp_LastName = ReadLine();
            WriteLine("Enter a birthday in format >> 1988-01-18");
            string s_temp_BirthDay = ReadLine();


            c.addPerson(s_temp_First_Name,s_temp_LastName, s_temp_BirthDay);
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
        public void copyToB()
        {
            WriteLine("podaj ile elementów  tablicy  chcesz skopiować");
            int i_table_size = int.Parse(ReadLine());
            c.copyToPersonsB(i_table_size);
        }
        public void resizeTabA()
        {
            WriteLine("nowy rozmiar tablicy to: " + c.resizaA(int.Parse(ReadLine())));

        }
        public void resizeTabB()
        {
            WriteLine("nowy rozmiar tablicy to: " + c.resizaB(int.Parse(ReadLine())));

        }
        public void removePersonFromA()
        {
            WriteLine("podaj nazwe elementu: \t ");
            c.addOrDeletePersonB(int.Parse((ReadLine())));
            WriteLine("Element usuniety");
        }



    }
}
