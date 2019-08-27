using System;
using System.Collections.Generic;

namespace Task3
{
    class Program
    {
        static List<string> RemoveDoubles(List<string> input)
        {
            var list = new List<string>();

            foreach (string str in input)
            {
                if (str[0] != 'Z')
                {
                    if (!list.Contains(str))
                    {
                        list.Add(str);
                    }
                }

            }
            return list;
        }

        static void DisplayPage(int pageNumber, List<string> input)
        {
            if(pageNumber < 0)
            {
                Console.WriteLine("Please enter positive number.");
                return;
            }

            const int pageSize = 5;

            Console.WriteLine($"Page {pageNumber}:");

            for (int i = pageSize*pageNumber; i < (pageSize * pageNumber)+pageSize && i < input.Count ; i++)
            {
                Console.WriteLine(input[i]);
            }
        }

        static void Main(string[] args)
        {
            Random random = new Random();
            const string ST = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

            string toAdd;

            List<string> myList = new List<string>();

            for (int i = 0; i < 100; i++)
            {
                toAdd = "";
                for (int j = 0; j < 4; j++)
                {
                    toAdd += ST[random.Next(0, ST.Length)];
                }
                myList.Add(toAdd);
            }

            Console.WriteLine($"List size: {myList.Count} First 10 elements: ");
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine(myList[i]);
            }

            myList = RemoveDoubles(myList);

            myList.Sort();
            myList.Reverse();

            
            Console.WriteLine($"List size: {myList.Count} First 10 elements: ");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(myList[i]);
            }

            while(true)
            {
                Console.Write("Enter page number(starting from zero): ");

                try
                {
                    int pageNumber = Convert.ToInt32(Console.ReadLine());
                    DisplayPage(pageNumber, myList);
                }
                catch (FormatException)
                {
                    Environment.Exit(0);
                }              
            }
        }
    }
}
