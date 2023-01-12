using System.Diagnostics;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        bool b = "Hello" is int;
        System.Diagnostics.Debug.WriteLine(b);
    }
}