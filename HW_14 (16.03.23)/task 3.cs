using System.Text;

void InitializeArray(int[] array, Func<int, int> generateValue)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = generateValue(i);
    }
}

Console.OutputEncoding = Encoding.UTF8;

int[] array = new int[20];
InitializeArray(array, (index) =>
{
    return index * 3;
});

Console.WriteLine("Масив зі значеннями від 0 та кроком збільшення в 3:");
for (int i = 0; i < array.Length; i++)
{
    Console.Write(array[i] + " ");
}
Console.WriteLine();