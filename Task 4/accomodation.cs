using System;
namespace ConsoleApp
{
    class silver:accomodate
    {
        public void resort()
        {
            Console.WriteLine("3 Days accomodation at resort");
        }
    }

    class gold:accomodate,dinner
    {
        public void resort()
        {
            Console.WriteLine("5 Days accomodation at resort");
        }
        public void house()
        {
            Console.WriteLine("2 dinners at house");
        }
    }


    class platinum : accomodate, dinner
    {
        public void resort()
        {
            Console.WriteLine("7 Days accomodation at resort");
        }
        public void house()
        {
            Console.WriteLine("5 dinners at house");
        }
    }

    public class accomodation
    {
       public static void Main()
        {
            silver silver = new();
            gold gold = new();
            platinum platinum = new();
            silver.resort();
            gold.resort();
            gold.house();
            platinum.resort();
            platinum.house();
        }
    }
}

