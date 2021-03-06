﻿using System;
using System.Collections.Generic;

namespace LarrysComicApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Larry's amazing comic book filer app! *****");
            // 1. Generate mock list to work with.
            List<int> testList = new List<int> { 1, 2, 4, 5, 6, 9, 10, 11, 12, 15, 49, 50, 100, 111, 112 };
            firstWay(testList);
        }

        static void firstWay(List<int> l)
        {
            // 1. Write opening parenthesis
            Console.Write("{");
            // 2. Cycle through the elements in list, comparing each element in place i to it's immediately preceding and following elements to check for consecutiveness.
            for (int i = 0; i < l.Count; i++)
            {
                // 2.1 Print the last number regardless (including it in the logic immediately below throws an Argument out of range exception.)
                if (i == l.Count - 1)
                    Console.Write($"{l[i]}");

                // 2.2 If i is a last element in a sequence of consecutive numbers (that's not last in the list), print it followed by a comma.
                else if (l[i + 1] - l[i] > 1)
                    Console.Write($"{l[i]}, ");

                // 2.3 if i is a first element (that's not also a last element, since that's covered by the previous case), print it followed by a dash.
                else if (i == 0 || l[i] - l[i - 1] > 1)
                    Console.Write($"{l[i]}-");
            }
            // 3. Write closing parenthesis.
            Console.Write("}");
        }

        static void secondWay(List<int> l)
        {
            // Way 2: 
            // From set of numbers, obtain a set of sets of consecutive numbers.
            // print {
            // for each set s in setOfsets
            // if it has only one member, print that member,
            // if it has more than one member, print firstMember-lastMember
            // if member isn't the last, print a comma
            // print }
        }
    }
}
