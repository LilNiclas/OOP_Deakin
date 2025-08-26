namespace task_2_1
{
    class EmployeeProgram
    {

        static void Main(string[] args)
        {
            Employee emp = new Employee("Nidos", 50000);
            emp.raiseSalary(10);
            double taxes = emp.Tax();
            Console.WriteLine("Annual tax for " + emp.GetName() + " is: " + taxes);
        }
    }
}