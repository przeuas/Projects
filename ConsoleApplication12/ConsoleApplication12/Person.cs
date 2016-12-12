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
            return String.Format("{0} {1} {2}", FirstName, LastName, birthdayDate);
        }
    }
}
