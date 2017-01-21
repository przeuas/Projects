using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class BubbleSorter
    {
        public void Sort<T>(IList<T>sortArray,Func<T,T,bool> comparison)
        {
            bool swapped = true;
            do
            {
                 swapped = true;
                for (int i = 0; i < sortArray.Count - 1; i++)
                {
                    if (comparison(sortArray[i + 1], sortArray[i]))
                    {
                        T temp = sortArray[i];
                        sortArray[i] = sortArray[i + 1];
                        sortArray[i + 1] = temp;
                        swapped = true;

                    }
                }
                }while (swapped);
            }
    }
    class Student
    {
        public Student(string name,uint age)
        {
            this.Name = name;
            this.Age = age;

        }
        public string Name { get; private set; }
        public uint Age { get; private set; }

        public override string ToString()
        {
            return string.Format($"{Name,20},wiek: {Age:D}");
        }
        public static bool CompareAge(Student e1, Student e2)
        {
            return e1.Age < e2.Age;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student[] students =
                {
                new Student("Bogusz Babacki",20),
                new Student("Karolnia Kabacka",11),
                new Student("Dariusz Dabacki",25),
                new Student("Witold Wabacki",27),
                new Student("Ula Utowska",23),
                new Student("Anna Abacka",22)
            };
            BubbleSorter bs = new BubbleSorter();
            bs.Sort(students, Student.CompareAge);

            foreach (var student in students)
            {
                Console.WriteLine(student);
            }
            Console.WriteLine();
            Console.Read();

        }
    
    }
}

