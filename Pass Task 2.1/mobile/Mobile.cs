namespace Task_2_1
{
    class Mobile
    {
        private string accType, device, number;
        private double balance;

        //Const
        private const double CALL_COST = 0.245;
        private const double TEXT_COST = 0.078;

        public Mobile(string accType, string device, string number)
        {
            this.accType = accType;
            this.device = device;
            this.number = number;
            this.balance = 0.0;
        }

        //Getters
        public string GetAccType()
        {
            return this.accType;
        }
        public string GetDevice()
        {
            return this.device;
        }
        public string GetNumber()
        {
            return this.number;
        }
        public double GetBalance()
        {
            return this.balance;
        }
        
        //Setters
        public void SetAccType(string accType)
        {
            this.accType = accType;
        }
        public void SetDevice(string device)
        {
            this.device = device;
        }

        public void SetNumber(string number)
        {
            this.number = number;
        }

        public void SetBalance(double balance)
        {
            this.balance = balance;
        }

        // Methods
        public void addCredit(double amount)
        {
            this.balance += amount;
            Console.WriteLine("Added " + amount + " to balance.\nNew balance: " + GetBalance());
        }
        public void makeCall(int minustes)
        {
            double cost = minustes * CALL_COST;
            this.balance -= cost;
            Console.WriteLine("Made a call for " + minustes + " minutes. Cost: " + cost + ". New balance: " + GetBalance());
        }

        public void sendText(int numTexts)
        {
            double cost = numTexts * TEXT_COST;
            this.balance -= cost;
            Console.WriteLine("Sent " + numTexts + " texts. Cost: " + cost + ". New balance: " + GetBalance());
        }
    }
}