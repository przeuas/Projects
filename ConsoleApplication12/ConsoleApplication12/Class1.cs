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
        int personActualQuantity = 1;

        const int rozmiarTablicy = 2;
        
        public Class1()
        {
            persons_A = new Person[rozmiarTablicy];
            persons_B = new Person[rozmiarTablicy-1];
        }
        

        public void addPerson(string s_Imie, string s_Nazwisko)
        {
            
            persons_A[personActualQuantity -1] = new Person(s_Imie,s_Nazwisko);
            personActualQuantity++;

        }

        public void addPerson(string s_Imie, string s_Nazwisko, string s_Data_Urodzin)
        {
            persons_A[personActualQuantity - 1] = new Person(s_Imie, s_Nazwisko,s_Data_Urodzin);
            personActualQuantity++;
        }
        public void sort()
        {

            Array.Sort(persons_A);
        }
        public void copyToPersonsB(int i_Copy_Length)
        {
            if (i_Copy_Length > persons_B.Length) resizaB(i_Copy_Length);
            Array.Copy(persons_A, persons_B, i_Copy_Length);
        }
        public int resizaA(int i_Size_A)
        {
            Array.Resize(ref persons_A, i_Size_A);
            if (i_Size_A < personActualQuantity) personActualQuantity = i_Size_A;
            return persons_A.Length;

        }
        public int resizaB(int i_Size_A)
        {
            Array.Resize(ref persons_B, i_Size_A);
            if (i_Size_A<personActualQuantity) personActualQuantity = i_Size_A;
            return persons_A.Length;
            
        }
    public string printA()
        {   string s_Output = " ";
            foreach (var i in persons_A)
                if(i != null)
                    s_Output += i.ToString();
            return s_Output;
        }
        public string printB()
        {
            string s_Output = " ";
            foreach (var i in persons_B)
                if (i != null)
                    s_Output += i.ToString();
            return s_Output;
        }
        public void addOrDeletePersonB(int s_Name)
        {
            Array.Clear(persons_A, s_Name, 1);
        }
        







    }
}
