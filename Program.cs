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
            double balance = 30000;
            double annualContribution = 35500;
            double annualGrowthRate = 1.07;
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
