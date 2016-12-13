using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication12
{
    public class Class1
    {
        Person[] persons_A;
        Person[] persons_B;
        int personQuantity = 1;

        const int rozmiarTablicy = 2;
        
        public Class1()
        {
            persons_A = new Person[rozmiarTablicy];
            persons_B = new Person[rozmiarTablicy];
        }
        

        public void addPerson(string s_Imie, string s_Nazwisko)
        {
            persons_A[personQuantity -1] = new Person(s_Imie,s_Nazwisko);
            personQuantity++;

        }

        public void addPerson2(string s_Imie, string s_Nazwisko, string s_Data_Urodzin)
        {
            persons_A[0] = new Person(s_Imie, s_Nazwisko,s_Data_Urodzin);
        }
        public void sort()
        {

            Array.Sort(persons_A);
        }
        public void copyToPersonsB(int i_Copy_Length)
        {
            Array.Copy(persons_A, persons_B, i_Copy_Length);
        }
        public void resizaA(int i_Size_A)
        {
            Array.Resize(ref persons_A, i_Size_A);
        }
        public string printA()
        {   string s_Output = " ";
            foreach (var i in persons_A)

                s_Output += i.ToString();
            return s_Output;
        }
        public string printB()
        {
            string s_Output = " ";
            foreach (var i in persons_B)

                s_Output += i.ToString();
            return s_Output;
        }
        







    }
}
