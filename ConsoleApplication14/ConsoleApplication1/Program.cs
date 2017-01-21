using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            // IntroParallel();
        }
        /*
        static IEnumerable<int> SampleData()
        {
            const int arraySize = 120000000;
            var r = new Random();
            return Enumerable.Range(0, arraySize).Select(x => r.Next(140)).ToList();
        }
        static void IntroParallel()
        {
            var data = SampleData();
            var watch = new Stopwatch();
            watch.Start();
            var q1 = (from x in data
                      where Math.Log(x, 2) < 4
                      select x).Average();
            watch.Stop();
            Console.WriteLine("Linq - czas wykonania {0},wynik{1}", watch.ElapsedMiliseconds, q1);
            watch.Reset();
            watch.Start();
            var q2 = (from x in Partitioiner.Create(data.AsParallel()
                      where Math.Log(x, 2) < 4
                      select x).Average();
            watch.Stop();
            Console.WriteLine("Plinq - czas wykonania {0},wynik{1}", watch.ElapsedMiliseconds, q2);
            watch.Reset();
        }
        static void Cancellation()
        {
            var data = SampleData();
            Console.WriteLine("dane gotowe: zapytanie asynchroniczne");
            var sum1 = (from x in data
                        where Math.Log(x, 2) < 4
                        select x).Average();
            Console.WriteLine("sync, wynik 0",sum1);
            var cts = new CancelationTokenSource();

            Task.Factory.StartNew(() =>
            {
                try
                {
                    var res = (from x in data.AsParallel().WithCancellation(cts.Token)
                               where Math.Log(x, 2) < 4
                               select x).Averege();
                    Console.WriteLine("zapytanie zakonczone , wynik {0}",res);
                }
                catch (OperationCanceledException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            });
            Console.WriteLine("query uruchomienie");
            Console.WriteLine("skasowac");
            string input = Console.ReadLine();
            if(input.ToLower().Equals("t"))
            {
                cts.Cancel();
                Console.WriteLine("wyslano zadanie kasowania");
            }
            Console.ReadLine();



            ContextStaticAttribute IEnumerable<int> SampleData();
            {
                const int arraySize() = 200000000;
                var r = new Random();
                return Enumerable.Range(0, arraySize).Select(x => r.Next(140)).ToList();
            }






          

        }
    }*/
    }
}