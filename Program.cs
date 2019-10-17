using System;
using System.Collections.Generic;

namespace LarrysComicApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Larry's amazing comic book filer app! *****");
            // 1. Generate mock list to work with.
            List<int> testList = new List<int> { 1, 4, 5, 6, 9, 10, 11, 12, 49, 50, 100, 111, 112 };
            firstWay(testList);

            // 4. Check if the values are equal, and increment lastValue if so
            // 4.1 If lastValue - firstValue >= 2, print firstValue + ", "
            // 4.2 Set firstValue equal to last value
            // 1.all elements are consecutive, and;
            // if 

            // 4.1 if they are, set 
            // 4.2 if they aren't.

        }
        static void firstWay(List<int> l)
        {
            // 1. Write opening parenthesis
            Console.Write("{");
            // 2. Cycle through the elements in list.
            for (int i = 0; i < l.Count; i++)
            {
                // If it's both a first and a last element, print it followed by a comma
                try
                {
                    if (l[i] - l[i - 1] > 1 && l[i+1] - l[i] > 1)
                    {
                        Console.Write($"{l[i]}, ");
                    }
                    else if (l[i] - l[i - 1] > 1)
                    {
                        Console.Write($"{l[i]}-");
                    }
                    else if (l[i + 1] - l[i] > 1)
                    {
                        Console.Write($"{l[i]}, ");
                    }
                }
                catch (ArgumentOutOfRangeException)
                {
                    Console.Write($"{l[i]}");
                    if (i != l.Count - 1)
                        Console.Write(", ");
                }
                // If it's a first element, print it followed by -.
                // If it's a last element, print it.
                // If it's not the last in the list, print a comma.
                //if (i != l.Count - 1)
                //{
                //    Console.Write($",");
                //}
                // 4.1 Check if the first number and the current number are consecutive
                // 4.2 if so, print the first number
                // Check if difference betwe


            }
            Console.Write("}");
            // 5. Write closing parenthesis.
        }
        //bool isFirstInConsecutive(int myInt)
        //{

        //    return 
        //}

        static void secondWay(List<int> l)
        {

        }
        static void thirdWay(List<int> l)
        {

        }
    }
}
// Three ways to do this.
// Way 1: 
// Create a variable generator that
// 1.1. stores all the maximal subsets in variables,
// 1.2. Gets the leftover numbers, then 
// Print the numbers in order
// 1.3 if listOfInts[0] > leftOver, print $"{listOfInts[0]}-{listOfInts[last]}, {leftOver}"
// 1.4 else print $"{leftOver}, {listOfInts[0]
// 1.5. Move to 

// Way 2: 
// If they're equal, move the last element.
// If they're consecutive, print the first element

// Way 3: 
// From set of numbers, obtain a set of sets of consecutive numbers.
// print {
// for each set s in setOfsets
// if it has only one member, print that member,
// if it has more than one member, print firstMember-lastMember
// if member isn't the last, print a comma
// else print }

// four cases: first and last -> print followed by comma, first only print followed by -, last only -> print followed by comma, neither.