using System;
namespace task_5_2
{
    class BankSystem
    {
        static void Main(string[] args)
        {
            Account fromAccount = new Account("Niclas", 500m);
            Account toAccount = new Account("Bobbers", 300m);
            MenuOption choice;

            do
            {
                choice = ReadUserOption();
                
                switch (choice)
                {
                    case MenuOption.Withdraw:
                        DoWithdraw(fromAccount);
                        break;

                    case MenuOption.Deposit:
                        DoDeposit(fromAccount);
                        break;

                    case MenuOption.Transfer:
                        DoTransfer(fromAccount, toAccount);
                        break;

                    case MenuOption.Print:
                        DoPrint(fromAccount, toAccount);
                        break;

                    case MenuOption.Quit:
                        Console.WriteLine("See ya mister!");
                        break;

                    default:
                        Console.WriteLine("Unknown option");
                        break;
                }

            } while (choice != MenuOption.Quit);

            Console.WriteLine("Thanks for using the bank system!");
        }

        static MenuOption ReadUserOption()
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("1. Withdraw");
                    Console.WriteLine("2. Deposit");
                    Console.WriteLine("3. Transfer");
                    Console.WriteLine("4. Print");
                    Console.WriteLine("5. Quit");
                    Console.Write("Choose an option (1-5): ");

                    int input = Convert.ToInt32(Console.ReadLine());

                    if (input >= 1 && input <= 4)
                    {
                        return (MenuOption)(input - 1);
                    }
                    else
                    {
                        Console.WriteLine("Input must be between 1 and 4");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("You can only enter integers" + "\n"+ e.Message);
                }
            }
        }

        static void DoWithdraw(Account account)
        {
            Console.Write("Enter amount to withdraw: ");
            decimal amount = Convert.ToDecimal(Console.ReadLine());
            WithdrawTransaction transaction = new WithdrawTransaction(account, amount);
            try
            {
                transaction.Execute();
                Console.WriteLine("Withdrawal successful");
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine(e.Message);
            }
            transaction.Print();
        }

        static void DoDeposit(Account account)
        {
            Console.Write("Enter amount to deposit: ");
            decimal amount = Convert.ToDecimal(Console.ReadLine());
            DepositTransaction transaction = new DepositTransaction(account, amount);
            try
            {
                transaction.Execute();
                Console.WriteLine("Withdrawal successful");
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine(e.Message);
            }
            transaction.Print();
        }

        static void DoTransfer(Account from, Account to)
        {
            Console.Write("Enter amount to transfer: ");
            decimal amount = Convert.ToDecimal(Console.ReadLine());
            TransferTransaction transaction = new TransferTransaction(from, to, amount);
            try
            {
                transaction.Execute();
                Console.WriteLine("Transfer successful");
                transaction.Print();

                transaction.Rollback();
                Console.WriteLine("Transfer rolled back");
                transaction.Print();
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine(e.Message);
            }
        }


        static void DoPrint(Account fromAccount, Account toAccount)
        {
            fromAccount.Print();
            toAccount.Print();
        }

    }
    public enum MenuOption
    {
        Withdraw,
        Deposit,
        Transfer,
        Print,
        Quit
    }
}
