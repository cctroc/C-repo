using System.Linq.Expressions;

namespace ConsoleLogicSwitchApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");


            /*
            int value = 11;
            switch(value)
            {
                case 1:
                    Console.WriteLine("1");
                    break;
                case 2:
                    Console.WriteLine("2");
                    break;
                case 3:
                    Console.WriteLine("3");
                    break;
                case 4:
                    Console.WriteLine("4");
                    break;
                case 5:
                    Console.WriteLine("5");
                    break;
                case 6:
                    Console.WriteLine("6");
                    break;
                case 7:
                    Console.WriteLine("7");
                    break;
                case 8:
                    Console.WriteLine("8");
                    break;
                case 9:
                    Console.WriteLine("9");
                    break;
                case 10:
                    Console.WriteLine("10");
                    break;
                default:
                    Console.WriteLine("Others");
                    break;

            }
            */
            int day = 3;   // accept int value only not string

            switch (day)
            {   case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuseday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thurdat");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                default:
                    Console.WriteLine("Sunday");
                    break;
            }




        }
    }
}