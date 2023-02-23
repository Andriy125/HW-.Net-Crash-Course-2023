using System.Text;
Console.OutputEncoding = Encoding.UTF8;

Console.WriteLine("Введіть текст: ");
string input_text = Console.ReadLine();

string[] words = input_text.Split(' ');
string acronym = "";

foreach (string word in words)
{
     acronym += word[0].ToString().ToUpper();
}

Console.WriteLine(acronym);