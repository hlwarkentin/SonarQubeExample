using System;
using System.Xml.Serialization;

namespace SonarApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Please analyze my code");
            string newName = "This is your name: Hank";
            if (newName == GetName("Hank"))
            {
                Console.WriteLine("This is real code, SonarQube!");
            }
        }

        public static string GetName(string name)
        {
            return $"This is your name: {name}";
        }
    }
}
