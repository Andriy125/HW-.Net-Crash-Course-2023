
using System.Text;

Console.OutputEncoding = Encoding.UTF8;

Console.Write("Введіть кількість співробітників: ");
int employeesCount = int.Parse(Console.ReadLine());

Employee[] employees = new Employee[employeesCount];

for (int i = 0; i < employeesCount; i++)
{
    Console.Write($"Ім'я співробітника {i + 1}: ");
    string Name = Console.ReadLine();

    Console.Write($"Призвіще співробітника {i + 1}: ");
    string Surname = Console.ReadLine();

    Console.Write($"Дата народження співробітника {i + 1} (у форматі dd.mm.yyyy): ");
    DateTime BirthTime = DateTime.Parse(Console.ReadLine());

    Console.Write($"Зарплата співробітника {i + 1}: ");
    decimal Salary = decimal.Parse(Console.ReadLine());
    Console.WriteLine("");

    employees[i] = new Employee(Name, Surname, BirthTime, Salary);
}

Console.WriteLine(new string('-', 50));
Console.WriteLine("");

Console.Write("Введіть кількість продуктів: ");
int productsCount = int.Parse(Console.ReadLine());

Product[] products = new Product[productsCount];
for (int i = 0; i < productsCount; i++)
{
    Console.Write($"Назва продукту {i + 1}: ");
    string Name = Console.ReadLine();

    Console.Write($"Дата виготовлення продукту {i + 1} (у форматі dd.mm.yyyy): ");
    DateTime manufactureDate = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy", null);

    Console.WriteLine($"Категорія продукту {i + 1}");
    Console.WriteLine("Доступні категорії: Food, Electronics, Clothing, Beauty, Home");
    Console.Write("Ваш вибір: ");

    CategoryType category = (CategoryType)Enum.Parse(typeof(CategoryType), Console.ReadLine());

    Console.Write($"Ціна продукту {i + 1}: ");
    decimal price = decimal.Parse(Console.ReadLine());
    Console.WriteLine("");


    products[i] = new Product(Name, manufactureDate, category, price);
}

Console.WriteLine(new string('-', 50));
Console.WriteLine("");

Console.Write("Назва підприємства: ");
string name = Console.ReadLine();

Factory factory = new Factory(name, employees, products);

Console.WriteLine("Нове підприємство створено:");
Console.WriteLine(factory.ToString());

Console.WriteLine("\n");
Console.WriteLine(new string('-', 50 ));
Console.WriteLine($"Середня зарплата по підриємству: {factory.AvgSalary}");
Console.WriteLine($"Сумарна зарплата: {factory.TotalSalary}");
Console.WriteLine($"Валовий дохід на 1-го працівника: {factory.GDP}");
Console.WriteLine($"Загальна кількость працюючих: {factory.EmpCount}");