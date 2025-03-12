using System;

class Programm
{
    public delegate void ShowDelegate(int x, int y);
    static void Main(string[] args)
    {
        ShowDelegate showDelegate = Min;
        showDelegate += Sum;
        showDelegate.Invoke(33, 20);
        Console.ReadKey();
    }
    static void Min(int x, int y)
    {
        Console.WriteLine(x - y);
    }
    static void Sum(int x, int y)
    {
        Console.WriteLine(x + y);
    }
}
