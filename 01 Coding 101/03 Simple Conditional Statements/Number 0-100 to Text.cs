﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_0_100_to_Text
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            string[] shortName = new string[]       { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve" };
            string[] compositeName = new string[]   { "twen", "thir", "four", "fif", "six", "seven", "eigh", "nine" };
            string name = "";

            if ((number < 0) || (number > 100))
                name = "invalid number";
            else if (number < 13)
                name = shortName[number]; //[0,12]
            else if (number < 20)
                name = compositeName[number % 10 - 2] + "teen"; // [13,19]
            else if (number < 100)
            {
                name = compositeName[number / 10 - 2] + "ty"; //20,30,...90
                if (number % 10 != 0)
                    name += " " + shortName[number % 10]; //21,22,23,...98,99
            }
            else //100
                name = "one hundred";

            Console.WriteLine(name);
        }
    }
}