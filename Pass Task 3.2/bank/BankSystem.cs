using System;
namespace task_3_2
{
    class BankSystem
    {
        static void Main(string[] args)
        {
            Account myAccount = new Account("Niclas", 500m);
            MenuOption choice;

            do
            {
                choice = ReadUserOption();
                
                switch (choice)
                {
                    case MenuOption.Withdraw:
                        DoWithdraw(myAccount);
                        break;

                    case MenuOption.Deposit:
                        DoDeposit(myAccount);
                        break;

                    case MenuOption.Print:
                        DoPrint(myAccount);
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
                    Console.WriteLine("3. Print");
                    Console.WriteLine("4. Quit");
                    Console.Write("Choose an option (1-4): ");

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
            if (account.Withdraw(amount))
            {
                Console.WriteLine("Withdrawal successful!");
            }
        }

        static void DoDeposit(Account account)
        {
            Console.Write("Enter amount to deposit: ");
            decimal amount = Convert.ToDecimal(Console.ReadLine());
            if (account.Deposit(amount))
            {
                Console.WriteLine("Deposit successful");
            }
            else
            {
                Console.WriteLine("Deposit amount must be positive");
            }
        }

        static void DoPrint(Account account)
        {
            account.Print();
        }


    }
    public enum MenuOption
    {
        Withdraw,
        Deposit,
        Print,
        Quit
    }
}
