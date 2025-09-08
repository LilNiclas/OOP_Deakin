using System;
using System.Collections.Generic;
namespace task_7_1
{
    class Bank
    {
        private List<Account> _accounts = new List<Account>();
        private List<Transaction> _transactions = new List<Transaction>();

        public void AddAccount(Account account)
        {
            _accounts.Add(account);
        }

        public Account GetAccount(string name)
        {
            foreach (Account acc in _accounts)
            {
                if (acc.GetName() == name)
                {
                    return acc;
                }
            }
            return null;
        }

        public void ExecuteTransaction(Transaction transaction)
        {
            transaction.Execute();
            _transactions.Add(transaction);
        }

        public void RollbackTransaction(Transaction transaction)
        {
            try
            {
                transaction.Rollback();
                Console.WriteLine("Transaction was rolled back");
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine("Rollback failed: " + e.Message);
            }
        }

        public void PrintTranscationHistory()
        {
            if (_transactions.Count == 0)
            {
                Console.WriteLine("No transactions");
                return;
            }

            Console.WriteLine("Transactions:");
            foreach (Transaction transaction in _transactions)
            {
                int index = _transactions.IndexOf(transaction) + 1;
                Console.WriteLine("\nTransaction " + index);
                transaction.Print();
            }
        }

        public Transaction GetTransaction(int index)
        {

            if (index > 0 || index <= _transactions.Count)
            {
                return _transactions[index];
            }
            else
            {
                return null;
            }
        }
    }
}