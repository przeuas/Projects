using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace ConsoleApplication12
{
    public class Person : IComparable<Person>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public override string ToString()
        {
            return String.Format("{0} {1}", FirstName, LastName);
        }
        public int CompareTo(Person other)
        {
            if (other == null) throw new ArgumentNullException("other");

            int result = this.LastName.CompareTo(other.LastName);
            if (result == 0)
                result = this.FirstName.CompareTo(other.FirstName);
            return result;
        }
        
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person[] per =
           {
                new Person {FirstName = "Witold" ,LastName = "Wbowski" },
                new Person {FirstName= "Irena" , LastName = "ibowska" },
                new Person {FirstName = "Marek" , LastName = "Mabowski" }
            };

            Array.Sort(per);

            foreach (var i in per)
            {
                WriteLine(i);
                WriteLine();

            }

            ///////////////////////////////////
            int[] ar1 = { 1, 3, 5, 7, 9, 11 };
            int[] ar2 = { 1, 2, 4, 8, 16, 32, 64,128 };
            var segments = new ArraySegment<int>[2]
            {
                new ArraySegment<int>(ar1,0,3),
                new ArraySegment<int>(ar2,4,4)

            };
            var sum = SumOfSegments(segments);
            WriteLine("suma wszystkich segmentow: {0}", sum);
            //////////////////////////
            Tuple<string, string> name = new Tuple<string, string>("wiktoria", "webowska");
            WriteLine(name.ToString());

            var result = Divide(5, 2);
            WriteLine("wynik dzialania, iloraz: {0}, reszta : {1}", result.Item1, result.Item2);
            result = Divide(17, 3);
            WriteLine("wynik dzialania, iloraz: {0}, reszta : {1}", result.Item1, result.Item2);
            AnyElementNumber();
            Read();
        }
        static int SumOfSegments(ArraySegment<int>[] segments)
        {
            int sum = 0;
            foreach(var s in segments)
            {
                for(int i = s.Offset; i< s.Offset + s.Count; i++)
                {
                    sum += s.Array[i];
                }
            }
            return sum;
        }
        static void  AnyElementNumber()
        {
            var tuple = Tuple.Create<string,string,string,int,int,int,double,Tuple<int,int>>
                ("karol","maria","weber",2016,10,1,3.1415,Tuple.Create<int,int>(52,3490));
            WriteLine(tuple.Item1);
        }
        public static Tuple<int,int> Divide(int dididend,int divisior)
        {
            int result = dididend / divisior;
            int reminder = dididend % divisior;

            return Tuple.Create<int, int>(result, reminder);
        }
    }
}
