﻿using System;

namespace DecimalNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal a = 12.345M;
            decimal b = 12;
            decimal c = a - b;
            Console.WriteLine(c);
        }
    }
}
