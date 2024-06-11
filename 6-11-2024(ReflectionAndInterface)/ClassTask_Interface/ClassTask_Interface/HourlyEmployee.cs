using ClassTask_Interface.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ClassTask_Interface;

public class HourlyEmployee : IEmployee
{

    private static int _Id = 1;
    public int Id { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public int age { get; set; }
    public int HourWorked { get; set; }
    public double SalaryByHour { get; set; }

    public HourlyEmployee()
    {
        Id = _Id;
        _Id++;
    }



    public double CalculateSalary()
    {
        return  HourWorked*SalaryByHour;
    }



    public void DisplayDetails()
    {

        PropertyInfo[] props = this.GetType().GetProperties();
        string propertyLength = props
        .Select(p => p.Name)
        .OrderByDescending(name => name.Length)
        .FirstOrDefault();


        foreach (PropertyInfo property in props)
        {
            Console.WriteLine($"{property.Name.PadRight(propertyLength.Length)} : {property.GetValue(this)}");
        }


    }

}
