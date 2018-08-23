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
            //
            List<int> fourSixMultiples = numbers.Where(x => x % 4 == 0 || x % 6 == 0).ToList();
            foreach (int number in fourSixMultiples)
            {

                Console.WriteLine(number);
            }

            // Order these student names alphabetically, in descending order (Z to A)
            List<string> names = new List<string>()
            {
                "Heather", "James", "Xavier", "Michelle", "Brian", "Nina",
                "Kathleen", "Sophia", "Amir", "Douglas", "Zarley", "Beatrice",
                "Theodora", "William", "Svetlana", "Charisse", "Yolanda",
                "Gregorio", "Jean-Paul", "Evangelina", "Viktor", "Jacqueline",
                "Francisco", "Tre"
            };
            //sets variable reordered list from z to a
            List<string> descending = names.OrderByDescending(zToA => zToA).ToList();
            foreach (string item in descending)
            {
                Console.WriteLine(item);
            }

            // Build a collection of these numbers sorted in ascending order
            List<int> moreNumbers = new List<int>()
            {
                15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
            };
            List<int> ascending = moreNumbers.OrderBy(one2three => one2three).ToList();
            foreach (int number in ascending)
            {
                Console.WriteLine(number);
            }

            // Output how many numbers are in this list
            List<int> allNumbers = new List<int>()
            {
                15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
            };
            Console.WriteLine(allNumbers.Count());

            // How much money have we made?
            List<double> purchases = new List<double>()
            {
                2340.29, 745.31, 21.76, 34.03, 4786.45, 879.45, 9442.85, 2454.63, 45.65
            };
            //gives sum of numbers formatted to dollars 
            Console.WriteLine($"{purchases.Sum().ToString("C")}");

            // What is our most expensive product?
            List<double> prices = new List<double>()
            {
                879.45, 9442.85, 2454.63, 45.65, 2340.29, 34.03, 4786.45, 745.31, 21.76
            };
            //gives most expensive item formatted to dollars 
            Console.WriteLine($"{prices.Max().ToString("C")}");
        }
    }
}


