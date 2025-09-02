using System;
namespace task_7_1
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

        public string GetBalance()
        {
            return this._balance.ToString();
        }

        public bool Deposit(decimal amount)
        {
            if (amount > 0)
            {
                _balance += amount;
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Withdraw(decimal amount)
        {
            if (amount > 0 && amount <= _balance)
            {
                _balance -= amount;
                return true;
            }
            else if (amount > 0)
            {
                Console.WriteLine("Withdrawal amount can't be negative buddy");
                return false;
            }
            else
            {
                Console.WriteLine("Withdrawal amount exceeds your balance");
                return false;
            }
        }

        public void Print()
        {
            Console.WriteLine("Account Name:" + _name + "\n" + "Current Balance:" + _balance);
        }
    }
}