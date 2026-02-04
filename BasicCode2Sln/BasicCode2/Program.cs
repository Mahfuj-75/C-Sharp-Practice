using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace BasicCode2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*var marks = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase);
           
                while (true)
            {
                Console.Write("Student name (or done)");
                string name = Console.ReadLine();
                if (name.Equals("done", StringComparison.OrdinalIgnoreCase)) break;

                Console.Write("Mark (0-100)");
                string s = Console.ReadLine();

                if(!int.TryParse(s,out int m) || m<0 || m>100)
                {
                    Console.WriteLine("invalid mark!");
                    continue;
                }
                marks[name] = m;
            }
            Console.WriteLine("\n---Result-----");
            foreach (var kv in marks)
                Console.WriteLine($"{kv.Key} -> {kv.Value}");
        }*/


            var numbers = new List<int>();

            Console.WriteLine("Enter integers (type 'done' to stop):");

            while (true)
            {
                Console.Write("> ");
                string s = Console.ReadLine();

                if (string.Equals(s, "done", StringComparison.OrdinalIgnoreCase))
                    break;

                if (int.TryParse(s, out int n))
                    numbers.Add(n);
                else
                    Console.WriteLine("Invalid input. Enter a valid integer.");
            }

            if (numbers.Count == 0)
            {
                Console.WriteLine("No numbers entered.");
                return;
            }

            int sum = 0, max = numbers[0], min = numbers[0];
            foreach (int x in numbers)
            {
                sum += x;
                if (x > max) max = x;
                if (x < min) min = x;
            }

            double avg = (double)sum / numbers.Count;

            Console.WriteLine($"\nCount: {numbers.Count}");
            Console.WriteLine($"Sum: {sum}");
            Console.WriteLine($"Average: {avg:F2}");
            Console.WriteLine($"Max: {max}");
            Console.WriteLine($"Min: {min}");

        }
        }
}
