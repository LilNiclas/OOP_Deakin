using System;
using System.Collections.Generic;
namespace task_7_1
{
    class Bank
    {
        private List<Account> _accounts = new List<Account>();

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

        public void ExecuteTransaction(DepositTransaction transaction)
        {
            transaction.Execute();
        }

        public void ExecuteTransaction(WithdrawTransaction transaction)
        {
            transaction.Execute();
        }

        public void ExecuteTransaction(TransferTransaction transaction)
        {
            transaction.Execute();
        }
    }
}