using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS
{
    abstract class LibraryItem
    {
        public string Title { get; set; }
        public int Id { get; set; }

        public LibraryItem(string title, int id)
        {
            Title = title;
            Id = id;
        }

        public abstract void Display();
    }
    class Book : LibraryItem
    {
        public string Author { get;set }
        public Book(string title, int id, string author) : base(title, id)
        {
            Author = author;
        }
        public overrride void Display()
        {
            Console.WriteLine("Book ID: " + Id);
            Console.WriteLine("Title: " + Title);
            Console.WriteLine("Author: " + Author);
        }
    }
    class Magazine : LibraryItem
    {
        public int IssueNumber { get; set; }

        public Magazine(string title, int id, int issue) : base(title, id)
        {
            IssueNumber = issue;
        }
        public override void Display()
        {
            Console.WriteLine("magazine ID: " + Id);
            Console.WriteLine("Title: " + Title);
            Console.WriteLine("Issue No: " + IssueNumber);
        }
    }
    class Library
    {
        private List<LibraryItem> items = new List<LibraryItem>();

        public void AddItem(LibraryItem item)
        {
            items.Add(item);
            Console.WriteLine("Item added Successfully");

        }
        public void ShowAllItems()
        {
            foreach (var item in items)
            {
                Console.WriteLine("----------------");
                item.Display();
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
