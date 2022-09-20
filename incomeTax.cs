using System;
namespace ConsoleApp
{
    class Vat
    {
        public void calculateTax(double n1)
        {
            Console.WriteLine("The Vat to pay Rs.{0}", n1 * 0.2);
        }
    }

    class Gst : Vat
    {
        public void calculateTax(double n1)
        {
            Console.WriteLine("GST to pay Rs.{0}", n1 * 0.12);
        }
    }
    internal class incomeTax:Gst
    {
        public static void Main()
        {
            Vat obj = new Vat();
            obj.calculateTax(1232.2);
            incomeTax obj1 = new incomeTax();
            obj1.calculateTax(324.34);

        }
    }
}

