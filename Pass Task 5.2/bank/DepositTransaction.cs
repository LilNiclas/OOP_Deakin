using System;
namespace task_5_2
{
    class DepositTransaction
    {
        private Account _account;
        private decimal _amount;
        private bool _executed;
        private bool _success;
        private bool _reversed;

        public DepositTransaction(Account account, decimal amount)
        {
            _account = account;
            _amount = amount;
            _executed = false;
            _success = false;
            _reversed = false;
        }

        public bool Success => _success;
        public bool Reversed => _reversed;
        public bool Executed => _executed;

        public void Print()
        {
            Console.WriteLine("Deposit Transaction: " + _amount + " from " + _account.GetName());
            Console.WriteLine("Executed: " + Executed + "\nSuccess: " + Success + "\nReversed: " + Reversed + "\n");
            Console.WriteLine("Current Balance: " + _account.GetBalance() + "\n");
        }

        public void Execute()
        {
            if (Executed)
            {
                throw new InvalidOperationException("Transaction has already been executed");
            }

            _executed = true;

            if (_account.Deposit(_amount))
            {
                _success = true;
            }
            else
            {
                throw new InvalidOperationException("Deposit didn't go through");
            }
        }

        public void Rollback()
        {
            if (!Executed)
            {
                throw new InvalidOperationException("Transaction has not been executed yet");
            }
            if (Reversed)
            {
                throw new InvalidOperationException("Transaction has already been reversed");
            }
            if (Success)
            {
                if (_account.Withdraw(_amount))
                {
                    _reversed = true;
                }
            }
            else
            {
                throw new InvalidOperationException("Transaction was not successful, can't rollback");
            }
        }
    }
}