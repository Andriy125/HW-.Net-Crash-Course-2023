using System.Text;

Console.OutputEncoding = Encoding.UTF8;



Console.WriteLine("Привіт, я програма яка виводить лінію заданих символів заданої довжини");
Console.Write("Введіть символ: ");
char symbol = Convert.ToChar(Console.ReadLine());

Console.Write("Введіть довжину лінії: ");
int lenght = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine(("\n").PadRight(lenght, symbol));

Console.WriteLine("");
for (int i = 0;i < lenght; i++)
{
    Console.Write(symbol);
}