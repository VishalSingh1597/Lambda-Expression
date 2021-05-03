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
            IterateOverList(personList);
        }
        public static void IterateOverList(List<Person> personlist)
        {
            foreach (Person person in personlist)
            {
                Console.WriteLine("Age\t" + person.Age + "\t" + "Name\t" + person.Name + "\t" + "Address\t" + person.Address);
            }
        }

    }
}
