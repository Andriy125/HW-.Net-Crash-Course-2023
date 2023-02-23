using System.Text;
Console.OutputEncoding = Encoding.UTF8;

Console.WriteLine("Введіть рядок: ");
string input = Console.ReadLine();

int space_count = 0;
foreach (char c in input)
{
    if (c == ' ')
    {
        space_count++;
    }
}

Console.WriteLine($"Кількість пробілів: {space_count}");