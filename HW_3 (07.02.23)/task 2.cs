using System.Text;

Console.OutputEncoding = Encoding.UTF8;


Console.WriteLine("Привіт, давай зіграємо гру, я загадую число від 1 до 10, а ти вгадай");

Random rnd = new Random();
int value = rnd.Next(1,10);
//Console.WriteLine($"Загадане число = {value}");
int try_count = 0;
int number = 0;
do
{
    number = Convert.ToInt32(Console.ReadLine());
    if (number != value) Console.WriteLine("Спробуй ще раз");
    try_count++;
} while (number != value);

Console.WriteLine($"Кількість кроків: {try_count}");