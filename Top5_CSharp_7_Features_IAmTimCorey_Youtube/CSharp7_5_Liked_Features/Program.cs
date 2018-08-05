using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp7_5_Liked_Features
{
    class Program
    {
        static void Main(string[] args)
        {
            //// first feature: Inline out variables.

            //Console.Write("What is your age: ");
            //string ageText = Console.ReadLine();

            ////// Old way of doing things
            ////int age = 0;
            ////bool IsValidAge = int.TryParse(ageText, out age);

            //// new ways of doing things.
            //bool IsValidAge = int.TryParse(ageText, out int age);

            //Console.WriteLine($"Your age is { age }.");



            //// Second feature: Pattern Matching
            //string ageFromConsole = "21";
            //int ageFromDatabase = 84;

            //object ageValue = ageFromDatabase;

            //// pattern match here 'ageValue is int age' : if the variable contains an integer then store integer value in a new variable named age
            //// 'ageValue is string ageText && int.TryParse(ageText, out age)' : otherwise if it is string, convert the value temporarily stored in variable ageText
            //// into an integer.
            //if (ageValue is int age || (ageValue is string ageText && int.TryParse(ageText, out age)))
            //{
            //    Console.WriteLine($"Your age is { age }.");
            //}
            //else
            //{
            //    Console.WriteLine("We don't know your age.");
            //}


            // Feature 3: Powerful switch statements
            Employee emp1 = new Employee { FirstName = "Joe", LastName = "Smith", IsManager = false, YearsWorked = 2 };
            Employee emp2 = new Employee { FirstName = "Sandra", LastName = "Jones", IsManager = true, YearsWorked = 28 };
            Customer cust1 = new Customer { FirstName = "Tim", LastName = "Corey", TotalDollarsSpent = 2342.15M };
            Customer cust2 = new Customer { FirstName = "Delana", LastName = "Greenback", TotalDollarsSpent = 558M };
            List<object> people = new List<object> { emp1, emp2, cust1, cust2 };

            foreach (var p in people)
            {
                switch(p)
                {
                    case Employee e when (e.IsManager == false):
                        Console.WriteLine($"{e.FirstName} is a good employee.");
                        break;
                    case Employee e when (e.IsManager):
                        Console.WriteLine($"{e.FirstName} runs the company.");
                        break;
                    case Customer c when (c.TotalDollarsSpent > 1000):
                        Console.WriteLine($"{c.FirstName} is a loyal customer.");
                        break;
                    case Customer c:
                        Console.WriteLine($"{c.FirstName} needs to spend more money.");
                        break;
                    default:
                        break;
                }
            }



























        }
    }
}
