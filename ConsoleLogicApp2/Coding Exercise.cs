using System;

namespace Coding.ForLoop 
{

    public class ForLoop
    {
        public static void AddNumber()
        {
            int x = 0;
            for (int i = 0; i < 100; i++)
            {
                x += i;
            }
            System.Diagnostics.Debug.Console.WriteLine(x);
        }
    }
}


