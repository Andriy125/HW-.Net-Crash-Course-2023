using System.Text;

Console.OutputEncoding = Encoding.UTF8;

Console.Write("Введіть день тижня від 1 до 7: ");
string number_week = Console.ReadLine();

switch (number_week)
{
	case "1":
		Console.WriteLine("Понеділок");
		break;
    case "2":
        Console.WriteLine("Вівторок");
        break;
    case "3":
        Console.WriteLine("Середа");
        break;
    case "4":
        Console.WriteLine("Четвер");
        break;
    case "5":
        Console.WriteLine("П'ятниця");
        break;
    case "6":
        Console.WriteLine("Субота");
        break;
    case "7":
        Console.WriteLine("Неділя");
        break;


    default:
        Console.WriteLine("Було введено хибні дані, спробуйте ще раз");
        break;
}