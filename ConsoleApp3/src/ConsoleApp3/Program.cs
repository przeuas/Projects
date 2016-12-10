using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    abstract public class Figura//
    {
        protected double a;
        protected double b;

        public Figura(double a, double b)
        {
            this.a = a;
            this.b = b;
        }

        ///deklaracja abstrakcyjnej metody
        abstract public double PoleFigury();
    }

    public class Prostokat : Figura
    {
        public Prostokat(double a, double b)
            : base(a, b)
        { }
       ///przesłoniece abstrakcyjnej klasy
        public override double PoleFigury()
        {
            double pole = a * b;
            System.Console.WriteLine("Obliczamy pole prostokąta.");
            return pole;
        }
    }

    public class Trojkat : Figura
    {
        public Trojkat(double a, double b)
            : base(a, b)
        { }
        ///przesloniecie abstrakcyjnej metody
        public override double PoleFigury()
        {
            double pole = (a * b) / 2;
            System.Console.WriteLine("Obliczamy pole trójkąta.");
            return pole;
        }
    }

    class Glowna
    {
        static void Main(string[] args)
        {
            ///deklarujemy odpowiednie obiekty wraz z wartosciami ich zmiennych
            Prostokat pr = new Prostokat(5, 6);
            Prostokat p = new Prostokat(7, 8);
            Trojkat t = new Trojkat(9, 10);
            ///wywolujemy metode obliczajaca pole odpowiedniej figury
            System.Console.WriteLine("Pole wynosi więc: {0}", pr.PoleFigury());
            System.Console.WriteLine("Pole wynosi: {0}", p.PoleFigury());
            System.Console.WriteLine("Pole wynosi: {0}", t.PoleFigury());
//------------------------------------------------------------------
            ///deklarujemy obiekt p klasy Punkty
            Punkty pu = new Punkty();
            ///przypisanie odpowiednich wartosci zmiennym w obiekcie
            pu.A = 10;
            pu.B = 20;

            ///pobranie odpowiednich wartosci ze zmiennych obiektu p
            int wart1 = pu.A;
            int wart2 = pu.B;
            System.Console.WriteLine("Współrzędne punktu wynoszą: {0}.{1}", wart1, wart2);
//-------------------------------------------------------------------------------
            ///deklaracja obiektu typu PierwszaKlasa wraz z wartosciami zmiennych
            PierwszaKlasa por = new PierwszaKlasa(1, 2);
            ///deklaracja obiektu typu DrugaKlasa wraz z wartosciami zmiennych w tym obiekcie
            DrugaKlasa dr = new DrugaKlasa(3, 4, 5);
            ///deklaracja obiektu typu TrzeciaKlasa
            TrzeciaKlasa tr = new TrzeciaKlasa(6, 7, 8, 9);
            ///wywolanie metody Wyswietl() z klasy PierwszaKlasa
            por.Wyswietl();
            ///wywolanie metody Wyswietl() z klasy DrugaKlasa
            dr.Wyswietl();
            ///wywolanie metody Wyswietl() z klasy TrzeciaKlasa
            tr.Wyswietl();
        }
    }
    public class Punkty
    {
        ///prywatne zmienne a i b
        private int a;
        private int b;

        ///wlasciwosci A i B
        public int A
        {
            get
            {
                return a;
            }
            set
            {
                a = value;
            }
        }

        public int B
        {
            get
            {
                return b;
            }
            set
            {
                b = value;
            }
        }

    }
    public class PierwszaKlasa
    {
        public int a;
        public int b;

        ///konstruktor klasy A, ktory przyjmuje dwie liczby calkowite
        public PierwszaKlasa(int a, int b)
        {
            this.a = a;
            this.b = b;
        }

        ///metoda wirtualna
        public virtual void Wyswietl()
        {
            System.Console.WriteLine("Wartości a i b wynoszą odpowiednio: {0} i {1}", a, b + ".");
        }
    }

    public class DrugaKlasa : PierwszaKlasa
    {
        public int c;

        ///dodatkowy parametr w konstruktorze, wywolujemy rowniez konstruktor klasy bazowej
        public DrugaKlasa(int a, int b, int c) : base(a, b)
        {
            this.c = c;
        }
        
        ///przeslaniamy metode klasy bazowej
        public override void Wyswietl()
        {
            base.Wyswietl();
            System.Console.WriteLine("Wartość liczby c wynosi: {0}", c + ".");
        }
    }

    public class TrzeciaKlasa : DrugaKlasa
    {
        int d;
        int suma;
        ///dodatkowy parametr w konstruktorze oraz wywolanie konstruktora klasy bazowej
        public TrzeciaKlasa(int a, int b, int c, int d) : base(a, b, c)
        {
            this.d = d;
        }
        ///przeslaniamy metode klasy DrugaKlasa
        public override void Wyswietl()
        {
            base.Wyswietl();
            System.Console.WriteLine("Wartość liczby d wynosi: {0}", d + ".");
            suma = a + b + c + d;
            System.Console.WriteLine("Suma czterech kolejnych liczb wynosi: {0}", suma + ".");
        }
    }

    


}
