using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication14
{
    class Consumer
    {
        private string name;

        public Consumer(string name)
        {
            this.name = name;
        }
        public void NewCarlsHere(object sender,CarInfoEventArgs e)
        {
            Console.WriteLine("info dla {0};, jest nowe auto{1}", name, e.Car);
        }
        public void NewCarlsHere2(object sender, CarInfoEventArgs e)
        {
            Console.WriteLine("info dla {0};, jest nowe auto{1} dostepne od {2} do {3}", name, e.Car,e.start,e.end);
        }
    }
}
