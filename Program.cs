using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvestmentGrowthEstimator
{
    class Program
    {
        static void Main(string[] args)
        {
            string errorMsg = "Please enter a positive, numeric value.";
            string input;

            //obtain and validate user input for starting value
            double balance;
            while(true){
                Console.Write("Enter starting balance: ");
                input = Console.ReadLine().Trim();
                if(!double.TryParse(input, out balance) || balance <0){
                    Console.WriteLine(errorMsg);
                }else{
                    break;
                }
            }
            //obtain and validate user input for annual contribution
            double annualContribution;
            while(true){
                Console.Write("Enter annual contribution: ");
                input = Console.ReadLine().Trim();
                if(!double.TryParse(input, out annualContribution) || balance <0){
                    Console.WriteLine(errorMsg);
                }else{
                    break;
                }
            }

            //obtain and validate user input for growth rate
            double annualGrowthRate;
            while(true){
                Console.Write("Enter annual growth rate (1.07 would be a growth rate of 7%): ");
                input = Console.ReadLine().Trim();
                if(!double.TryParse(input, out annualGrowthRate) || balance <0){
                    Console.WriteLine(errorMsg);
                }else{
                    break;
                }
            }
            
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
