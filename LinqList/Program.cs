using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> fruits = new List<string>() { "Lemon", "Apple", "Orange", "Lime", "Watermelon", "Loganberry" };

            var lwords = fruits.Where(fruit => fruit.StartsWith("L"));

            foreach (var letter in lwords)
            {
                Console.WriteLine(letter);
            }

            List<int> numbers = new List<int>()
            {
                15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
            };

            var fourSixMultiples = numbers.Where(number => number % 4 == 0 || number % 6 == 0);

            foreach (var multiple in fourSixMultiples)
            {
                Console.WriteLine(multiple);
            }

            Console.Read();
        }
    }
}
