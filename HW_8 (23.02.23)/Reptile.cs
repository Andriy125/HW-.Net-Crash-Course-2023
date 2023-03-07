using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


internal class Reptile : Animal
{


    public bool HasScales { get; set; } 
    public bool IsColdBlooded { get; set; } 

    public Reptile(string species, double speed, double weight, string habitat, bool hasScales, bool isColdBlooded) 
        : base(species, speed, weight, habitat)
    {
        HasScales = hasScales;
        IsColdBlooded = isColdBlooded;
    }
    public new void Move()
    {
        Console.WriteLine($"\t{Species} рухається повзучим ходом зі швидкістю {Speed} км/год");
    }

    public new void MakeSound()
    {
        Console.WriteLine($"\t[{Species} емітує звук рептилії]");
    }

    public new void Show()
    {
        base.Show();
        Console.WriteLine($"\t{(HasScales ? "Присутня наявність луски" : "Явна відсутність луски")}, {(IsColdBlooded ? "Холоднокровна" : "Теплокровна")}");

    }

}
