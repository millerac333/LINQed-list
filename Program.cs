﻿using System;
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
        }
    }
}