namespace task_2_1
{
    class Employee
    {
        private string name;
        private double salary;

        public Employee(string name, double salary)
        {
            this.name = name;
            this.salary = salary;
        }

        //Getter
        public string GetName()
        {
            return this.name;
        }
        public double GetSalary()
        {
            return this.salary;
        }

        //Method
        public void raiseSalary(double percent)
        {
            double change = salary * percent / 100.0;
            double oldSalary = salary;
            salary += change;
            Console.WriteLine("Salary raised from " + oldSalary + " to " + salary + " by " + percent + "%");
        }
        
        public double Tax()
        {
            salary = GetSalary();
            double tax = 0;

            if (salary <= 18200)
            {
                tax = 0;
            }
            else if (salary <= 37000)
            {
                tax = (salary - 18200) * 0.19;
            }
            else if (salary <= 90000)
            {
                tax = 3572 + (salary - 37000) * 0.325;
            }
            else if (salary <= 180000)
            {
                tax = 20797 + (salary - 90000) * 0.37;
            }
            else
            {
                tax = 54096 + (salary - 180000) * 0.45;
            }

            return tax;
        }

    }
}