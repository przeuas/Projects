using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using static System.Console;
namespace ConsoleApplication7
{
    class Program
    {
        static int count;
        static StreamReader sr;
        const string name = @"c:\robo/plik1.txt";
        static void Main(string[] args)
           
        {
            int a;
            count = 0;
            try
            {
                sr = new StreamReader(name);
                readLines();
                sr.Close();
                WriteLine("\n Liczba lini : {0} \n",count);

                
            }
            catch(Exception e)
            {
                WriteLine("komunikat wystemowy" + e.Message + "\n");
            }
            a = Int32.Parse(ReadLine());
        }
        static void readLines()
        {
            String textLine = sr.ReadLine();
            if(textLine != null)
            {
                Console.WriteLine(textLine);
                count++;
                readLines();
            }
        }
    }
}
