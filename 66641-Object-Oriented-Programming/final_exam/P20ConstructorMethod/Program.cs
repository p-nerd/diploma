using System;

namespace P20ConstructorMethod
{
    class User
    {
        public string Name;
        public int Age;

        public User(string name, int age)
        {
            Name = name;
            Age = age;
        }

        static void Main(string[] args)
        {
            User u = new User("Shihab", 20);
            Console.WriteLine("Name: " + u.Name);
            Console.WriteLine("Age: " + u.Age);
            Console.ReadKey();
        }
    }

}