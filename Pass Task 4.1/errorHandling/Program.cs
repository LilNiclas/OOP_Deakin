using System;
using System.Collections.Generic;

namespace ExceptionHandling
{
    class Program
    {
        static void Main()
        {
            static void Print(Exception ex)
            {
                Console.WriteLine("An error occured: " + ex.GetType().ToString() + "\n" + ex.Message + "\n");
            }

            // NullReferenceException
            try
            {
                object o = null;
                _ = o.ToString();
            }
            catch (NullReferenceException ex)
            {
                Print(ex);
            }

            // IndexOutOfRangeException
            try
            {
                int[] arr = new int[2];
                int v = arr[5];
            }
            catch (IndexOutOfRangeException ex)
            {
                Print(ex);
            }

            // DivideByZeroException
            try
            {
                int a = 1;
                int b = 0;
                int c = a / b;
            }
            catch (DivideByZeroException ex)
            {
                Print(ex);
            }

            // ArgumentNullException
            try
            {
                ArgumentNullExceptionMethod(null);
            }
            catch (ArgumentNullException ex)
            {
                Print(ex);
            }

            // ArgumentOutOfRangeException
            try
            {
                GivePositiveNumber(-5);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Print(ex);
            }

            // FormatException
            try
            {
                int x = Convert.ToInt32("yo");
            }
            catch (FormatException ex)
            {
                Print(ex);
            }

            // ArgumentException
            try
            {
                SetNonEmptyName("");
            }
            catch (ArgumentException ex)
            {
                Print(ex);
            }

            // SystemException
            try
            {
                try
                {
                    int x = Convert.ToInt32("yo");
                }
                catch (FormatException)
                {
                    throw;
                }
            }
            catch (SystemException ex)
            {
                Print(ex);
            }

            // InvalidOperationException
            try
            {
                Account account = new Account("Niclas", "Nielsen", 100);
                account.Withdraw(10);
                account.Withdraw(1000);
            }
            catch (InvalidOperationException ex)
            {
                Print(ex);
            }
        }

        static void ArgumentNullExceptionMethod(object arg)
        {
            if (arg is null)
            {
                throw new ArgumentNullException(nameof(arg), "Argument cannot be null");
            }
        }

        static void GivePositiveNumber(int amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), amount, "Amount must be positive");
            }
        }

        static void SetNonEmptyName(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("Name cannot be empty or whitespace", nameof(name));
            }
        }
    }
    class Account
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public int Balance { get; private set; }

        public Account(string firstName, string lastName, int balance)
        {
            FirstName = firstName;
            LastName = lastName;
            Balance = balance;
        }

        public void Withdraw(int amount)
        {
            if (amount > Balance)
            {
                throw new InvalidOperationException("Insufficient fund");
            }
            Balance = Balance - amount;
        }
    }
}
