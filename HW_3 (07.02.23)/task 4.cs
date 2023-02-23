using System.Text;


Console.OutputEncoding = Encoding.UTF8;


Console.WriteLine("Виберіть дію:\n" +
    "1 - Обрахувати суму чисел в масиві\n" +
    "2 - Відсортувати масив\n" +
    "3 - Знайти кількість парних значеннь\n" +
    "4 - Знайти максимальний елемент\n");

Console.Write("Ваш вибір: ");
int Operation = Convert.ToInt32(Console.ReadLine());

int[] array = new int[20];
Random rnd = new Random();
for (int i = 0; i < array.Length; i++) array[i] = rnd.Next(0, 100);

Console.WriteLine("Створений масив: ");
foreach (int i in array) Console.Write(i + " ");

Console.WriteLine(("\n\n").PadRight(60, '-'));


switch (Operation)
{
    case 1:
        int sum_array = 0;
        foreach (int i in array) sum_array += i;
        Console.WriteLine($"Сума чисел в масиві становить: {sum_array}");
        break;
    
    case 2:
        Array.Sort(array);
        Console.WriteLine("Відсортований масив");
        foreach (int i in array) Console.Write(i + " ");
        break;
    
    case 3:
        int parity_counter = 0;
        foreach (int i in array) if (i % 2 == 0) parity_counter++;
        Console.WriteLine($"Кількість парних чисел: {parity_counter}");
        break;
    
    case 4:
        int nubmer_before = int.MinValue;
        foreach (int i in array) if (nubmer_before < i) nubmer_before = i;
        Console.WriteLine($"Максимальний елемент масиву: {nubmer_before}");
        break;


    default:
        Console.WriteLine("Невідома дія");
        break;
}