using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Animal
{
    public string Species { get; set; }
    public double Speed { get; set; }
    public double Weight { get; set; }
    public string Habitat { get; set; }

    public Animal(string species, double speed, double weight, string habitat)
    {
        Species = species;
        Speed = speed;
        Weight = weight;
        Habitat = habitat;
    }

    public void Move()
    {
        Console.WriteLine("\tДана тварина має можливість рухатись: рух туди, рух сюди.");
    }

    public void MakeSound()
    {
        Console.WriteLine("\tДана тварина може відтворювати звуки");
    }

    public void Show()
    {
        Console.WriteLine("Основні відомості:");
        Console.WriteLine($"\tВид: {Species}");
        Console.WriteLine($"\tШвидкість: {Speed} Км/год");
        Console.WriteLine($"\tВага: {Weight} кг.");
        Console.WriteLine($"\tСередовище мешкання: {Habitat}");
    }
}


