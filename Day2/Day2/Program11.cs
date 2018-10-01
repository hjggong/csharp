using System;
using System.Collections;
using System.Collections.Generic;

namespace Day2
{
    class Program11
    {
        public static void Main()
        {
            //Hashtable onj = new Hashtable();
            Dictionary<String, String> onj = new Dictionary<string, string>();

            onj.Add("김길동", "서울");
            onj.Add("홍길동", "광주");
            onj.Add("박길동", "부산");

            try
            {
                onj.Add("김길동", "서울");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("키값 중복!!");
            }

            Console.WriteLine("for key = \"name\", value={0}.", onj["홍길동"]);
            onj["박길동"] = "제주";
            Console.WriteLine("for key = \"name\", value={0}.", onj["박길동"]);

            if (!onj.ContainsKey("최길동"))
            {
                onj.Add("최길동", "하와이");
                Console.WriteLine("for key = \"who\", value={0}.", onj["최길동"]);
            }
            Console.WriteLine();

            //foreach(DictionaryEntry d in onj)
            foreach(KeyValuePair<string, string> d in onj)
            {
                Console.WriteLine("Key = {0}, Value = {1}", d.Key, d.Value);
            }

            /*
            SortedList s = new SortedList(onj);

            foreach(DictionaryEntry d in s)
            {
                Console.WriteLine("Key = {0}, Value = {1}", d.Key, d.Value);
            }
            */
        }
    }
}
