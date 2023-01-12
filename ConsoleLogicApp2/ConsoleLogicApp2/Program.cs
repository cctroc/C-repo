using System;
using Log = System.Diagnostics.Debug;
using System.Reflection.Metadata.Ecma335;

namespace logics
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Logics, World!");

            /* Ctrl+C to terminate indefinite loop !!!  */

            /*
            int a = 3;
            int b = 5;
            if (a + b > 10)
                Console.WriteLine("The result is greater than 10");
            else
                Console.WriteLine("The result is not greater than 10");
            */

            /*
            int a = 2;
            int b = 3;
            int c = 4;
            if ((a + b + c > 10) && (a == b))
            {
                Console.WriteLine("The answer is greater than 10");
                Console.WriteLine("Or the first number is equal to the second");
            }
            else
            {
                Console.WriteLine("The answer is not greater than 10");
                Console.WriteLine("And the first number is not equal to the second");
            }
            */

            /*
            int counter = 0;
            while (counter < 3)
            {
                Console.WriteLine($"Hello World! The counter is {counter}");
                counter++;
            }
            */

            /*
            for (int counter = 0; counter < 5; counter++)
            {
                Console.WriteLine($"Hello World! The counter is {counter}");
            }
            */

            /*
            for (int row = 1; row < 5; row++)
            {
                for (char column = 'a'; column < 'c'; column++)
                {
                    Console.WriteLine($"The cell is ({row}, {column})");
                }
            }
            */

            //int sum = 0;
            //for (int number = 1; number < 21; number++)
            //{
            //    if (number % 3 == 0)
            //    {
            //        sum = sum + number;
            //    }
            //}
            //Console.WriteLine($"The sum is {sum}");
            //System.Diagnostics.Debug.WriteLine($"The sum is {sum}");

            /*
            if (8 < 5)

            {
                System.Diagnostics.Debug.WriteLine(" 5 is greater than 3");
            }
            else if (7 < 5)
            {
                System.Diagnostics.Debug.WriteLine(" 5 is greater than 3");
            }
            else 
            {
                System.Diagnostics.Debug.WriteLine(" esle is statement is hit");
            }
            */

            /*
            int x = 0;
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(x);

                //x = i;
                //x =+ i;
                x += i;
                //x = x + i;
            }
            System.Console.WriteLine(x);
            */

            /*
            int x = 0;
            do
            {
                System.Diagnostics.Debug.WriteLine(x.ToString());
                x++;
            } while (x < 6);
          

            int x2 = 4;
            do
            {
                System.Diagnostics.Debug.WriteLine(x2.ToString());
                --x2;
            } while (x2 > 0 );
            */

           
            for (int i = 0; i < 7; i++)
            {
               
                if (i == 5)
                {
                    continue;

                }
                Log.WriteLine(i);
            }


            
        }
    }
}