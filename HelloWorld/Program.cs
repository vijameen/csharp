using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            /**
             //Class name and method name always starts with upper case
             Console.WriteLine("Bob's big giveaway");
             Console.Write("Enter a number 1, 2 or 3: ");
             //Input from a console is always a string
             string userValue = Console.ReadLine();
             //in-line conditional operator
             string message = (userValue == "1") ? "boat" : "Strand of lint";
             //Use of a replacement code
             Console.WriteLine("You entered value {0}, therefore you get {1}", userValue, message);
             Console.ReadLine();
               **/
            int[] numbers = new int[] { 1, 2, 4, 5, 6 };
            //for (int i = 0; i < numbers.Length; i++)
            foreach (int num in numbers)
            Console.WriteLine(num);
            Console.ReadLine();
        }
    }
}
