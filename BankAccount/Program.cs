using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            Account robsAccount = new Account();
            if (robsAccount.WithdrawFunds(0))
            {
                Console.WriteLine("Cash withdrawn");
            }
            else
            {
                Console.WriteLine("Insuficient funds");
            }

            Console.ReadLine();
        }
    }

    public class Account
    {
        private decimal balance = 0;

        public bool WithdrawFunds(decimal amount)
        {
            if (balance < amount)
            {
                return false;
            }

            balance = balance - amount;

            return true;
        }

        public void PayInFunds(decimal amount)
        {
            balance = balance + amount;
        }

        public decimal GetBalance()
        {
            return balance;
        }
    }
}
