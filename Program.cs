using System;
using System.Linq.Expressions;

namespace Tech_Project_2a
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ask for the input
            Console.Write("Enter an Integer value between 1 and 25 to execute an iterative statement: ");

            try
            {
                string input = Console.ReadLine();
                int value_of_input = int.Parse(input);
                if ((value_of_input > 0) && (value_of_input <= 25))
                {
                    Console.WriteLine("You have entered" + value_of_input.ToString());
                    Console.WriteLine("This For Loop will iterate " + value_of_input.ToString() + "times.");
                    //Here is the For loop
                    for (int i = 0; i < value_of_input; i++)
                    {
                        Console.WriteLine(" This is the current integer value in the loop: " + i.ToString());
                    }
                    Console.WriteLine("Press any key to exit the program...");
                    Console.ReadKey(true);
                }
                else
                {
                    Console.WriteLine("Please enter an integer between 1 and 25 and try again...");
                    Console.WriteLine("Press any key to exit the program and try again...");
                    Console.ReadKey(true);
                }
            }
            catch
            {
                Console.WriteLine("Please enter an integer value and try running the program again...");
                Console.WriteLine("Press any key to exit the program...");
                Console.ReadKey(true);
            }
            

            
        }
    }
}
