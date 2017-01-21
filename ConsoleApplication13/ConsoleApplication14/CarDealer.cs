using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication14
{
    public class CarInfoEventArgs : EventArgs
    {
        public CarInfoEventArgs(string car)
        {
            this.Car = car;
        }
        public CarInfoEventArgs(string Car,DateTime start,DateTime end) :this(Car)
        {
            this.start = start;
            this.end = end;
        }
        public string Car { get; private set; }
        public DateTime start { get; private set; }
        public DateTime end { get; private set; }
    }

    class CarDealer
    {
        public event EventHandler<CarInfoEventArgs> NewCaraInfo;

        public void NewCar(string car)
        {
            Console.WriteLine("Dealer, nowe auto{0}", car);
            if(NewCaraInfo != null)
            {
                NewCaraInfo(this, new CarInfoEventArgs(car));
            }
        }
        public void NewCar(String car, String Start, String End)
        {
            DateTime start = Convert.ToDateTime(Start);
            DateTime end = Convert.ToDateTime(End);

            Console.WriteLine("Dealer, nowe auto{0}", car,start,end);
            if (NewCaraInfo != null)
            {
                NewCaraInfo(this, new CarInfoEventArgs(car,start,end));
            }

        }
    }
}
