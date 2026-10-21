using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    interface IAnimal
    {
        void Speak();
    }

    class Dog : IAnimal
    {
        public void Speak()
        { Console.WriteLine("Wolf"); }

        class Cat : IAnimal
        {
            public void Speak()
            {
                Console.WriteLine("Meow");
            }

            class AnimalFactory
            {
                public static IAnimal Create(string type)
                {
                    if (type == "dog") return new Dog();
                    if (type == "cat") return new Cat();
                    return null;
                }
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
