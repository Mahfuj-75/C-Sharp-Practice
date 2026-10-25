using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class Pizza
    {
        public string Size;
        public string Topping;

        public void Show()
        {
            Console.WriteLine(Size + " Pizza with " + Topping);
            //Console.WriteLine(Size +" add onions " + Topping) 

        }
    }

    class PizzaBuilder
    {
        private Pizza pizza = new Pizza();

        public PizzaBuilder SetSize(string size)
        {
            pizza.Size = size;
            return this;
        }
        public PizzaBuilder SetTopping(string topping)
        {
            pizza.Topping = topping;
            return this;
        }
        public Pizza Build()
        {
            return pizza;
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Pizza p = new PizzaBuilder()
            .SetSize("Large")
            .SetTopping("Chese")
            .Build();

            p.Show(); //large pizza with chese
        }
    }
}
