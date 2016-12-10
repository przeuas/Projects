using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static System.Enum;
using static System.Console;
using static System.Text.Encoding;

namespace ConsoleApp2
{
    public class Program
    {
        enum Color { Red, Green, Blue };
        enum Access { Guest = 0, User = 1, PowerUser = User, Admin = 4 };
        enum AccessByte : byte { Guest = 0, Admin = 1 };
        public enum BorderSide { Left, Right, Top, Bottom };
        public enum HorizontalAlignment
        {
            Left = BorderSide.Left,
            Right = BorderSide.Right,
            Center
        }
        public static void Main(string[] args)
        {
            OutputEncoding = GetEncoding("UTF-8");
            Color color = Color.Red;

            WriteLine($"Kolor:{color}");
            color = Color.Red +5;
            WriteLine($"Kolor:{color}");

            HorizontalAlignment ha = HorizontalAlignment.Center;
            WriteLine($"wyrownanie {ha}");

            WriteLine("wartosci poziomow dostepu");
            foreach (int i in Enum.GetValues(typeof(Access))) 
                WriteLine($"{i,4}");
            foreach (string s in Enum.GetNames(typeof(Access)))
                WriteLine($"{s,10}");
            WriteLine();

            //jawne konwersje na /z int


            int j = (int)BorderSide.Left;
            BorderSide side = (BorderSide)j;
            bool horizontal = (int)side <= 2;

            HorizontalAlignment h = (HorizontalAlignment)BorderSide.Right;
            HorizontalAlignment hh = (HorizontalAlignment)(int)BorderSide.Right;
            WriteLine($" wynik konwersji\n{j,5},{h,5},{hh,5}\n");

            Read();

        }
    }
}
