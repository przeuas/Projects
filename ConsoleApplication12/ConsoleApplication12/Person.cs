using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
namespace ConsoleApplication12
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        DateTime dt;
        public Person(string sImie,string sNazwisko)
        {
            this.FirstName = sImie;
            this.LastName = sNazwisko;
          
        }
       public  Person(string sImie,string sNazwisko,string sUrodziny)
        {
            this.FirstName = sImie;
            this.LastName = sNazwisko;
            this.birthdayDate = sUrodziny;


        }
        public string birthdayDate

        {
            get
            {
                return String.Format("{0:yyyy.MM.dd}", dt);
            }
            set
            {
                dt = DateTime.Parse(value, CultureInfo.CurrentCulture);
            }
        }

        public override string ToString()
        {
            return String.Format("{0} {1} {2}\n", FirstName, LastName, birthdayDate);
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
}
