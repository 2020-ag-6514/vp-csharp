﻿using System;
using System.Collections.Generic;

namespace SideEffects
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int> { 1, 2};
            var smallests = GetSmallests(numbers, 3);

            foreach (var number in smallests)
            {
                Console.WriteLine(number);
            }
        }

        public static List<int> GetSmallests(List<int> list, int count)
        {
            var smallests = new List<int>();

            while (smallests.Count < count)
            {
                var min = GetSmallest(list);
                smallests.Add(min);
                list.Remove(min);
            }

            return smallests;
        }

        public static int GetSmallest(List<int> list)
        {
            //Assume that first number is minimum.

            var min = list[0];
            for (var i = 1; i < list.Count; i++)
            {
                if (list[i] > min)
                {
                    min = list[i];
                }
            }
            return min;

        }
    }
}