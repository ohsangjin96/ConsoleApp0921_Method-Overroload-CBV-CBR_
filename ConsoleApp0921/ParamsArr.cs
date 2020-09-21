﻿using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0921
{
    
    class ParamsArr
    {
        static int SumParams(params int[] arr)
        {
            int tot = 0;
            foreach (int num in arr)
            {
                tot += num;
            }
            return tot;
        }
        static int Sum(int[] arr)
        {
            int tot = 0;
            foreach(int num in arr)
            {
                tot += num;
            }
            return tot;
        }
        static int Sum(int a, int b)
        {
            return a + b;
        }
        static int Sum(int a, int b,int c, int d)
        {
            return a + b + c + d;

        }
        static void Main()
        {
            Sum(3, 5);
            int[] arr = new int[5] { 1, 2, 3, 4, 5 };
            Console.WriteLine(Sum(arr));

            Console.WriteLine(Sum(new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }));
        }
    }
}
