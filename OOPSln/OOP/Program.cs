using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    abstract class Person
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public Person (string name)
        {
            this.name = name;
        }
        public abstract void ShowInfo();
    }
    class Student : Person
    {
        private int studentId;
        public Student(string name,int id):base(name)
        {
            studentId = id;
        }
        public override void ShowInfo()
        {
            Console.WriteLine("Student Name: " + Name);
            Console.WriteLine("Student ID: " + studentId);
        }
    }
    class Teacher : Person
    {
        private string subject;
        public Teacher(string name,string subject):base(name)
        {
            this.subject = subject;
        }
        public override void ShowInfo()
        {
            Console.WriteLine("Teacher Name: " + Name);
            Console.WriteLine("Subject: " + subject);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
