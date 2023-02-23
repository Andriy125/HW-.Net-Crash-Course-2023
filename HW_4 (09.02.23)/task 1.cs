using System.Text;
Console.OutputEncoding = Encoding.UTF8;


Console.WriteLine("Введіть рядок слів: ");
string input_text = Console.ReadLine();

string[] words = input_text.Split(' ');

Console.Write("Результат: ");
for (int i = words.Length - 1; i >= 0; i--)
{
    Console.Write("{0} ", words[i]);
}