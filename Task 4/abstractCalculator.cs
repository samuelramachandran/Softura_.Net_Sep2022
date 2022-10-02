using System;
namespace ConsoleApp
{
    abstract class calc
    {
        public abstract void calculate(int n1, int n2);

    }

    class add : calc
    {
        public override void calculate(int n1, int n2)
        {
            Console.WriteLine(n1 + n2);
        }
    }

    class sub : calc
    {
        public override void calculate(int n1, int n2)
        {
            Console.WriteLine(n1 - n2);
        }
    }

    class mul : calc
    {
        public override void calculate(int n1, int n2)
        {
            Console.WriteLine(n1 * n2);
        }
    }


    class div : calc
    {
        public override void calculate(int n1, int n2)
        {
            Console.WriteLine(n1 / n2);
        }
    }


    public class abstractCalculator
    {
        public static void Main()
        {
            add add = new();
            add.calculate(2, 3);
            sub sub = new();
            sub.calculate(3,2);
            mul mul = new();
            mul.calculate(2, 3);
            div div = new();
            div.calculate(10,2);

        }
    }
}

