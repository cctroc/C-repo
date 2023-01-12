using System;

public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Sex { get; set; }
        public string Hobby { get; set; }

        public Person(string name, int age, string sex, string hobby)
        {
            Name = name;
            Age = age;
            Sex = sex;
            Hobby = hobby;
        }
        // Other properties, methods, events...
        
    }


class Program
    {
        static void Main()
        {
            Person person1 = new Person("Leopold", 6, "M", "Swimming");
            Console.WriteLine("person1 Name = {0} Age = {1} Sex= {2} ", 
                                person1.Name, person1.Age, person1.Sex);

            // Declare new person, assign person1 to it.
            Person person2 = person1;

            // Change the name of person2, and person1 also changes.
            person2.Name = "Molly";
            person2.Age = 16;
            person2.Hobby = "Tennis";

            Console.WriteLine("person2 Name = {0} Age = {1} Sex= {2}", 
                                person2.Name, person2.Age, person2.Sex);
            Console.WriteLine("person1 Name = {0} Age = {1}  Hobby= {2}", 
                                person1.Name, person1.Age, person1.Sex);

            
        }
    } 

/*
    Output:
    person1 Name = Leopold Age = 6
    person2 Name = Molly Age = 16
    person1 Name = Molly Age = 16
*/
