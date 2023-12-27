using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Encapsulations
{
    public class BankAccount
    {
        // Private field
        private double balance = 0;

        // Method to deposit money
        public void Deposit(double amount)
        {
            balance = amount;
        }

        public string GetBalance()
        {
            return $"${balance}";
        }

    }
}
