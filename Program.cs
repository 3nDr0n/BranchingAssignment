using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BranchingAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");  //displays greeting message

            Console.WriteLine("Please enter the weight of your package.");  
            int weight = Convert.ToInt32(Console.ReadLine());  //creates variable and assigns value based on user input that is converted to int 

            if (weight > 50)  //branching statement comparing the weight given by user to the limit
            {
                Console.WriteLine("Package is too heavy to be shipped via Package Express. Have a good day");  //displays message is package is too heavy
                Console.ReadLine(); 
            }
            else
            {
                Console.WriteLine("Please enter the package width");
                int width = Convert.ToInt32(Console.ReadLine());   //creates variable and assigns value on user input

                Console.WriteLine("Please enter the package height");
                int height = Convert.ToInt32(Console.ReadLine());  //creates variable and assigns value on user input

                Console.WriteLine("Please enter the package length");
                int length = Convert.ToInt32(Console.ReadLine());  //creates variable and assigns value on user input

                if (length + height + width > 50)  //branching statement comparing the total of dimensions to the limit
                {
                    Console.WriteLine("Package too big to be shipped via Package Express.");  //if dimensions too big, displays this message
                    Console.ReadLine();
                }
                else
                {
                    double quote = ((height * width * length) * weight) / 100;  //calculates quote 

                    Console.WriteLine("Your estimated total for shipping this package is: $" + quote);  //displays quote message
                    Console.ReadLine();
                }
            }
        }
    }
}
