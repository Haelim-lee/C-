﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*-----------------------------------------------------------------------------
 * Name: _016_String
 * DESC: 문자열 제어
-----------------------------------------------------------------------------*/
namespace _016_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = "abcdefg";
            string str2 = "hijklmn";
            string str3 = str1 + str2;

            Console.WriteLine("str1 + str2: {0}", str3);

            string str4 = "zzz";
            string str5 = "zzz";
            Console.WriteLine("str4 == str5: {0}", (str4 == str5));

            int x = 10;
            string str6 = str5 + "   " + ":" + x; // zzz : 10
            Console.WriteLine("str6: {0}", str6);

            string str7 = "Hello World!";
            string str8 = str7.Replace("Hello", "Hi"); // Hi World!
            Console.WriteLine("str8: {0}", str8);

            Console.WriteLine("str8.ToUpper(): {0}", str8.ToUpper()); // HI WORLD!
            Console.WriteLine("str8.ToLower(): {0}", str8.ToLower()); // hi world!
            Console.WriteLine(str7 + str6); // Hello World! zzz : 10
        }
    }
}
