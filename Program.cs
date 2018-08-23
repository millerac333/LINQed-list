using System;
using System.Collections.Generic;
using System.Linq;

namespace linq
{
    class Program
    {
        static void Main(string[] args)
        {
            // Find the words in the collection that start with the letter 'L'
            List<string> fruits = new List<string>() { "Lemon", "Apple", "Orange", "Lime", "Watermelon", "Loganberry" };

            IEnumerable<string> lFruits = from lFruity in fruits
                                          where lFruity.StartsWith("L")
                                          select lFruity;

            foreach (var item in lFruits)
            {

                Console.WriteLine(item);
            }

            // Which of the following numbers are multiples of 4 or 6
            List<int> numbers = new List<int>()
            {
                15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
            };

            List<int> fourSixMultiples = numbers.Where(x => x % 4 == 0 || x % 6 == 0).ToList();
            foreach (int number in fourSixMultiples)
            {

                Console.WriteLine(number);
            }
        }
    }
}
