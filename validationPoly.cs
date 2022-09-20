using System;
namespace ConsoleApp
{
    public class validationPoly
    {

       
        public void validate(string eid, string pwd)
        {
            Console.WriteLine("Email and password validated");
        }

        public void validate(string mid, int pin)
        {
            Console.WriteLine("Member id and pin validated");
        }

        public void validate(double n1, double n2)
        {
            Console.WriteLine("Mobile number and pin validated");
        }

        public static void Main()
        {
            validationPoly obj = new validationPoly();
            obj.validate("info@sam.com", "!@#$%^");
            obj.validate("ABC-001",0987);
            obj.validate(9876543210, 0987);
        }
    }
}

