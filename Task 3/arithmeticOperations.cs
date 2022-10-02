using System;
namespace ConsoleApp
{
    class addSub
    {
        public void add(int n1, int n2)
        {
            Console.WriteLine("The sum of {0} and {1} is {2}", n1, n2, n1 + n2);
        }

        public void sub(int n1, int n2)
        {
            Console.WriteLine("The difference of {0} and {1} is {2}", n1, n2, n1 - n2);
        }
    }

    class mulDiv:addSub
    {
        public void multiply(int n1,int n2)
        {
            Console.WriteLine("The multiplication of {0} and {1} is {2}",n1,n2,n1*n2);
        }

        public void div(int n1, int n2)
        {
            Console.WriteLine("The division of {0} and {1} is {2}", n1, n2, n1 / n2);
        }
    }
    public class arithmeticOperations
    {

        public static void Main()
        {
            mulDiv obj = new mulDiv();
            obj.add(4,9);
            obj.multiply(5, 5);
            obj.sub(4, 2);
            obj.div(10, 2);
        }

    }
}

