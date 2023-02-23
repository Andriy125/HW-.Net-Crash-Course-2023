using System.Text;
Console.OutputEncoding = Encoding.UTF8;


Console.WriteLine("Вас вітає конвертер валют з гривні у інші валюти.");
Console.Write("Введіть кількість гривень (UAH): ");
double original_currency = Convert.ToDouble(Console.ReadLine());

Console.Write("Виберіть валюту з доступних: USD, EUR, PLN: ");
string input_currency = Console.ReadLine();

if (input_currency == "USD") Convert_currency(original_currency, currency.USD, input_currency);
else if (input_currency == "EUR") Convert_currency(original_currency, currency.EUR, input_currency);
else if (input_currency == "PLN") Convert_currency(original_currency, currency.PLN, input_currency);
else Console.WriteLine("Невідома валюта");

void Convert_currency(double original_currency, currency selected_currency, string input_currency)
{
    double result = selected_currency switch
    {
        currency.USD => original_currency / 37.44,
        currency.EUR => original_currency / 40.57,
        currency.PLN => original_currency / 8.49
    };

    Console.WriteLine(("\n").PadRight(24, '-'));
    Console.WriteLine($"З {original_currency} гривень ви отримаєте: {double.Round(result, 2)} {input_currency}");
}

public enum currency
{
    USD,
    EUR,
    PLN
}