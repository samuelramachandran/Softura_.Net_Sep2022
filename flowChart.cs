using System;
namespace ConsoleApp
{
    public class flowChart
    {
        public static void Main()
        {
            Console.WriteLine("Do you have travel history");
            string ans = Console.ReadLine();
            if(ans == "Yes" && ans == "yes")
            {
                Console.WriteLine("Do you have temperature");
                string tempAns = Console.ReadLine();
                if(tempAns == "Yes" && tempAns == "yes")
                {
                    Console.WriteLine("Do you have cough / sneeze");
                    string symptom = Console.ReadLine();
                    if(symptom == "Yes" && symptom == "yes")
                    {
                        Console.WriteLine("Do SWAP Test");
                    }
                    else
                    {
                        Console.WriteLine("Quarantive, fever medicine");
                    }
                }
                else
                {
                    Console.WriteLine("Home quaratine for 28 days");
                }
            }else
            {
                Console.WriteLine("Safe No Covid");
            }
        }
    }
}

