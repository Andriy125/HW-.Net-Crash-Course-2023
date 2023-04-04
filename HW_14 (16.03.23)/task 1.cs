void InitializeArray(int[] array, Func<int> generateValue)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = generateValue();
    }
}


int[] randomArray = new int[15];
InitializeArray(randomArray, delegate ()
{
    Random rnd = new Random();
    return rnd.Next(1, 101);
});

Console.WriteLine("Масив з випадкових чисел:");
for (int i = 0; i < randomArray.Length; i++)
{
    Console.Write(randomArray[i] + " ");
}

Console.WriteLine();