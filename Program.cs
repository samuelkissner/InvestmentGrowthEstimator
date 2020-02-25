using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvestmentGrowthEstimator
{
    class Program
    {
        //purpose: use console to request input from user. converts input from string to double
        //parameters: string consoleMsg - the input request message to display to the user.
        //            string errorMsg - error message in case user input fails validation
        //returns: user input converted to a double
        public static double requestUserInputDouble(string consoleMsg, string errorMsg){
            double inputAsDouble; 
            while(true){
                Console.Write(consoleMsg);
                string input = Console.ReadLine().Trim();
                if(!double.TryParse(input, out inputAsDouble) || inputAsDouble <0){
                    Console.WriteLine(errorMsg);
                }else{
                    break;
                }
            }
            
            return inputAsDouble;
        }

        //purpose: Estimate investment growth over a number of years
        static void Main(string[] args)
        {
            string errorMsg = "Please enter a positive, numeric value.";
            

            //obtain and validate user input for starting value
            double balance = requestUserInputDouble("Enter starting balance: ", errorMsg);
          
            //obtain and validate user input for annual contribution
            double annualContribution = requestUserInputDouble("Enter annual contribution: ", errorMsg);
      

            //obtain and validate user input for growth rate
            double annualGrowthRate = requestUserInputDouble("Enter annual growth rate (1.07 would be a growth rate of 7%): ", errorMsg);
            
            int i = 0;
            string columnHeaders = "Year     Balance";
            // the following is the index at which the 'B' is.
            // this index will be used to line up balances with the 'Balance' column
            int secondColumnIndex = columnHeaders.IndexOf("B");
            string blankSpaces = "".PadRight(secondColumnIndex - i.ToString().Length);

            Console.WriteLine(columnHeaders);
            Console.WriteLine(i+ blankSpaces + balance);
            for (++i; i <= 10; i++)
            {
                balance = (balance + annualContribution) * annualGrowthRate;
                blankSpaces = "".PadRight(secondColumnIndex - i.ToString().Length);
                
                Console.WriteLine(i + blankSpaces + balance);
            }

            Console.ReadLine();
        }

        
    }
}
