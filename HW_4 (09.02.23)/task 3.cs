using System.Text;
Console.OutputEncoding = Encoding.UTF8;

Console.WriteLine("Введіть текст: ");
string input_text = Console.ReadLine();

int total_chars = input_text.Length;
int upper_case_count = 0;
int lower_case_count = 0;

foreach (char c in input_text)
{
    if (Char.IsUpper(c))
    {
        upper_case_count++;
    }
    else if (Char.IsLower(c))
    {
        lower_case_count++;
    }
}

double upper_case_percentage = (double)upper_case_count / total_chars * 100;
double lower_case_percentage = (double)lower_case_count / total_chars * 100;

Console.WriteLine($"Кількість великих літер: {upper_case_count}, що становить {upper_case_percentage}% від загальної кількості символів.");
Console.WriteLine($"Кількість малих літер: {lower_case_count}, що становить {lower_case_percentage}% від загальної кількості символів.");
