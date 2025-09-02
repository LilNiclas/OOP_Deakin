using System;

namespace task_7_1
{
    abstract class Transaction
    {
        protected decimal _amount;
        protected bool _success;
        private bool _executed;
        private bool _reversed;
        private DateTime _datestamp;

        public abstract bool Success { get; }
        public bool Executed => _executed;
        public bool Reversed => _reversed;
        public DateTime DateStamp => _datestamp;

        protected Transaction(decimal amount)
        {
            _amount = amount;
            _success = false;
            _executed = false;
            _reversed = false;
        }

        public virtual void Execute()
        {
            if (_executed)
            {
                throw new InvalidOperationException("Transaction has already been executed.");
            }
            _executed = true;
            _datestamp = DateTime.Now;
        }

        public virtual void Rollback()
        {
            if (!_executed)
            {
                throw new InvalidOperationException("Transaction has not been executed yet.");
            }
            if (_reversed)
            {
                throw new InvalidOperationException("Transaction has already been reversed.");
            }
            _reversed = true;
            _datestamp = DateTime.Now;
        }

        public abstract void Print();
    }
}
