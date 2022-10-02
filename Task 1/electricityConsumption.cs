using System;
namespace ConsoleApp
{
    public class electricityConsumption
    {
        public static void Main()
        {
            int slab1 = 2;
            int slab2 = 3;
            int slab3 = 5;
            int slab4 = 7;

            Console.WriteLine("Enter consumed units");
            int units = Convert.ToInt32(Console.ReadLine());

            if(units <= 200)
            {
                int amt = units * slab1;
                Console.WriteLine("Charges "+amt);
            }
            else if(units > 201 && units <= 350)
            {
                int tmpamt = 200 * slab1;
                int balUnit = units - 200;
                int amt3 = tmpamt + (balUnit * slab2);
                Console.WriteLine("Charges "+amt3);
             }
            else if (units > 351 && units <= 500)
            {
                int tmpp = 200 * slab1; 
                int tmpamt2 = 150 * slab2;
                int balUnit2 = units - 350;
                int amt2 = tmpp + tmpamt2 + (balUnit2 * slab3);
                Console.WriteLine("Charges " + amt2);
            }

        }
    }
}

