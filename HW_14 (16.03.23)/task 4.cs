using System.Text;

void InitializeArray(int[] array, Func<int> generateValue)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = generateValue();
    }
}
int Fibonacci(int index)
{
    if (index == 0) return 0;
    if (index == 1) return 1;
    return Fibonacci(index - 1) + Fibonacci(index - 2);
}


Console.OutputEncoding = Encoding.UTF8;

int[] fibonacciArray = new int[10];
int index = -1;
InitializeArray(fibonacciArray, delegate ()
{
    index++;
    return Fibonacci(index);
});

// Виведення масиву в консоль
Console.WriteLine("Масив з чисел Фібоначчі:");
for (int i = 0; i < fibonacciArray.Length; i++)
{
    Console.Write(fibonacciArray[i] + " ");
}

Console.WriteLine();