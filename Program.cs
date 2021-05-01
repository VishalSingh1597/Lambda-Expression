using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpressionProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----Welcome To Lambda Expression-----");
            Console.WriteLine();

            //list object creation with person 
            List<Person> list = new List<Person>();

            //method call
            AddingPersonDetails(list);
            SearchPerson(list);
            Console.ReadLine();
        }

        //UC1 person management
        public static void AddingPersonDetails(List<Person> personList) //creating method
        {
            personList.Add(new Person() { SSN = 1, Age = 23, Name = "Vishal", Address = "Mumbai" });
            personList.Add(new Person() { SSN = 2, Age = 24, Name = "Himanshu", Address = "Nainital" });
            personList.Add(new Person() { SSN = 3, Age = 19, Name = "Omprakash", Address = "Pune" });
            personList.Add(new Person() { SSN = 5, Age = 75, Name = "Ekta", Address = "Pune" });
            personList.Add(new Person() { SSN = 6, Age = 86, Name = "Abhishek", Address = "Nashik" });
            personList.Add(new Person() { SSN = 7, Age = 15, Name = "roshan", Address = "UttarPradesh" });
           
        }
        //UC5 Check for specific name present in list or not
        public static void SearchPerson(List<Person> list)
        {
            try
            {
                var person = list.Where(x => x.Name == "Vishal").First();
                if (person != null)
                {
                    Console.WriteLine("person present");

                    Console.WriteLine("Age\t" + person.Age + "Name\t" + person.Name + "\t" + "Address\t" + person.Address);
                }
                else
                {
                    Console.WriteLine("person not exist in a list");
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
