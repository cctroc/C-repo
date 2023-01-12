using System.Security.Cryptography.X509Certificates;

namespace ConsoleFunctionApp2
{
    public class Program
    {

        public int exampleNumber;
        //private int _num = default!; // Null-forgiving operator !

        public string exampleName;
        //private string _name = null!;


        public Program (int num) { 
            exampleNumber = num;
        }

        public Program(int num, string name)
        {
            exampleNumber = num;
            exampleName = name;
        }

        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");


            Program ex = new Program(8);
            Program ex2 = new Program(12, "alex");

            ex2.exampleNumber = 456;
            ex2.exampleName = "Jasson";

            System.Diagnostics.Debug.WriteLine(ex.exampleNumber);
            System.Diagnostics.Debug.WriteLine(ex2.exampleNumber, ex2.exampleName);
            
        }
    }
}