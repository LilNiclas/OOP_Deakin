using System;
namespace task_5_2
{
    class TransferTransaction
    {
        private Account _fromAccount;
        private Account _toAccount;
        private decimal _amount;
        private WithdrawTransaction _withdrawTransaction;
        private DepositTransaction _depositTransaction;
        private bool _executed;
        private bool _reversed;

        public TransferTransaction(Account fromAccount, Account toAccount, decimal amount)
        {
            _fromAccount = fromAccount;
            _toAccount = toAccount;
            _amount = amount;
            _withdrawTransaction = new WithdrawTransaction(_fromAccount, _amount);
            _depositTransaction = new DepositTransaction(_toAccount, _amount);
            _executed = false;
            _reversed = false;
        }

        public bool Executed => _executed;
        public bool Reversed => _reversed;
        public bool Success => _withdrawTransaction.Success && _depositTransaction.Success;

        public void Execute()
        {
            if (Executed)
            {
                throw new InvalidOperationException("This transfer has already been executed.");
            }

            _executed = true;

            try
            {
                _withdrawTransaction.Execute();
                _depositTransaction.Execute();
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException("Transfer failed: " + ex.Message);
            }
        }

        public void Rollback()
        {
            if (!Executed)
            {
                throw new InvalidOperationException("Cannot rollback a transfer that hasn't been executed.");
            }

            if (Reversed)
            {
                throw new InvalidOperationException("This transfer has already been reversed.");
            }

            if (!Success)
            {
                throw new InvalidOperationException("Transfer was not successful; cannot rollback.");
            }

            try
            {
                _depositTransaction.Rollback();
                _withdrawTransaction.Rollback();
                _reversed = true;
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException("Rollback failed: " + ex.Message);
            }
        }

        public void Print()
        {
            Console.WriteLine("Transferred " + _amount + " from " + _fromAccount.GetName() + " to " + _toAccount.GetName());
            _withdrawTransaction.Print();
            _depositTransaction.Print();
        }
    }
}