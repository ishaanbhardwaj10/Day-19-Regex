using System.Collections.Generic;

namespace RegexUserRegistration
{
    class Program
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Welcome to User Registration Problem");
            Console.WriteLine("Use case #1: First Name");
            Console.WriteLine("Use case #2: Last Name");
            Console.WriteLine("Use case #3: Email");
            Console.WriteLine("Use case #4: Phone Numbers");
            Console.WriteLine("Use case #5: Password Rule One: minimum 8 characters");

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
                case 2:
                    string lastNameToValidate = "Bhardwaj";
                    if (ValidateLastName.validateString(lastNameToValidate))
                    {
                        Console.WriteLine("Valid");
                    }
                    else
                    {
                        Console.WriteLine("Invalid");
                    }
                    break;
                case 3:
                    string emailToValidate = "ishaan.bhardwaj10@google.co.in";
                    if (ValidateEmail.validateString(emailToValidate))
                    {
                        Console.WriteLine("Valid");
                    }
                    else
                    {
                        Console.WriteLine("Invalid");
                    }
                    break;
                case 4:
                    string numberToValidate = "91 9876543210";
                    if (ValidatePhoneNumber.validateString(numberToValidate))
                    {
                        Console.WriteLine("Valid");
                    }
                    else
                    {
                        Console.WriteLine("Invalid");
                    }
                    break;
                case 5:
                    string passwordOneValidate = "qwerty123";
                    if (PasswordRuleOne.validateString(passwordOneValidate))
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