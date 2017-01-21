using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication15
{
    
    public delegate List<Tuple<int, string>> DemoDeleg2(ref List<Tuple<int, string>> a);


    class Program
    {
        
        static void Main(string[] args)
        {
            
            DemoDeleg2 deleg1a;

            
            deleg1a = ReturnListSortedByName;
            deleg1a += ReturnListSorderById;



            Delegate[] deleg = deleg1a.GetInvocationList();

            foreach (DemoDeleg2 d2 in deleg)
                try
                {
                 //   d2();
                }
                catch (Exception e)
                {
                    Console.Write("wyjatek info" + e.Message);
                }
            Console.WriteLine("\nPrzyklad 2- delegat Action");
           


            Console.ReadKey();
            

            List<Tuple<int, string>> carList = new List<Tuple<int, string>>();
            // Dodajemy wartości do naszej listy
            carList.Add(Tuple.Create(71, "Audi"));
            carList.Add(Tuple.Create(62, "Pagani"));
            carList.Add(Tuple.Create(53, "Lamborghini"));
            carList.Add(Tuple.Create(54, "Ferrari"));
            carList.Add(Tuple.Create(45, "Nissan"));
            carList.Add(Tuple.Create(36, "Toyota"));
            carList.Add(Tuple.Create(27, "Subaru"));
            carList.Add(Tuple.Create(18, "BMW"));
            // Sortujemy po nazwie
            carList = ReturnListSortedByName(ref carList);
            Console.WriteLine("Elementy posortowane po nazwie");
            foreach (var item in carList)
            {
                // Identyfikatory nie są potrzebne, wyświetlimy tylko nazwy
                Console.WriteLine(item.Item2);
            }
            Console.WriteLine("=======================================");
            carList = ReturnListSorderById(ref carList);
            Console.WriteLine("Elementy posortowane po Id");
            foreach (var item in carList)
            {
                Console.WriteLine("Id: {0}, Marka: {1}", item.Item1, item.Item2);
            }
            Console.ReadKey();
            // Wynik działania programu
            // Elementy posortowane po nazwie
            // Audi
            // BMW
            // Ferrari
            // Lamborghini
            // Nissan
            // Pagani
            // Subaru
            // Toyota
            // =======================================
            // Elementy posortowane po Id
            // Id: 18, Marka: BMW
            // Id: 27, Marka: Subaru
            // Id: 36, Marka: Toyota
            // Id: 45, Marka: Nissan
            // Id: 53, Marka: Lamborghini
            // Id: 54, Marka: Ferrari
            // Id: 62, Marka: Pagani
            // Id: 71, Marka: Audi

        }
        static List<Tuple<int, string>> ReturnListSortedByName(ref List<Tuple<int, string>> carList)
        {
            // sortowanie elementów po nazwie
            var sorted = carList.OrderBy(t => t.Item2).ToList();
            return sorted;
        }
        static List<Tuple<int, string>> ReturnListSorderById(ref List<Tuple<int, string>> carList)
        {
            // sortowanie elementów po id
            var sorted = carList.OrderBy(t => t.Item1).ToList();
            return sorted;
        }



    }
}
    
    
