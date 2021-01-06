﻿using System;
using System.Collections.Generic;

namespace TypeList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("".PadRight(83, '-'));
            Console.WriteLine("{0,-10}{1,20}{2,18}{3,35}", "Type", "Byte(s) of memory", "Min", "Max");
            Console.WriteLine("".PadRight(83, '-'));
    	    Console.WriteLine("{0,-10}{1,3}{2,35}{3,35}", "sbyte", sizeof(sbyte), sbyte.MinValue, sbyte.MaxValue);
            Console.WriteLine("{0,-10}{1,3}{2,35}{3,35}", "byte", sizeof (byte),  byte.MinValue,  byte.MaxValue);
            Console.WriteLine("{0,-10}{1,3}{2,35}{3,35}", "short", sizeof(short), short.MinValue, short.MaxValue);
            Console.WriteLine("{0,-10}{1,3}{2,35}{3,35}", "ushort", sizeof(ushort), ushort.MinValue, ushort.MaxValue);
            Console.WriteLine("{0,-10}{1,3}{2,35}{3,35}", "int", sizeof(int), int.MinValue, int.MaxValue);
            Console.WriteLine("{0,-10}{1,3}{2,35}{3,35}", "uint", sizeof(uint), uint.MinValue, uint.MaxValue);
            Console.WriteLine("{0,-10}{1,3}{2,35}{3,35}", "long", sizeof(long), long.MinValue, long.MaxValue);
            Console.WriteLine("{0,-10}{1,3}{2,35}{3,35}", "ulong", sizeof(ulong), ulong.MinValue, ulong.MaxValue);
            Console.WriteLine("{0,-10}{1,3}{2,35}{3,35}", "float", sizeof(float), float.MinValue, float.MaxValue);
            Console.WriteLine("{0,-10}{1,3}{2,35}{3,35}", "double", sizeof(double), double.MinValue, double.MaxValue);
            Console.WriteLine("{0,-10}{1,3}{2,35}{3,35}", "decimal", sizeof(decimal), decimal.MinValue, decimal.MaxValue);
            Console.WriteLine("".PadRight(83, '-'));
        }
    }
}
