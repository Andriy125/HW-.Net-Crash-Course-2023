using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


internal class Employee
{
    public string? Name { get; set; }
    public string? Surname { get; set; }
    public DateTime BirthTime { get; set; }
    public decimal Salary { get; set; }
    public Employee(string? name, string? surname, DateTime birthTime, decimal salary)
    {
        Name = name;
        Surname = surname;
        BirthTime = birthTime;
        Salary = salary;
    }
    public override string ToString()
    {
        return $"Name: {Name}" + $"Surname: {Surname}" + $"BirthTime: {BirthTime}" + $"Salary: {Salary}";
    }

}

