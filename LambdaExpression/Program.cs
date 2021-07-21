﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace LambdaExpression
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> list = new List<Person>();
            AddingPersonDetails(list);
            RetrieveTopTwoLessThanSixty(list);
        }

        /// <summary>
        /// UC 1 - Adding Person Details
        /// </summary>
        /// <param name="list"></param>
        public static void AddingPersonDetails(List<Person> list)
        {
            list.Add(new Person() { SSN = 1, Name = "Ajith", Address = "Mumbai", Age = 14});
            list.Add(new Person() { SSN = 2, Name = "Satya", Address = "Pune", Age = 75 });
            list.Add(new Person() { SSN = 3, Name = "Bhuvana", Address = "Chennai", Age = 13 });
            list.Add(new Person() { SSN = 4, Name = "Sushmitha", Address = "Bengaluru", Age = 33 });
            list.Add(new Person() { SSN = 5, Name = "Snehitha", Address = "Chennai", Age = 60 });
            foreach (Person person in list)
            {
                Console.WriteLine("SSN : {0}\tName : {1}\tAddress : {2}\tAge : {3}", person.SSN, person.Name, person.Address, person.Age);
            }
        }

        /// <summary>
        /// UC 2 - Retrieving top 2 records from the list whose age is lessthan sixty
        /// </summary>
        /// <param name="list"></param>
        public static void RetrieveTopTwoLessThanSixty(List<Person> list)
        {
            Console.WriteLine("\nRetrieving the top 2 records from the list whose age is less than sixty");
            List<Person> result = list.FindAll(p => p.Age < 60).OrderBy(x => x.Age).Take(2).ToList();
            foreach (Person person in result)
            {
                Console.WriteLine("SSN : {0}\tName : {1}\tAddress : {2}\tAge : {3}", person.SSN, person.Name, person.Address, person.Age);
            }
        }
    }
}
