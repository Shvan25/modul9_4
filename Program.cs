using System;

class Programm
{
    public delegate int ShowDelegate(int x, int y);
    static void Main(string[] args)
    {
        ShowDelegate showDelegate = Min;
        showDelegate += Sum;
        showDelegate.Invoke(33, 20);
        Console.ReadKey();
    }
    static int Min(int x, int y)
    {
        Console.WriteLine(x - y);
        return x - y;
    }
    static int Sum(int x, int y)
    {
        Console.WriteLine(x + y);
        return x + y;
    }
}
