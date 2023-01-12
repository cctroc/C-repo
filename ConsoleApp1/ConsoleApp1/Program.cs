using System;

class Hello
{
    static void Main()
    {
        // This line prints "Hello How are you ?" 
        Console.WriteLine("Hello How are you ?");
        int a = 16;
        int b = 3;
        Console.WriteLine(a / b);
        float c = 2;
        float d = 3;
        Console.WriteLine(c / d);
        Console.WriteLine(a % b);

        /*
        int max= int.MaxValue;
        int min= int.MinValue;
        Console.WriteLine($"The range of integer is {min} to {max}");
       
        double max = double.MaxValue;
        double min = double.MinValue;
        Console.WriteLine($"The range of integer is {min} to {max}");
        */

        decimal max = decimal.MaxValue;
        decimal min = decimal.MinValue;
        Console.WriteLine($"The range of integer is {min} to {max}");

        decimal w = 45.0M;
        Console.WriteLine(w / 2);

        double test = 1.0 / 3.0;
        Console.WriteLine(test);

        double e = 12;
        double f = 13;
        Console.WriteLine(e / f);   
        



    }
}