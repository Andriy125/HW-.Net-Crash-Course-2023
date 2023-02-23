using System.Text;
Console.OutputEncoding = Encoding.UTF8;


string input_text, result = "";

do
{
    Console.Write("Введіть слово: ");
    input_text = Console.ReadLine();

    if (input_text.EndsWith("."))
    {
        input_text = input_text.TrimEnd('.');
        result += input_text + ",";
        break;
    }
    else
    {
        result += input_text + ", ";
    }
}
while (true);

Console.WriteLine(result.TrimEnd(' '));