using System;
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
            RetrieveTeenageRecords(list);
            FindAverage(list);
            SearchingName(list,"Satya");
            SkipRecord(list);
        }

        /// <summary>
        /// UC 1 - Adding Person Details
        /// </summary>
        /// <param name="list"></param>
        public static void AddingPersonDetails(List<Person> list)
        {
            list.Add(new Person() { SSN = 1, Name = "Ajith", Address = "Mumbai", Age = 14 });
            list.Add(new Person() { SSN = 2, Name = "Satya", Address = "Pune", Age = 75 });
            list.Add(new Person() { SSN = 3, Name = "Bhuvana", Address = "Chennai", Age = 13 });
            list.Add(new Person() { SSN = 4, Name = "Sushmitha", Address = "Bengaluru", Age = 33 });
            list.Add(new Person() { SSN = 5, Name = "Snehitha", Address = "Chennai", Age = 65 });
            Iterate(list);
        }

        /// <summary>
        /// UC 2 - Retrieving top 2 records from the list whose age is lessthan sixty
        /// </summary>
        /// <param name="list"></param>
        public static void RetrieveTopTwoLessThanSixty(List<Person> list)
        {
            Console.WriteLine("\nDisplay records if age less than sixty");
            var find = list.FindAll(p => p.Age < 60);
            Iterate(find);
            Console.WriteLine("\nDispaly sorted records");
            var order = find.OrderBy(x => x.Age).ToList();
            Iterate(order);
            Console.WriteLine("\nRetrieving the top 2 records from the list whose age is less than sixty");
            var result = order.Take(2).ToList();
            Iterate(result);
        }

        /// <summary>
        /// UC 3 - Retreieve all records whose age is between 13 to 18
        /// </summary>
        /// <param name="list"></param>
        public static void RetrieveTeenageRecords(List<Person> list)
        {
            Console.WriteLine("\nDisplay records from the list whose age is between 13 to 18");
            var result = list.FindAll(p => p.Age > 13 && p.Age < 18);
            Iterate(result);
        }

        /// <summary>
        /// UC 4 - Find avrage age in the list
        /// </summary>
        /// <param name="list"></param>
        public static void FindAverage(List<Person> list)
        {
            var result = list.Average(x => x.Age);
            Console.WriteLine("\nThe Average of age in the list : " + result);
        }

        /// <summary>
        /// UC 5 - Searching a specific name
        /// </summary>
        /// <param name="list"></param>
        public static void SearchingName(List<Person> list,string name)
        {
            try
            {
                Console.WriteLine("\nSearching a name {0} in the list ",name);
                var person = list.Find(x => x.Name.Equals(name));
                if (person != null)
                    Console.WriteLine("SSN : {0}\tName : {1}\tAddress : {2}\tAge : {3}", person.SSN, person.Name, person.Address, person.Age);
                else
                    Console.WriteLine("{0} does not exists", name);
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        /// <summary>
        /// UC 6 - Skip records if age less than sixty
        /// </summary>
        /// <param name="list"></param>
        public static void SkipRecord(List<Person> list)
        {
            try
            {
                Console.WriteLine("\nSkip Record Age less than 60");
                List<Person> result = list.FindAll(x => x.Age > 60).Skip(1).ToList();
                Iterate(result);
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public static void Iterate(List<Person> list)
        {
            foreach (Person person in list)
            {
                Console.WriteLine("SSN : {0}\tName : {1}\tAddress : {2}\tAge : {3}", person.SSN, person.Name, person.Address, person.Age);
            }
        }
    }
}
