



using Expression.Model;
using System.Linq.Expressions;

List<Employee> employees4 = new List<Employee>
{
   new Employee { Id = 1, Name = "John", Surname = "Doe", Age = 28 },
   new Employee { Id = 2, Name = "Jane", Surname = "Smith", Age = 34 },
   new Employee { Id = 3, Name = "Michael", Surname = "Johnson", Age = 45 },
   new Employee { Id = 4, Name = "Emily", Surname = "Davis", Age = 23 },
   new Employee { Id = 5, Name = "David", Surname = "Wilson", Age = 37 }
};



Expression<Func<Employee, string>> formatName = x => x.Name.Substring(0, 1).ToUpper() + x.Name.Substring(1).ToLower();


Expression<Func<Employee, string>> formatSurname = x => x.Surname.ToUpper();


Expression<Func<Employee, string>> formatMail = x => x.Name.ToLower() + "." + x.Surname.ToLower() + "@hotmail.com";




var formattedText = employees4.AsQueryable().Select(x => new
{

    FirstName = formatName.Compile()(x),
    LastName = formatSurname.Compile()(x),
    Mail = formatMail.Compile()(x)

}).ToList();

formattedText.ForEach(a =>
{

    Console.WriteLine($"Name:{a.FirstName}\nSurname:{a.LastName}\nMail:{a.Mail}");
    Console.WriteLine(new string('-', 50));

});