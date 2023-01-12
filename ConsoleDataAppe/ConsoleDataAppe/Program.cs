using System;

internal class Program
{
    private static void Main(string[] args)
    {
        // Console.WriteLine("Hello, World!");

        //Type sTyper = typeof(string);
        //System.Diagnostics.Debug.WriteLine(sTyper);

        // Numerical values
        //int i = 0;
        //i = 5;
        //System.Diagnostics.Debug.WriteLine(++i);
        //System.Diagnostics.Debug.WriteLine(5.5f + 1.0f);
        //System.Diagnostics.Debug.WriteLine((int)5.5f);

        // Math operation
        //System.Diagnostics.Debug.WriteLine(Math.Abs(-3.8f));
        //System.Diagnostics.Debug.WriteLine(Math.Round(-3.8f));
        //System.Diagnostics.Debug.WriteLine(Math.Ceiling(-3.8f));
        //System.Diagnostics.Debug.WriteLine(Math.Floor(-3.8f));
        //System.Diagnostics.Debug.WriteLine(Math.Min(1,3));

        // string values
        //string S1 = "Hi ";
        //string S2 = "How are you !";
        //string S3 = S1 + S2;
        //S3 += "!!!";
        //System.Diagnostics.Debug.WriteLine(S3);

        /*
        string S1 = "abc";
        string S2 = "abc";
        S1= S1.Insert(3, "d");
        System.Diagnostics.Debug.WriteLine(S1);
        System.Diagnostics.Debug.WriteLine(S2);
        System.Diagnostics.Debug.WriteLine(S1.IndexOf("c"));
        System.Diagnostics.Debug.WriteLine(S1 == S2);
        System.Diagnostics.Debug.WriteLine(string.Equals(S1, S2));
        S1= S1.Trim('d');
        System.Diagnostics.Debug.WriteLine(S1 == S2);
        System.Diagnostics.Debug.WriteLine(string.Equals(S1, S2));

        */


        // verbatim identifier: @ and $ signs
        //System.Diagnostics.Debug.WriteLine("a\nc");
        //System.Diagnostics.Debug.WriteLine(@"a\nc");

        //string name = "Robin";
        //Console.WriteLine($"What is your {name}!");

        // slicing substring
        //string example = "abc";
        //System.Diagnostics.Debug.WriteLine(example.Contains("bc"));
        //System.Diagnostics.Debug.WriteLine(example.Substring(0,2));

        /* string escape sequence  \",  \\,   \O :unicode character O, \a :alert sound,
         * \r :carriage return, \t : tab escape sequence, \n : new line
         */

        //System.Diagnostics.Debug.WriteLine("Robin say going to \"Paris\"");
        //System.Diagnostics.Debug.WriteLine("a\\b");
        //System.Diagnostics.Debug.WriteLine("a\b");
        //Console.WriteLine("\a");
        //System.Diagnostics.Debug.WriteLine("Hello \r world");
        //System.Diagnostics.Debug.WriteLine("Hello \t world");
        //System.Diagnostics.Debug.WriteLine("Hello \t\t\t world");

        // format string
        /*
        int price1 = 100;
        int price2 = 200;
        System.Diagnostics.Debug.WriteLine(string.Format("The cost of item is: {0:C}", price1));

        System.Diagnostics.Debug.WriteLine("The cost of item1is: {0:C}" + "The cost of item2 is: {1:C}", 
                                            price1, price2);
        

        float percent1 = 0.45f;
        float percent2 = 0.65f;
        System.Diagnostics.Debug.WriteLine(string.Format("The first score is: {0:P} completed." +
                                            "The second score is: {1:P} completed", percent1, percent2));
        */

        //StringBuilder stringBuilder= new StringBuilder();
        //stringBuilder.Append("Hellow world  ");

        /*
        for (int i= 0; i < 4; i++)
        {
            stringBuilder.Append("buliding code!!");

        }
        string s= stringBuilder.ToString();
        System.Diagnostics.Debug.WriteLine(s);
        */

        /* to clear content in stringBuilder
         * stringBuilder.Clear();
         * string s = stringBuilder.ToString();
         * System.Diagnostics.Debug.WriteLine(s);
        */

        /*
        StringBuilder sb1= new StringBuilder("Hello world");
        System.Diagnostics.Debug.WriteLine(sb1.ToString());
        sb1.Replace("world", "guy");
        System.Diagnostics.Debug.WriteLine(sb1.ToString());
        sb1.Remove(6, 3);
        System.Diagnostics.Debug.WriteLine(sb1.ToString());

        

        StringBuilder sb2= new StringBuilder();
        sb2.AppendLine("Hello friend");
        sb2.AppendLine("Hello friend");
        sb2.Replace(" ","_");
        System.Diagnostics.Debug.WriteLine(sb2.Length.ToString());
        System.Diagnostics.Debug.WriteLine(sb2.ToString());
        
        */

        /*
        string s = "It is awesome!";
        string[] sArray = s.Split(',');
        System.Diagnostics.Debug.WriteLine(string.IsNullOrEmpty(s));
        System.Diagnostics.Debug.WriteLine(sArray.ToString());
        */

        /*
        bool complete = false;
        System.Diagnostics.Debug.WriteLine(!complete);
        System.Diagnostics.Debug.WriteLine(true || true);
        System.Diagnostics.Debug.WriteLine(false || true);
        System.Diagnostics.Debug.WriteLine(true && true);
        System.Diagnostics.Debug.WriteLine(false && true);

        bool example= true;
        example &= true;
        System.Diagnostics.Debug.WriteLine(example);
        */

        /*
        bool flag=false;

        List<int> intList= new List<int>() { 1, 2, 3 };
        foreach (var item in intList)
        {
            if (item == 3)
            {
                flag = true;
            }
            System.Diagnostics.Debug.WriteLine(item);
        }

        if (flag)
        {
            System.Diagnostics.Debug.WriteLine("3 was found");
        }
        */

        // value types
        /*
        int i = 200;
        System.Diagnostics.Debug.WriteLine(i);
        ChangeValue(i);
        System.Diagnostics.Debug.WriteLine(i);


        static void ChangeValue(int num)
        {
            num = 500;
            System.Diagnostics.Debug.WriteLine(num);
        }
        */



        // reference type
        Person p = new Person();
        p.Name = "old person";
        System.Diagnostics.Debug.WriteLine(p.Name);
        ChangeReferenceType(p);
        System.Diagnostics.Debug.WriteLine(p.Name);

    }

    // reference type 
        public class Person
        {
            public string Name { get; set; }
        }
        static void ChangeReferenceType(Person person)
        {
            person.Name = "new name";
            System.Diagnostics.Debug.WriteLine(person.Name);
        }




}