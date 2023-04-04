using System.Text;

void InitializeArray(int[] array, Func<int, int> generateValue)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = generateValue(i);
    }
}

Console.OutputEncoding = Encoding.UTF8;

int[] powerOfTwoArray = new int[10];
InitializeArray(powerOfTwoArray, (index) =>
{
    return (int)Math.Pow(2, index + 1);
});

Console.WriteLine("Масив степенів двійки:");
for (int i = 0; i < powerOfTwoArray.Length; i++)
{
    Console.Write(powerOfTwoArray[i] + " ");
}

Console.WriteLine();