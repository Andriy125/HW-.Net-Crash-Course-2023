using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


internal class Plane
{
    private string manufacturer;
    private string model;
    private int yearOfManufacture;
    private double maxSpeed;
    private int maxPassengers;
    public string Manufacturer
    {
        get { return manufacturer; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                Console.WriteLine("Manufacturer name cannot be empty.");
            }
            manufacturer = value.Trim();
        }
    }

    public string Model
    {
        get { return model; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                Console.WriteLine("Model name cannot be empty.");                
            }
            model = value.Trim();
        }
    }

    public int YearOfManufacture
    {
        get { return yearOfManufacture; }
        set
        {
            if (value < 1900 || value > DateTime.Now.Year)
            {
                Console.WriteLine("Year of manufacture must be between 1900 and current year.");
            }
            else
            {
                yearOfManufacture = value;
            }
        }
    }

    public double MaxSpeed
    {
        get { return maxSpeed; }
        set
        {
            if (value <= 0)
            {
                Console.WriteLine("Max speed must be positive.");
            }
            else
            {
                maxSpeed = value;
            }
        }
    }

    public int MaxPassengers
    {
        get { return maxPassengers; }
        set
        {
            if (value <= 0)
            {
                Console.WriteLine("Max passengers must be positive.");
            }
            else
            {
                maxPassengers = value;
            }
        }
    }

    public readonly string id;
    private static int count = 0;
    public Plane()
    {
        id = $"PL{count:D5}";
        count++;
    }

    public Plane(string manufacturer, string model, int yearOfManufacture, double maxSpeed, int maxPassengers) : this()

    {
        Manufacturer = manufacturer;
        Model = model;
        YearOfManufacture = yearOfManufacture;
        MaxSpeed = maxSpeed;
        MaxPassengers = maxPassengers;
    }
    public Plane(string manufacturer, string model, int yearOfManufacture)
    : this(manufacturer, model, yearOfManufacture, 800, 200)
    {
    }

    public void Fly()
    {
        Console.WriteLine($"The {Manufacturer} {Model} is flying at {MaxSpeed} km/h.");
    }

    public void LoadPassengers(int numPassengers)
    {
        if (numPassengers > MaxPassengers)
        {
            Console.WriteLine($"The {Manufacturer} {Model} cannot carry {numPassengers} passengers. Max capacity is {MaxPassengers}.");
        }
        else
        {
            Console.WriteLine($"Loading {numPassengers} passengers onto the {Manufacturer} {Model}.");
        }
    }

    public double GetAge()
    {
        return DateTime.Now.Year - YearOfManufacture;
    }
}

