using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace demoStringBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder("linia pierwsza");
            sb.Append("\n");
            sb.AppendLine("linia nr 2");
            sb.AppendLine("linia nr 3");
            sb.AppendLine("linia nr 4");
            sb.AppendLine("linia nr 5");
            WriteLine(sb.ToString());

            StringBuilder sb1 = new StringBuilder("ABC", 50);
            sb1.Append(new char[] { 'D', 'E', 'F' });
            sb1.AppendFormat("GHI{0}{1}", 'J', "ąćęłńóśźż");
            WriteLine("{ 0} znakow:{1}", sb1.Length, sb1.ToString());

            sb1.Insert(0, "Napis");
            sb1.Replace("s", "SY");
            WriteLine("s", "SY");
            WriteLine("{0} znaków: {1}\n", sb1.Length, sb1.ToString());

            WriteLine("{0} znakow  {1}\n", sb1.Length, sb1.ToString().ToUpper());
        }
    }
}
