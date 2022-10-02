using System;
namespace ConsoleApp
{
    public class loopOnAge
    {
        public static void Main()
        {
            Console.WriteLine("Enter your Good Name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter your age");
            int age = Convert.ToInt32(Console.ReadLine());

            for(int i = 0; i< age; i++)
            {
                Console.WriteLine("Hello, {0}", name);
            }
        }
    }
}

