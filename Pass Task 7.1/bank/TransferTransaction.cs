using System;
namespace task_7_1
{
    class TransferTransaction : Transaction
    {
        private Account _fromAccount;
        private Account _toAccount;
        private WithdrawTransaction _withdraw;
        private DepositTransaction _deposit;

        public TransferTransaction(Account fromAccount, Account toAccount, decimal amount) : base(amount)
        {
            _fromAccount = fromAccount;
            _toAccount = toAccount;
            _withdraw = new WithdrawTransaction(_fromAccount, _amount);
            _deposit = new DepositTransaction(_toAccount, _amount);
        }

        public override bool Success => _withdraw.Success && _deposit.Success;

        public override void Execute()
        {
            base.Execute();

            try
            {
                _withdraw.Execute();
                _deposit.Execute();
                _success = true;
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException("Transfer failed: " + ex.Message);
            }
        }

        public override void Rollback()
        {
            base.Rollback();

            if (!Success)
            {
                throw new InvalidOperationException("Transfer was not successful, can't rollback.");
            }
           
            try
            {
                _deposit.Rollback();
                _withdraw.Rollback();
                _success = false;
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException("Rollback failed: " + ex.Message);
            }
        }

        public override void Print()
        {
            Console.WriteLine("Transferred " + _amount + " from " + _fromAccount.GetName() + " to " + _toAccount.GetName());
            Console.WriteLine("Executed: " + Executed + "\nSuccess: " + Success + "\nReversed: " + Reversed + "\nDate: " + DateStamp);
            _withdraw.Print();
            _deposit.Print();
        }
    }
}