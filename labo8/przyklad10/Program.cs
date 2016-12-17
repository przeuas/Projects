using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace przyklad10
{
    public class Emloyee
    {
        private string name;
        private decimal salary;
        private readonly EmployeeId id;

        public Emloyee(EmployeeId id , string name ,decimal salary)
        {
            this.id = id;
            this.name = name;
            this.salary = salary;
        }
        public override string ToString()
        {
            return String.Format("{0}: {1,-20}{2:C}", id.ToString(), name, salary);
        }
    }
    public class EmployeeIdException: Exception
    {
        public EmployeeIdException(string message) : base(message) { }
    }
    public struct EmployeeId:IEquatable<EmployeeId>
    {
        private readonly char prefix;
        private readonly int number;

        public EmployeeId(string id)
        {
            prefix = (id.ToUpper())[0];
            int numLength = id.Length - 1;

            try
            {
                number = int.Parse(id.Substring(1, numLength > 6 ? 6 : numLength));
            }
            catch(FormatException)
            {
                throw new EmployeeIdException("niepoprawny format employeeid");
            }
        }
        public override string ToString()
        {
            return prefix.ToString() + string.Format("{0,6:000000}",number);
        }
        public override int GetHashCode()
        {
            return (number ^ number << 16) * 0x15051505;
        }
        public bool Equals(EmployeeId other)
        {
            if (other == null) return false;
            return (prefix == other.prefix && number == other.number);
        }
        public static bool operator ==(EmployeeId left, EmployeeId right)
        {
            return left.Equals(right);
        }
        public static bool operator !=(EmployeeId left,EmployeeId right)
        {
            return !(left == right);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var employess = new Dictionary<EmployeeId, Emloyee>(31);

            var idCelina = new EmployeeId("C3755");
            var celina = new Emloyee(idCelina, "Celina Cebacka", 3790.00m);

            employess.Add(idCelina, celina);
            Console.WriteLine(celina);


            var idKarol = new EmployeeId("F3747");
            var karol = new Emloyee(idCelina, "Celina Cebacka", 4090.00m);

            employess.Add(idKarol, karol);
            Console.WriteLine(karol);

            var idWitold = new EmployeeId("W3747");
            var Witold = new Emloyee(idCelina, "Witold Witolecki", 4152.00m);

            employess.Add(idWitold, Witold);
            Console.WriteLine(Witold);

            while(true)
                {
                Write("Podaj id pracownika( x - koniec: ");
                var userInput = ReadLine();
                userInput = userInput.ToUpper();
                if ((userInput == "X") || (userInput == string.Empty)) break;

                EmployeeId id;

                try
                {
                    id = new EmployeeId(userInput);
                    Emloyee employee;
                    if(!employess.TryGetValue(id,out employee))
                    {
                        WriteLine("pracownik z id{0} nie istnieje", id);

                    }
                    else
                    {
                        WriteLine(employee);
                    }
                }
                catch(EmployeeIdException ex)
                {
                    WriteLine(ex.Message);
                }
            }

        }
    }
}
