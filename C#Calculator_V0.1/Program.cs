using System;

namespace Calculator 
{
    class Program
    {
        static void Main(string[] args)
        {
            bool repeat = true;
            double result = 0;
            string error = "not applicable";

            while (repeat) 
           {
            Console.WriteLine("Please insert your first number.");
            double number1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please insert your Operator. \"+\" for Addition, \"-\" for Subtraction, \"*\" for multiplication and \"/\" for division.");
           string ops = Console.ReadLine();

            Console.WriteLine("Please insert your second number.");
            double number2 = Convert.ToDouble(Console.ReadLine());
                

              switch (ops)
                    {
                        case "+":
                            result = number1 + number2;
                            break;
                        case "-":
                        result = number1 - number2;
                        break;
                        case "*":
                        result = number1 * number2;
                        break;
                       
                        case "/" :
                        if (number2 != 0)
                        
                            result = number1 / number2;
                        else Console.WriteLine("No division by \"0\".");
                        break;
                        
                            default:
                            Console.WriteLine("No Input");
                            break;
                      
                      }

                Console.WriteLine(number2 != 0? $"The result is {result}.": $"The result is {error}.");
                   
            
                Console.WriteLine("Do you want to perform another calculation? (y/n)");
                string answer = Console.ReadLine();
                if (answer != "y") 
                {
                    repeat = false;

                }

            }

        }
    }
}