using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


internal class Fish : Animal
{
    public bool HasGills { get; set; } 
    public bool IsSaltwater { get; set; }
    public Fish(string species, double speed, double weight, string habitat, bool hasGills, bool isSaltWater) 
        : base(species, speed, weight, habitat)
    {
        HasGills = hasGills;
        IsSaltwater = isSaltWater;
    }

    public new void Move()
    {
        Console.WriteLine($"\t{Species} плаває зі швидкістю {Speed} км/год");
    }
    public new void MakeSound()
    {
        Console.WriteLine("\tБуль, буль");
    }

    public new void Show()
    {
        base.Show();
        Console.WriteLine($"\t{(HasGills ? "Має зябра": "Зябра відсутні")}, {(IsSaltwater ? "Може плавати в солоній воді" : "Прісноводна")}");
    }
}

