﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fizzbuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 2; i < 100; i++)
            {
                if(i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine($"{i}: FizzBuzz");
                }else if(i % 5 == 0)
                {
                    Console.WriteLine($"{i}: Buzz");
                }else if(i % 3 == 0)
                {
                    Console.WriteLine($"{i}: Fizz");
                }
            }
            Console.ReadKey();
        }
    }
}