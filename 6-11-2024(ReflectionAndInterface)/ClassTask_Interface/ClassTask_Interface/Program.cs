using System.Collections;

namespace ClassTask_Interface
{
    internal class Program
    {
        static void Main(string[] args)
        {

            SalariedEmployee employee = new SalariedEmployee()
            {
                age = 10,
                Name = "Test Name",
                Surname = "Test Surname",
                MonthlySalary = 4321

            };


            HourlyEmployee employee2 = new HourlyEmployee()
            {
                age = 12,
                Name = "Test2 Name",
                Surname = "Test2 Surname",
                HourWorked = 8,
                SalaryByHour = 100,

            };

            Console.WriteLine($"Monthly worker salary:{employee.CalculateSalary()}");
            employee.DisplayDetails();
            Console.WriteLine(new string('-', 50));
            Console.WriteLine($"Hourly worker salary:{employee2.CalculateSalary()}");
            employee2.DisplayDetails();


        }
    }
}
