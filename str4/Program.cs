﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace str4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 10;

            for(int i = 1; i <= n; i++)
            {
                for(int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine(" ");
            }
        }
    }
}
