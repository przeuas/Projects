using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication12
{ }
    class Zdarzenia
{
    public delegate void WhichKey();

    public event WhichKey LowerCase;
    public event WhichKey UpperCase;
    public event WhichKey Digit;
    public event WhichKey Key;
    public event WhichKey FunctionnKey;
    public event WhichKey Alt_Key;
    public event WhichKey Ctrl_Key;
    public event WhichKey Ctrl_Alt_Key;
    public event WhichKey AnotherKey;

    public void sprawdz()
    {
        ConsoleKeyInfo key = Console.ReadKey(true);
        while(!key.Key.Equals(ConsoleKey.Escape))
        {
            if ((key.Modifiers & ConsoleModifiers.Alt) != 0 ||
                (key.Modifiers & ConsoleModifiers.Control) != 0)
            {
                if ((key.Modifiers & ConsoleModifiers.Alt) != 0 &&
                    (key.Modifiers & ConsoleModifiers.Alt) != 0)
                    Ctrl_Alt_Key();
                else if ((key.Modifiers & ConsoleModifiers.Alt) != 0)
                    Alt_Key();
                else Ctrl_Key();

            }
            else if (char.IsLower(key.KeyChar)) LowerCase();
            else if (char.IsUpper(key.KeyChar)) UpperCase();
            else if (char.IsDigit(key.KeyChar)) Digit();
            else if (char.IsPunctuation(key.KeyChar)) Key();
            else if (char.IsControl(key.KeyChar)) FunctionnKey();
            else AnotherKey();
            key = Console.ReadKey(true);
        }
    }
}
    class Program
    {
    public void subskrybuj()
    {
        Zdarzenia e = new Zdarzenia();

        e.LowerCase += delegate ()
        {
            Console.WriteLine("Mała litera");
        };
        e.UpperCase += delegate ()
        {
            Console.WriteLine("duża litera");
        };
        e.Digit += delegate ()
        {
            Console.WriteLine("cyfra");
        };
        e.Key += delegate ()
        {
            Console.WriteLine("Znak");
        };
        e.FunctionnKey += delegate ()
        {
            Console.WriteLine("Klawisz funkcyjny");
        };
        e.Alt_Key += delegate ()
        {
            Console.WriteLine("Alt klawisz");
        };
        e.Ctrl_Key += delegate ()
        {
            Console.WriteLine("ctrl klawisz");
        };
        
        e.Ctrl_Alt_Key += delegate ()
        {
            Console.WriteLine("Ctrl alt + klawisz");
        };
        e.AnotherKey += delegate ()
        {
            Console.WriteLine("inny");
            e.sprawdz();
        };
    }
    

        static void Main(string[] args)
        {
        Program p = new Program();
        p.subskrybuj();
        Console.Read();
        }
    }

