using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ConsoleApplication11
{
    public class Demo
    {
        private int x;
        public Demo()
        {
            setX(0);
        }
        public delegate void MojDelegat(Demo param);
        public event MojDelegat XJestUjemne;
        

        public void setX(int x)
        {
            this.x = x;
            if (x < 0)
            {
                //if (XJestUjemne != null) XJestUjemne();
                XJestUjemne?.Invoke(this);
            }
            
        }
        public int getX()
        {
            return x;
        }
    }
    class Program
    {
        public static void gdyUjemne1(Demo p1)
        {
            WriteLine("Proc1 x jest  i wynosi {0}",p1.getX());
        }
        public static void gdyUjemne2(Demo p2)
        {
            WriteLine("Proc2 x jest  i wynosi {0}", p2.getX());
        }
        static void Main(string[] args)
        {
            Demo demo = new Demo();
            demo.XJestUjemne += gdyUjemne1;
            demo.XJestUjemne += gdyUjemne2;

            WriteLine("zarejestrowano dwie procedury obslugi zdarzenia");
            demo.setX(-100);
            ReadKey();
            WriteLine("wyrejestrowano pierwsza procedure obslugi zdarzenia");
            demo.XJestUjemne -= gdyUjemne1;
            demo.setX(-200);
            Console.ReadKey();

        }
    }
}
