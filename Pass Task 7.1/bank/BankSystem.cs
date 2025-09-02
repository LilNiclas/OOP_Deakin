using System;
namespace task_7_1
{
    class BankSystem
    {
        static void Main(string[] args)
        {
            //Initial accounts and bank
            Bank bank = new Bank();

            Account fromAccount = new Account("Niclas", 500m);
            Account toAccount = new Account("Bobbers", 300m);

            bank.AddAccount(fromAccount);
            bank.AddAccount(toAccount);

            //Enum
            MenuOption choice;

            do
            {
                choice = ReadUserOption();

                switch (choice)
                {
                    case MenuOption.Withdraw:
                        DoWithdraw(bank);
                        break;

                    case MenuOption.Deposit:
                        DoDeposit(bank);
                        break;

                    case MenuOption.Transfer:
                        DoTransfer(bank);
                        break;

                    case MenuOption.AddAccount:
                        AddNewAccount(bank);
                        break;

                    case MenuOption.Print:
                        DoPrint(bank);
                        break;

                    case MenuOption.History:
                        DoHistory(bank);
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
                    Console.WriteLine("4. Add Account");
                    Console.WriteLine("5. Print");
                    Console.WriteLine("6. Transaction History");
                    Console.WriteLine("7. Quit");

                    int input = ReadInteger("Choose an option (1-7): ");

                    if (input >= 1 && input <= 7)
                    {
                        return (MenuOption)(input - 1);
                    }
                    else
                    {
                        Console.WriteLine("Input must be between 1 and 7");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("You can only enter integers" + "\n" + e.Message);
                }
            }
        }

        static void DoWithdraw(Bank bank)
        {
            Account account = FindAccount(bank);
            if (account == null)
            {
                return;
            }

            decimal amount = ReadDecimal("Enter amount to withdraw: ");
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

        static void DoDeposit(Bank bank)
        {
            Account account = FindAccount(bank);
            if (account == null)
            {
                return;
            }

            decimal amount = ReadDecimal("Enter amount to deposit: ");
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

        static void DoTransfer(Bank bank)
        {
            Console.WriteLine("From Account:");
            Account from = FindAccount(bank);
            if (from == null) return;

            Console.WriteLine("To Account:");
            Account to = FindAccount(bank);
            if (to == null) return;

            decimal amount = ReadDecimal("Enter amount to transfer: ");
            TransferTransaction transaction = new TransferTransaction(from, to, amount);
            try
            {
                transaction.Execute();
                Console.WriteLine("Transfer successful");
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine(e.Message);
            }
            transaction.Print();
        }

        static void AddNewAccount(Bank bank)
        {
            Console.Write("Enter account name: ");
            string name = Console.ReadLine();

            Console.Write("Enter balance: ");
            decimal balance = ReadDecimal("Enter balance: ");
            Account newAccount = new Account(name, balance);
            bank.AddAccount(newAccount);
            Console.WriteLine("The account " + name + " has been added\n");
        }

        static void DoPrint(Bank bank)
        {
            Account account = FindAccount(bank);
            if (account != null)
            {
                account.Print();
            }
        }

        static void DoHistory(Bank bank)
        {
            bank.PrintTransactions();

            Console.WriteLine("Do you want to rollback a transaction? (y/n)");
            string input = Console.ReadLine();

            if (input.ToLower() == "y")
            {
                int index = ReadInteger("Enter the number of the transaction you want to rollback: ");
                Transaction transaction = bank.GetTransaction(index - 1);

                if (transaction != null)
                {
                    bank.RollbackTransaction(transaction);
                }
                else
                {
                    Console.WriteLine("No transaction was found");
                }
            }

        }

        private static Account FindAccount(Bank bank)
        {
            Console.Write("Enter account name: ");
            string name = Console.ReadLine();

            Account account = bank.GetAccount(name);

            if (account == null)
            {
                Console.WriteLine("Account " + name + " not found");
            }

            return account;
        }

        private static decimal ReadDecimal(string prompt)
        {
            while (true)
            {
                Console.WriteLine(prompt);
                string input = Console.ReadLine();
                try
                {
                    return Convert.ToDecimal(input);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Error! Enter a number");
                }
            }
        }
        
        private static int ReadInteger(string prompt)
        {
            while (true)
            {
                Console.Write(prompt);
                string input = Console.ReadLine();
                try
                {
                    return Convert.ToInt32(input);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Error! Enter an integer");
                }
            }
        }



    }
    public enum MenuOption
    {
        Withdraw,
        Deposit,
        Transfer,
        AddAccount,
        Print,
        History,
        Quit
    }
}
