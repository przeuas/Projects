using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication14
{
    class Program
    {
        static void Main(string[] args)
        {
            var dealer = new CarDealer();
            var michal = new Consumer("Michal");
            dealer.NewCar("Audi/A6");

            var ela = new Consumer("Ela");
            var kalina = new Consumer("Kalina");

            dealer.NewCaraInfo += ela.NewCarlsHere;

            dealer.NewCar("honda/accord");

            dealer.NewCaraInfo += michal.NewCarlsHere;
            dealer.NewCaraInfo += kalina.NewCarlsHere;

            dealer.NewCaraInfo += michal.NewCarlsHere2;

            dealer.NewCar("Kia/sportage");

            dealer.NewCar("Ford/Mustang", "01 / 08 / 2008", "01 / 09 / 2008");

            Console.Read();
        }
    }
    
}
