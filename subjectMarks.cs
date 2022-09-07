using System;
using System.Xml.Linq;

namespace ConsoleApp
{
    public class subjectMarks
    {
        public static void Main()
        { 


            string[,] marks = new string[5, 2] { { "Computer Science", "100" }, { "Physics", "89" }, { "Maths", "97" }, { "Chemistry", "88" }, { "English", "91" } };
            int total = 0;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                 Console.Write(marks[i, j] + "\t");
                }
                Console.WriteLine();
                total = total + Convert.ToInt32(marks[i, 1]);
                //Console.WriteLine(marks[i,1]); 
            }
            Console.WriteLine("Total Marks: "+total);
            Console.WriteLine("Percentage: " + total/5 +"%");
          
        }    
    }
}

