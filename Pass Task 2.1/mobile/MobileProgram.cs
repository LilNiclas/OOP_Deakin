namespace Task_2_1
{
    class MobileProgram
    {
        static void Main(string[] args)
        {
            //QUESTION 1
            Mobile jimMobile = new Mobile("Monthly", "iPhone 13", "07712223344");

            //Setters
            jimMobile.SetAccType("PAYG");
            jimMobile.SetDevice("Samsung Galaxy S21");
            jimMobile.SetNumber("07799887766");
            jimMobile.SetBalance(100.50);

            //Methods
            jimMobile.addCredit(10.0);
            jimMobile.makeCall(5);
            jimMobile.sendText(2);

            Console.WriteLine("Account Type: " + jimMobile.GetAccType() + "\nMobile Number: " +
            jimMobile.GetNumber() + "\nDevice: " + jimMobile.GetDevice() +
            "\nBalance: " + jimMobile.GetBalance());
            
            
            //Question 2
            Mobile testMobile = new Mobile("Monthly", "Blackberry", "0450376351");

            testMobile.addCredit(20);
            testMobile.cd(15);
            testMobile.sendText(5);
            
            Console.WriteLine("Account Type: " + testMobile.GetAccType() + "\nMobile Number: " +
            testMobile.GetNumber() + "\nDevice: " + testMobile.GetDevice() +
            "\nBalance: " + testMobile.GetBalance());
        }
    }
}