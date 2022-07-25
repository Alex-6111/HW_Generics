
using System;
using static System.Console;
using System.Collections.Generic;

namespace HW_Generics
{
    internal class Program
    {

        static void Main()
        {
            Problem1();
            

        }

        public static void Problem1()
        {
            int a = 10;
            int b = 50;
            WriteLine($"first: {a} second: {b}");
            Swap<int>(ref a,ref b);
            WriteLine($"first: {a} second: {b}");
        }

        public static void Swap<T>(ref T lhs, ref T rhs)
        {
            T temp;
            temp = lhs;
            lhs = rhs;
            rhs = temp;
        }

        public static void Problem2()
        {

        }






    }
}