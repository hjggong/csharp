﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    class Program15
    {
        static void Main()
        {
            Func<int> func1 = () => 10;     // = (paramType) =>
            Console.WriteLine(func1());

            Func<int, int> func2 = (x) => x * x;
            Console.WriteLine("func2 :: {0}", func2(2));

            Func<string, string> func3 = (str) => str.ToUpper();
            Console.WriteLine("func3 :: {0}", func3("oraclejavacommunity"));

            Func<string, char[]> func4 = delegate (string str)
            {
                return str.ToArray();
            };
            Console.WriteLine("func4 :: 배열크기: {0}, 처음요소: {1}", func4("oraclejavacommunity").Count(), func4("oraclejavacommunity ")[0]);

            Func<string, string> func5 = convertUpper;
            Console.WriteLine("onj를 대문자로 {0}", func5("onj"));

            Func<string, string> func6 = (str) => str.ToLower();
            string[] onjs = { "ONJ", "ORACLEJAVA", "ORACLEJAVACOMMUNITY.CO.KR" };
            IEnumerable<string> onjWords = onjs.Select(func6);
            //IEnumerable<string> onjWords = onjs.Select(str => str.ToLower());
            foreach (string word in onjWords)
                Console.WriteLine(word);
        }

        static string convertUpper(string str)
        {
            return str.ToUpper();
        }
    }
}
