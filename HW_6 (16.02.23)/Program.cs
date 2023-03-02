Plane[] planes = new Plane[]
{
    new Plane("Boeing", "747", 2000, 900, 400),
    new Plane("Airbus", "A320", 2010),
    new Plane("Embraer", "E175", 2015, 800, 80),
    new Plane("Bombardier", "CRJ700", 2005, 750, 70),
    new Plane()
};

// Викликаємо методи для кожного об'єкту Plane
foreach (var plane in planes)
{
    Console.WriteLine($"Plane ID: {plane.id}");
    Console.WriteLine($"Manufacturer: {plane.Manufacturer}");
    Console.WriteLine($"Model: {plane.Model}");
    Console.WriteLine($"Year of manufacture: {plane.YearOfManufacture}");
    Console.WriteLine($"Max speed: {plane.MaxSpeed}");
    Console.WriteLine($"Max passengers: {plane.MaxPassengers}");
    Console.WriteLine($"Age: {plane.GetAge()}");
    plane.LoadPassengers(150);
    plane.Fly();
    Console.WriteLine(new string('-', 50));
    Console.WriteLine();
}