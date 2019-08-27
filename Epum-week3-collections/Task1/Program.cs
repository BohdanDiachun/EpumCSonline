using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Person
    {
        public string Name { get; set; }
        
        public int Age { get; set; }

        public IEnumerable<string> PhoneNumbers { get; set; }

        public Person(string _Name, int _Age)
        {
            Name = _Name;
            Age = _Age;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            List<Person> myList = new List<Person>();

            myList.Add(new Person("Shanice", 20));
            List<string> toAdd = new List<string> { "42551", "123152", "5234235" };
            myList[0].PhoneNumbers = toAdd;

            myList.Add(new Person("Bud", 24));
            toAdd = new List<string> { "12351325", "234123", "5235457" };
            myList[1].PhoneNumbers = toAdd;

            myList.Add(new Person("Jorge", 22));
            toAdd = new List<string> { "634726", "635235", "1235123" };
            myList[2].PhoneNumbers = toAdd;

            myList.Add(new Person("Ashlea", 21));
            toAdd = new List<string> { "4577456", "7457564", "2363454" };
            myList[3].PhoneNumbers = toAdd;

            myList.Add(new Person("Nikita", 23));
            toAdd = new List<string> { "4574567", "456457457", "724572555" };
            myList[4].PhoneNumbers = toAdd;

            myList.Add(new Person("Miranda", 25));
            toAdd = new List<string> { "7457278", "2462362", "745546" };
            myList[5].PhoneNumbers = toAdd;

            foreach (var item in myList)
            {
                Console.WriteLine($"Name: {item.Name}, Age: {item.Age}");
            }


            List<Person> newList = new List<Person>();

            newList.Add(new Person("Gracie ", 20));
            toAdd = new List<string> { "29194", "151784152", "5248335" };
            newList[0].PhoneNumbers = toAdd;

            newList.Add(new Person("Marx", 22));
            toAdd = new List<string> { "1225325", "23419793", "5212647" };
            newList[1].PhoneNumbers = toAdd;

            myList.AddRange(newList);


            foreach (var item in myList)
            {
                Console.Write($"Name: {item.Name}, Numbers:");
                foreach (var number in item.PhoneNumbers)
                {
                    Console.Write(" " + number);
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
