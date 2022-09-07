using System;
namespace ConsoleApp
{
    public class channelPackages
    {
        public static void Main()
        {
            Console.WriteLine("Choose a package");

            //Console.WriteLine("Package A \n ****** 1.South Special \n 2. Children's Club \n 3.Movies");
            string[] packageA = { "Package A", "**********" ,"South Special", "Children's Club", "Movies","________"};
            foreach (string pA in packageA)
                Console.WriteLine(pA);

            string[] packageB = { "Package B", "**********", "News", "Sports", "Movies", "Reginal-2", "________" };
            foreach (string pB in packageB)
                Console.WriteLine(pB);

            string[] packageC = { "Package C", "**********", "Discovery", "History", "National", "________" };
            foreach (string pC in packageC)
                Console.WriteLine(pC);


            Console.WriteLine("Type A/B/C to select and view the price");
            string selectedPack = Console.ReadLine();

            switch(selectedPack)
            {
                case "A": Console.WriteLine("Pricing for Package A is ₹250");break;
                case "B": Console.WriteLine("Pricing for Package B is ₹450"); break;
                case "C": Console.WriteLine("Pricing for Package C is ₹350"); break;
                default: Console.WriteLine("Enter a Valid Package, Thanks");break;
            }

        }
    }
}

