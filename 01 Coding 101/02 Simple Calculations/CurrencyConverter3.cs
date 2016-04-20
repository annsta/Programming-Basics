﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Currency_Converter_3
{
    class CurrencyConverter3
    {
        static void Main(string[] args)
        {
            decimal amount = decimal.Parse(Console.ReadLine());
            string CCY1 = Console.ReadLine();
            string CCY2 = Console.ReadLine();

            var FX = new Dictionary<string, decimal>()
            {
                { "BGN", 1m},
                { "USD", 1.79549m},
                { "EUR", 1.95583m},
                { "GBP", 2.53405m},
            };
            decimal result = Math.Round(FX[CCY1] / FX[CCY2] * amount, 2);
            Console.WriteLine("{0} {1}", result, CCY2);
       }
    }
}