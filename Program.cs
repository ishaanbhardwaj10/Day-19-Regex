using System.Collections.Generic;

namespace RegexUserRegistration
{
    class Program
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Welcome to User Registration Problem");
            Console.WriteLine("Use case #1: First Name");

            Console.Write("Please select a program to run from options above: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    string InputToValidate = "Ishaan";
                    if (ValidateFirstName.validateString(InputToValidate))
                    {
                        Console.WriteLine("Valid");
                    }
                    else
                    {
                        Console.WriteLine("Invalid");
                    }
                    break;
                default:
                    Console.WriteLine("Please enter a valid number from given options");
                    break;
            }


        }
    }
}