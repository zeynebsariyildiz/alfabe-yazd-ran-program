﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alfabe_yazdıran_program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char i;
            for (i = 'a'; i <= 'z'; i++)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
