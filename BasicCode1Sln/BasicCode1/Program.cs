using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCode1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("My name is Md. Mahfuj Rahman");
            Console.ReadLine(); */

            //variable
            /*int age = 22;
            double cgpa = 3.20;
            string name = "Mahfuj";

            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("CGPA: " + cgpa); */

            //input

            /*Console.WriteLine("Enter Your Name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Enter Your Age: ");
            int age= Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Your UniName: ");
            string uniName= Console.ReadLine();
            Console.WriteLine("---------------------");

            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("UniName: " + uniName);
            */

            //Condition (if-else)

            Console.Write("Enter Your Marks: ");
            int marks = Convert.ToInt32(Console.ReadLine());

            if (marks >=90)
            {
                Console.WriteLine("Grade: A+");
            }
            else if (marks >=80)
            {
                Console.WriteLine("Grade: B+");
            }
            else if (marks<49)
            {
                Console.WriteLine("Grade: Fail");
            }

        }
    }
}
