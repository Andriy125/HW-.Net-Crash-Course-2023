using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Bird : Animal
{
    public string Feather_color { get; set; }

    public Bird(string species, double speed, double weight, string habitat, string feather_color) 
        : base(species, speed, weight, habitat)
    {
        Feather_color = feather_color;
    }

    public new void Move()
    {
        Console.WriteLine("\tВикористовуючи підйомну силу та закони аєродинаміки, або пішочки... переміщуюсь в просторі");
    }

    public new void MakeSound()
    {
        Console.WriteLine("\t\"Щось на птичому\"");
    }

    public new void Show()
    {
        base.Show();
        Console.WriteLine($"\tКолір окрасу: {Feather_color}");
    }
}

