using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace ConsoleObjectApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            /*
            var names = new List<string> { "Cctroc", "Ana", "Felipe" };

            names.Add("Susan");
            names.Add("Jasson");
            names.Remove("Cctroc");


            foreach (var name in names)
            {
                Console.WriteLine($"Hello {name.ToUpper()}!");

            }
            */

            /*
            WorkWithString();

            void WorkWithString()
            {
                var names = new List<string> { "cctroc", "Ana", "Felipe" };
                var previous= names[names.Count-2];

                Console.WriteLine(previous);

                var index = names.IndexOf("Felipe");
                if (index == -1)
                {
                    Console.WriteLine($"When an item is not found, IndexOf returns {index}");
                }
                else
                {
                    Console.WriteLine($"The name {names[index]} is at index {index}");
                }

                index = names.IndexOf("Not Found");
                if (index == -1)
                {
                    Console.WriteLine($"When an item is not found, IndexOf returns {index}");
                }
                else
                {
                    Console.WriteLine($"The name {names[index]} is at index {index}");

                }

                names.Sort();
                foreach (var name in names)
                {
                    Console.WriteLine($"Hello {name.ToUpper()}!");
                }
            }
            */

            var fibonacciNum= new List<int> {1,1};

            int sum = 0;

            while (fibonacciNum.Count < 8) 
            {
                var previous = fibonacciNum[fibonacciNum.Count - 1];
                var previous2 = fibonacciNum[fibonacciNum.Count - 2];

                fibonacciNum.Add(previous + previous2);
            }

            //comments block of code: ctrl+K+C and ctrl+K+U
            //CompilerMarshalOverride code line up and down: Alt+Up and Alt+ Down

            foreach (var item in fibonacciNum)
                Console.WriteLine(item);

            for (int i = 0; i < fibonacciNum.Count; i++)
            {
                sum += fibonacciNum[i];
            }

            Console.WriteLine($"The sum of fibonaccinumer is: {sum}");
        }

    }
}

