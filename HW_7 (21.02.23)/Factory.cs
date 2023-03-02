using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Net.Http.Headers;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;


internal class Factory
{
    public string? Name { get; set; }
    public Employee[]? Employees { get; set; }
    public Product[]? Products { get; set; }
    public Factory(string name, Employee[]? employees, Product[]? products)
    {
        Name = name;
        Employees = employees;
        Products = products;
    }
    public decimal AvgSalary 
    { 
        get
        {
            decimal sum = 0;
            int count = 0;

            foreach (var employee in Employees)
            {
                sum += employee.Salary;
                count++;
            }
            if (count == 0) return 0;
            
            return sum/count;
            
        }
    } 
    
    public decimal TotalSalary
    {
        get
        {
            decimal sum = 0;
            foreach (var employee in Employees)
            {
                sum += employee.Salary;
            }
            return sum;
        }
    }

    public decimal GDP
    {
        get
        {
            decimal sumProduct = 0;
            int countEmploees = Employees.Length;
            foreach (var item in Products)
            {
                sumProduct += item.Price;
            }
            return sumProduct/countEmploees;
        }
    }
    public int EmpCount
    {
        get
        {
            int countEmploees = 0;
            return countEmploees = Employees.Length;
        }
    }
    public override string ToString()
    {
        return $"Factory: {Name}, Employees: {Employees?.Length}, Products: {Products?.Length}";
    }
}

