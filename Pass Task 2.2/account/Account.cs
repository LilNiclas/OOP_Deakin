using System;
namespace task_2_2
{
    class Account
    {
        private decimal _balance;
        private string _name;

        public Account(string name, decimal balance)
        {
            _name = name;
            _balance = balance;
        }

        public string GetName()
        {
            return this._name;
        }

        public void Deposit(decimal amount)
        {
            if (amount > 0)
            {
                _balance += amount;
            }
            else
            {
                Console.WriteLine("Deposit amount must be positive");
            }
        }

        public void Withdraw(decimal amount)
        {
            if (amount > 0 && amount <= _balance)
            {
                _balance -= amount;
            }
            else
            {
                Console.WriteLine("Withdrawal amount exceeds the balance");
            }
        }

        // Print method
        public void Print()
        {
            Console.WriteLine("Account Name:" + _name + "\n" + "Current Balance:" + _balance);
        }
    }
}