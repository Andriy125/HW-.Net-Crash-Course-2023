using System;
using System.Collections.Generic;
using System.Text;

class HanoiTower
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        int n = 4; // кількість дисків
        Stack<int> source = new Stack<int>();
        Stack<int> aux = new Stack<int>();
        Stack<int> dest = new Stack<int>();

        for (int i = n; i >= 1; i--)
        {
            source.Push(i);
        }

        SolveHanoiTower(n, source, aux, dest);

        Console.ReadLine();
    }

    static void SolveHanoiTower(int n, Stack<int> source, Stack<int> aux, Stack<int> dest)
    {
        if (n > 0)
        {
            SolveHanoiTower(n - 1, source, dest, aux);

            int disk = source.Pop();
            dest.Push(disk);
            Console.WriteLine("Перемістити диск " + disk + " з " + source.ToString() + " на " + dest.ToString());

            SolveHanoiTower(n - 1, aux, source, dest);
        }
    }
}
