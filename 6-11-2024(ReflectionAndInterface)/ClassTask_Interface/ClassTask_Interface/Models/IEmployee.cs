using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTask_Interface.Models;

public interface IEmployee
{

    public int Id { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public int age { get; set; }



    double CalculateSalary();
    void DisplayDetails();
}
