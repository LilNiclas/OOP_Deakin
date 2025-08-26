using System;
namespace task_2_2
{
    class TestAccount
    {
        static void Main(string[] args)
        {
            Account myAccount = new Account("Niclas", 500m);

            myAccount.Deposit(150.50m);
            myAccount.Print();

            myAccount.Withdraw(100m);
            myAccount.Print();

            //Withdrawing too much
            myAccount.Withdraw(1000m);
            myAccount.Print();
        }
    }
}
