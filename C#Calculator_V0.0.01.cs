using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Sololearn
{
    class Program
    {
        static void Main(string[] args)
        {
            
          Console.WriteLine("Please insert your numbers and the Operator needed in the first 3 lines.");
          
          double x = Convert.ToDouble (Console.ReadLine ());
          string ops = Console.ReadLine ();
          double y = Convert.ToDouble (Console.ReadLine ());
         
          if (ops == "+") 
          {
              Console.WriteLine (Convert.ToString(x + y));
          }

         else if (ops == "-") 
          {
              Console.WriteLine (Convert.ToString(x - y));
          }
          
           else if (ops == "*") 
          {
              Console.WriteLine (Convert.ToString(x * y));
          }

             else if (ops == "x") 
          {
              Console.WriteLine (Convert.ToString(x * y));
          }

     else if (ops == "/") 
          {
              Console.WriteLine (Convert.ToString(x / y));
          }

        }
    }

            
}
    

