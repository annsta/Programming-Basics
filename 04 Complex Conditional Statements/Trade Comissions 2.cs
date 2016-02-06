﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trade_Comissions_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string town = Console.ReadLine().ToLower();
            double sales = double.Parse(Console.ReadLine());
            double commission = 0;

            int[] limits = new int[]                    {0, 500, 1000, 10000 };
            double[] commissionsSofia = new double[]    {0.05, 0.07, 0.08, 0.12 };
            double[] commissionsVarna = new double[]    {0.045, 0.075, 0.10, 0.13 };
            double[] commissionsPlovdiv = new double[]  {0.055, 0.08, 0.12, 0.145 };

            if (town == "sofia")
            {
                for (int i = 0; i < 4; i++)
                {
                    if (sales >= 0 && sales > limits[i])
                        commission = commissionsSofia[i];
                }
            }
            else if (town == "varna")
            {
                for (int i = 0; i < 4; i++)
                {
                    if (sales >= 0 && sales > limits[i])
                        commission = commissionsVarna[i];
                }
            }
            else if (town == "plovdiv")
            {
                for (int i = 0; i < 4; i++)
                {
                    if (sales >= 0 && sales > limits[i])
                        commission = commissionsPlovdiv[i];
                }
            }

            if (commission > 0)
                Console.WriteLine("{0:f2}", sales * commission);
            else
                Console.WriteLine("error");
        }
    }
}