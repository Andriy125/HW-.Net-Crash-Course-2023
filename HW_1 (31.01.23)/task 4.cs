using System.Text;

Console.OutputEncoding = Encoding.UTF8;

Console.WriteLine("Введіть час в секундах: ");
int input = Convert.ToInt32(Console.ReadLine());

int sec = 0;
int min = 0;
int hour = 0;

if (input > 60)
{
    min = input / 60;
    sec = input % 60;
}

if (min > 60) 
{ 
    hour = min / 60;
    min = min % 60;
}

Console.WriteLine($"В заданій кількості секунд ({input}) буде мати ось такий вигляд у форматі HH:MM:SS = {hour}:{min}:{sec}");


