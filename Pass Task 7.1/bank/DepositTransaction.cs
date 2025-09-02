using System;
namespace task_7_1
{
    class DepositTransaction : Transaction
    {
        private Account _account;

        public DepositTransaction(Account account, decimal amount) : base(amount)
        {
            _account = account;
        }

        public override bool Success => _success;

        public override void Execute()
        {
            base.Execute();

            if (_account.Deposit(_amount))
            {
                _success = true;
            }
            else
            {
                throw new InvalidOperationException("Deposit didn't go through");
            }
        }

        public override void Rollback()
        {
            base.Rollback();

            if (Success)
            {
                if (_account.Withdraw(_amount))
                {
                    _success = false;
                }
                else
                {
                    throw new InvalidOperationException("Rollback failed");
                }
            }
            else
            {
                throw new InvalidOperationException("Transaction was not successful, can't rollback");
            }
        }

        public override void Print()
        {
            Console.WriteLine("Deposit Transaction: " + _amount + " from " + _account.GetName());
            Console.WriteLine("Executed: " + Executed + "\nSuccess: " + Success + "\nReversed: " + Reversed + "\nDate: " + DateStamp);
            Console.WriteLine("Current Balance: " + _account.GetBalance() + "\n");
        }
    }
}