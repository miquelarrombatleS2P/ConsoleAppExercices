using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppExerciceForeachAndLists
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            p.list1();
            Console.WriteLine("");
            p.list2();
        }

        public void list1()
        {
            List<String> names = new List<String>();

            names.Add("John");
            names.Add("Mary");
            names.Add("Sue");
            names.Add("Greg");
            names.Add("Yolanda");
            names.Add("Jose");
            names.Add("Bill");

            foreach (String x in names)
            {
                Console.WriteLine($"Hello {x}");
            }
            Console.ReadKey();
        }

        public void list2()
        {
            List<PersonModel> names = new List<PersonModel>();

            names.Add(new PersonModel("Tim", "Corey"));
            names.Add(new PersonModel("Bill", "McCoy"));
            names.Add(new PersonModel("Mary", "Jones"));
            names.Add(new PersonModel("Sue", "Smith"));

            foreach (var name in names)
            {
                Console.WriteLine($"Hello {name.FirstName} {name.LastName}");
            }
            Console.ReadKey();
        }
    }
}
