using System.Text;

Console.OutputEncoding = Encoding.UTF8;

Console.WriteLine("Вітаю, ця програма перевіряє чи являється введене число поліндромом");
Console.Write("Введіть число: ");
string number = Console.ReadLine();

string ReverseString(string s)
{
    char[] arr = s.ToCharArray();
    Array.Reverse(arr);
    return new string(arr);
}

string st = ReverseString(number);
if (number == st) Console.WriteLine("Так, це число являється поліндромом");
else Console.WriteLine("Нажаль це число не поліндром");