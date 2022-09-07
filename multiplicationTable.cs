using System;
namespace ConsoleApp
{
    public class multiplicationTable
    {
       public static void Main()
        {
            Console.WriteLine("Enter a number");
            int value = Convert.ToInt32(Console.ReadLine());

            for(int i = 1; i<=20; i++)
            {
                Console.WriteLine("{0} * {1} = {2}",value,i, value * i);
            }
        }
    }
}

