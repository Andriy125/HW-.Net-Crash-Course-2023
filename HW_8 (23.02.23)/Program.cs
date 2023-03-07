using System.Text;
Console.OutputEncoding = Encoding.UTF8;

Animal animal = new Animal("Лев", 80, 200, "Савана");
animal.Show(); 
animal.Move();
animal.MakeSound();
Console.WriteLine(new string('-', 50));

Bird bird = new Bird("Горобець", 40, 0.5, "Європа", "Сірий");
bird.Show();
bird.Move();
bird.MakeSound();
Console.WriteLine(new string('-', 50));


Fish fish = new Fish("Форель", 20, 2.1, "Річки та озера", true, false);
fish.Show();
fish.Move();
fish.MakeSound();
Console.WriteLine(new string('-', 50));

Reptile reptile = new Reptile("Крокодил", 20, 500.0, "Річки та озера", true, true);
reptile.Show();
reptile.Move();
reptile.MakeSound();
Console.WriteLine(new string('-', 50));
Console.WriteLine(new string('-', 50));
Console.WriteLine(new string('-', 50));
Console.WriteLine("");


Animal[] zoo = new Animal[4];
zoo[0] = new Animal("Кіт", 20, 10, "По всій планеті");
zoo[1] = new Bird("Орел", 150, 30, "Мексика, США, Австралія", "Біло-коричневий");
zoo[2] = new Fish("Черепаха", 60, 100, "Океан", false, false);
zoo[3] = new Reptile("Леопардова Ящірка", 15, 20, "Пустеля Північної Америки", true, false);

foreach (var anima in zoo)
{
    anima.Show();
    anima.Move();
    anima.MakeSound();
    Console.WriteLine("");
    Console.WriteLine(new string('-', 50));
}