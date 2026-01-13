using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BasicCode1
{
    // class and obejct

     /*class Student
    {
        public string Id;
        public string name;
        public  double  cgpa;

            public void Showinfo()
        {
            Console.WriteLine($"ID: "+Id+", Name: "+name+", CGPA: "+cgpa);
        }
    } */


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
            /*
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
            } */

            //Loop for
            /*  for (int i=1; i<=10;i++)
             {
                 Console.WriteLine(i);
             } */

            //while
            /*  int i = 1;
              while (i <= 5)
              {
                  Console.WriteLine(i);
                  i++;
              } */

            //Method

            /* int sum = Add(10, 20);
             Console.WriteLine("Sum: " + sum);
         }
            static int Add(int a ,int b)
             {
                 return a + b;
             } */

            // class and object

            /* Student s1 = new Student();
             s1.Id = "23-54475-3";
             s1.name = "Mahfuj Rahman";
             s1.cgpa = 3.20;
             s1.Showinfo();  */


            //Array and list

            /* int[] numbers = { 10, 20, 30, 40, 50 };
            for (int i=0;i<numbers.Length;i++)
            {
                Console.WriteLine(numbers[i]);
            } */


            /* List<string> names = new List<string>();
             names.Add("Mahfuj");
             names.Add(" Rahman");

             foreach(string name in names)
             {
                 Console.Write(name);
             }  */

            //Exception Handling

            try
            {
                Console.Write("Enter Number: ");
                int n = int.Parse(Console.ReadLine());
                Console.WriteLine("You entered: " + n);
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid Input");

            }
           finally
            {
                Console.WriteLine("Program Ended.");
            }






        }
    }
}
