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



            // Second feature: Pattern Matching
            string ageFromConsole = "21";
            int ageFromDatabase = 84;

            object ageValue = ageFromDatabase;

            // pattern match here 'ageValue is int age' : if the variable contains an integer then store integer value in a new variable named age
            // 'ageValue is string ageText && int.TryParse(ageText, out age)' : otherwise if it is string, convert the value temporarily stored in variable ageText
            // into an integer.
            if (ageValue is int age || (ageValue is string ageText && int.TryParse(ageText, out age)))
            {
                Console.WriteLine($"Your age is { age }.");
            }
            else
            {
                Console.WriteLine("We don't know your age.");
            }


        }
    }
}
