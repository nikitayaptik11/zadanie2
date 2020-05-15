﻿using System;
using System.Collections.Generic;

namespace zadanie2
{
    class Program
    {
        static void Pervoe(string str)
        {
            int count = 0;

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == 'f') count++;

                if (count == 2 && str[i] == 'f')
                {
                    int index = str.IndexOf(str[i + 1]);
                    Console.WriteLine(index - 1);
                    break;
                }
            }
            if (count == 1) Console.WriteLine(1);
            if (count == 0) Console.WriteLine(2);
        }

        static void vtoroe(string str)
        {
            Dictionary<string, string> dicchar = new Dictionary<string, string>()
            {
                {"а","a"},
                {"б","b"},
                {"в","v"},
                {"г","g"},
                {"д","d"},
                {"е","e"},
                {"ё","yo"},
                {"ж","zh"},
                {"з","z"},
                {"и","i"},
                {"й","y"},
                {"к","k"},
                {"л","l"},
                {"м","m"},
                {"н","n"},
                {"о","o"},
                {"п","p"},
                {"р","r"},
                {"с","s"},
                {"т","t"},
                {"у","u"},
                {"ф","f"},
                {"х","h"},
                {"ц","ts"},
                {"ч","ch"},
                {"ш","sh"},
                {"щ","sch"},
                {"ъ","'"},
                {"ы","i"},
                {"ь",""},
                {"э","e"},
                {"ю","yu"},
                {"я","ya"}
            };

            string result = "";

            foreach (var ch in str)
            {
                string ss = "";

                if (dicchar.TryGetValue(ch.ToString(), out ss))
                {
                    result += ss;
                }
                else result += ch;
            }
            Console.WriteLine(result);
        }

        static void tretie(string str)
        {
            string vverx = "";

            for (int i = 0; i < str.Length; i++)
            {
                int index = str.IndexOf(str[i]);

                if (str[i] == 'h' && i != 0 && i != str.Length - 1) vverx += 'H';
                else vverx += str[i];
            }

            Console.WriteLine(vverx);
        }

        static void Main(string[] args)
        {
            //1
            Pervoe("lkjdfkg");

            //2
            vtoroe("здесь чтото есть");

            //3
            tretie("hohlindos");
        }
    }
}