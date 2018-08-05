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
            // first feature: Inline out variables.

            Console.Write("What is your age: ");
            string ageText = Console.ReadLine();

            // Old way of doing things
            int age = 0;
            bool IsValidAge = int.TryParse(ageText, out age);

            Console.WriteLine($"Your age is { age }.");
        }
    }
}
