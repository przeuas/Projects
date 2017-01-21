using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace ConsoleApplication10
{
    public class Demo
    {
        private int x;
        public Demo()
        {
            setX(0);
        }
        public delegate void MojDelegat();
        public event MojDelegat XJestUjemne;
        public event MojDelegat XJestDodatnie;

        public void setX(int x)
        {
            this.x = x;
            if(x<0)
            {
                //if (XJestUjemne != null) XJestUjemne();
                XJestUjemne?.Invoke();
            }
            if(x>0)
            {
                XJestDodatnie?.Invoke();
            }
        }
        public int getX()
        {
            return x;
        }
    }
    
   /* class Program
    {
        public static void ObsluzUjemne()
        {
            WriteLine("obsluga zdarzenia x:ujemne");
        }
        public static void ObsluzDodatnie()
        {
            WriteLine("obsluga zdarzenia X dodatnie");
        }
        static void Main(string[] args)
        {
            Demo demo = new Demo();
            demo.XJestUjemne += ObsluzUjemne;
            demo.XJestDodatnie += ObsluzDodatnie;

            demo.setX(-1);

            ReadKey();

            demo.setX(+1);
            ReadKey();
            demo.setX(0);
            ReadKey();

            demo.setX(-1);
            ReadKey();

        }

    
    }*/
    class Program1
    {
        public static void gdyUjemneA()
        {
            WriteLine("X ujemne -procedura obslugi 1");
        }
        public static void gdyUjemneB()
        {
            WriteLine("X ujemne -procedura obslugi 2");
        }
        public static void gdyDodatnie()
        {
            WriteLine("X dodatnie -procedura obslugi");
        }
        static void Main(string[] args)
        {
            Demo demo = new Demo();
            WriteLine("zarejestrowano dwie procedury obslugi zdarzenia 1 i jedna zdarzenia 2");
            demo.XJestUjemne += gdyUjemneA;
            demo.XJestUjemne += gdyUjemneB;
            demo.XJestDodatnie += gdyDodatnie;

            demo.setX(-1);
            ReadKey();

            demo.setX(+1);
            ReadKey();

            demo.XJestUjemne -= gdyUjemneA;
            demo.XJestUjemne -= gdyUjemneB;
            demo.XJestDodatnie -= gdyDodatnie;

            WriteLine("wyrejestrowano dwie procedury obslugi zdarzenia 1 i jedn zdarzenia 2 \n Brak emisji zdarzen");

            demo.setX(-1);
            demo.setX(+1);

            ReadKey();
        }
    }
}
