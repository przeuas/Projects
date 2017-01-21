using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

using System.Collections.Generic;
using System.Collections.Immutable;

namespace przyklad12
{
    public class Account
    {
        public string Name { get; set; }
        public decimal Amount { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ListSample();
            Read();
        }
        private static void ListSample()
        {
            List<Account> accounts = new List<Account>()
            {
                new Account
                {
                    Name = "Anna Abacka",
                    Amount = 100000m
                },
                new Account
                {
                    Name = "Karol Kabacki",
                    Amount = -2000m
                },
                new Account
                {
                    Name = "Marek Mabacki",
                    Amount = 30000m
                }
            };
            ImmutableList<Account> immutableAccounts = accounts.ToImmutableList();

            foreach(var item in immutableAccounts)
            {
                WriteLine("{0}{1}", item.Name, item.Amount);
            }
            WriteLine();

            ImmutableList<Account>.Builder builder = immutableAccounts.ToBuilder();
            for(int i = 0;i<builder.Count;i++)
            {
                Account a = builder[i];
                if(a.Amount > 0)
                {
                    builder.Remove(a);
                }
            }
            ImmutableList<Account> overdrawnAccounts = builder.ToImmutable();

            foreach(var item in overdrawnAccounts)
            {
                WriteLine("{0}{1}", item.Name, item.Amount);
            }
        }
    }
}
