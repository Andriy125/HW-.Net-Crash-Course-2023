int[] array = new int[20];

Random rnd = new Random();
for (int i = 0; i < array.Length; i++)
{
    array[i] = rnd.Next(0, 100);
}

foreach(int i in array)
{
    Console.Write(i + " ");
}