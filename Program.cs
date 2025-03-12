using System;

class Programm
{
    public delegate int MinDelegate(int x, int y);
    static void Main(string[] args)
    {
        MinDelegate minDelegate = Min;
        Console.WriteLine(minDelegate.Invoke(33, 20));
        Console.ReadKey();
    }
    static int Min(int x, int y)
    {
        return x - y;
    }
}
