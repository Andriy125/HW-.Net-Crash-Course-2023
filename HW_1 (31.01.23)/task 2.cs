using System.Text;

Console.OutputEncoding = Encoding.UTF8;

Console.WriteLine("введіть довжину сторони а:");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("введіть довжину сторони b:");
int b = Convert.ToInt32(Console.ReadLine());

int perimeter = (a + b) * 2;
int square = a * b;
Console.WriteLine($"\nПериметр: {perimeter} \nПлоща: {square}");
