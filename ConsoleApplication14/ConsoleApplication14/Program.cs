using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication14
{
    class Person
    {
        public int id;
        public string Name, FamilyName;
        public int Phone;
        public int Age;

    }
    class Program
    {
        static List<Person> listOfPersons = new List<Person>
        {
            new Person { id=1,Name="Jan",FamilyName="Kabalkiewicz",Phone=1232020,Age=39 },
            new Person { id=2,Name="Andrzej",FamilyName="Kabalkiewicz",Phone=1232820,Age=29 },
            new Person { id=3,Name="Maciej",FamilyName="Babalkiewicz",Phone=7232020,Age=49 },
            new Person { id=4,Name="Witold",FamilyName="Kabalkiewicz",Phone=1232020,Age=26 },
            new Person { id=5,Name="Jan",FamilyName="Mlaysz",Phone=1232020,Age=13 },
        };
        static void Main(string[] args)
        {
            //Program p = new Program();
            PobieranieDanych();
            AnalizaPobranychDanych();
            WyborElementu();
            WeyfikowanieDanych();
            PrezentacjaWGrupach();
            LaczenieOperatoremJoin();
            MozliwaModyfikacjaDanychZrodla();
            Console.Read();
        }

        private static void PobieranieDanych()
        {
            var listOfAdults = from person in listOfPersons
                               where person.Age >= 18
                               orderby person.Age
                               select person;

            List<Person> sublist = listOfAdults.ToList<Person>();
            Console.WriteLine("PobieranieDanych filtrowanie sortowanie");
            Console.WriteLine("lista osob pelnoletnich");
            foreach (var person in listOfAdults)
                Console.WriteLine($"{ person.Name} {person.FamilyName} ,\t wiek: {person.Age}");

            Console.WriteLine("lp nieletnich");
            foreach (var person in sublist)
                Console.WriteLine($"{ person.Name} {person.FamilyName} ,\t wiek: {person.Age}");
        }
        public static void AnalizaPobranychDanych()
        {
            var listOfAults = from person in listOfPersons
                              where person.Age >= 18
                              orderby person.Age
                              select person;
            Console.WriteLine("\n \t Analiza pobranych danych");
            Console.WriteLine($"Wiek osoby najsarszej: {listOfAults.Max(person => person.Age)}");
            Console.WriteLine($"sredni wiek osob pelnoletnich{listOfAults.Average(person => person.Age)}");
            Console.WriteLine($"suma lat osob pelnoletnich{listOfAults.Sum(person => person.Age)}");
        }
        public static void WyborElementu()
        {
            var listOfAults = from person in listOfPersons
                              where person.Age >= 18
                              orderby person.Age
                              select person;
            Console.WriteLine("wybor elementu");
            var yongestPerson = listOfAults.Single(person1 => (person1.Age == listOfAults.Min(person => person.Age)));



            Console.WriteLine($"najmlodszy,{yongestPerson.Name}{yongestPerson.FamilyName} \twiek {yongestPerson.Age}");

        }
        public static void WeyfikowanieDanych()
        {
            var listOfAults = from person in listOfPersons
                              where person.Age >= 18
                              orderby person.Age
                              select person;
            Console.WriteLine("weryfikowanie danych");

            bool doesContain = listOfAults.Any(person => (person.Name == "Jan"));

            Console.WriteLine($"Czy istnieje osoba o imieniu Jan {doesContain}");
        }
        public static void PrezentacjaWGrupach()
        {
            var sameFamilyName = from person in listOfPersons
                                 group person by person.FamilyName
                                                            into familyGroup
                                 select familyGroup;

            Console.WriteLine("\n\t Prezentacja w grupach");
            Console.WriteLine("Lista osob pogrupowanych wg nazwisk");

            foreach(var grupa in sameFamilyName)
            {
                Console.WriteLine($"grupa o nazwisku: {grupa.Key}");
                foreach (Person person in grupa) Console.WriteLine($"{person.Name}{ person.FamilyName}");
            }
            Console.WriteLine();
        }
        public static void LaczenieZbiorowDanych()
        {
            Console.WriteLine("LaczenieZbiorowDanych");
            Console.WriteLine("lista osob pelnoletnich i kobiet");
            var listOfAults = from person in listOfPersons
                              where person.Age >= 18
                              orderby person.Age
                              select new
                              { person.Name, person.FamilyName, person.Age };
            var listOfWoman = from person in listOfPersons
                              where person.Name.EndsWith("a")
                              select new
                              {person.Name,person.FamilyName,person.Age};
            var newList = listOfAults.Concat(listOfWoman).Distinct();

            foreach (var person in newList)
                Console.WriteLine($"{person.Name} {person.FamilyName}, \twiek {person.Age}");
            Console.WriteLine();

        }
        public static void LaczenieOperatoremJoin()
        {
            var lisOfPhones = from person in listOfPersons
                              select new { person.id, person.Phone };
            var lisOfNames = from person in listOfPersons
                              select new { person.id, person.Name,person.FamilyName };
            var newList = from pp in lisOfPhones
                          join nn in lisOfNames
                          on pp.id equals nn.id
                          select new
                          {
                              pp.id,
                              nn.Name,
                              nn.FamilyName,
                              pp.Phone
                          };
            Console.WriteLine("\n\tLaczenie danych z roznych zrodel operatiem join");
            Console.WriteLine("lista osob z numerami telefonow");
            foreach (var person in newList)
                Console.WriteLine($"{person.id}{person.Name}{person.FamilyName}\ttel {person.Phone}");
        }
        public static void MozliwaModyfikacjaDanychZrodla()
        {
            Console.WriteLine("\t\nmozliwa modyfikaja danych zrodla");
            var listOfAults = from person in listOfPersons
                              where person.Age >= 18
                              orderby person.Age
                              select person;
            Console.WriteLine("kolekcja zrodlo");
            foreach (var person in listOfAults)
                Console.WriteLine($"{person.Name}{person.FamilyName}\twiek {person.Age}");
            Console.WriteLine();

            var newListOfAdults = from person in listOfPersons
                                  where person.Age >= 18
                                  orderby person.Age
                                  select person;

            Person firstOfList = newListOfAdults.First<Person>();
            firstOfList.Name = "Tomasz";
            firstOfList.FamilyName = "Tabakiewicz";
            firstOfList.Age = 30;

            Console.WriteLine("zrodlo lista 1 po zmianie w lista 2");

            foreach (var person in listOfAults)
                Console.WriteLine($"{person.Name}{person.FamilyName},\twiek{person.Age}");

        }

    }
}