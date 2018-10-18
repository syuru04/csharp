using System;
using System.Collections;
using System.Collections.Generic;
class Example
{
    public static void Main()
    {
        Dictionary<String, String> onj = new Dictionary<string, string>();
        onj.Add("김길동", "서울");
        onj.Add("홍길동", "광주");
        onj.Add("박길동", "부산");
        try
        {
            onj.Add("김길동", "서울");
        }
        catch
        {
            Console.WriteLine("키값 중복...");
        }
        Console.WriteLine("1. For key = \"name\", value = {0}.", onj["홍길동"]);
        onj["박길동"] = "제주";
        Console.WriteLine("2. For key = \"name\", value = {0}.", onj["박길동"]);
        if (!onj.ContainsKey("최길동"))
        {
            onj.Add("최길동", "하와이");
            Console.WriteLine("3. Value added for key = \"who\": {0}", onj["최길동"]);
        }
        Console.WriteLine();
        foreach (KeyValuePair<string, string> d in onj)
        {
            Console.WriteLine("4 .Key = {0}, Value = {1}", d.Key, d.Value);
        }
        SortedList s = new SortedList(onj); 

        foreach (DictionaryEntry d in s)
        {
            Console.WriteLine("5 .Key = {0}, Value = {1}", d.Key, d.Value);
        }
    }
}