using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalFinanceCalculator
{
    class Finance
    {
        double grossIncome;
        double netIncome;
        double takeTax = .68;
        double livingNumber;
        double savingNumber;
        
        public void Welcome()
        {
            Console.WriteLine("Welcome to Monthly Savings Calculator! We'll ask a few questions and go from there!");
            Console.ReadLine();
            
        }

        public void findGrossIncome()
        {
            Console.WriteLine("What is your gross income?");
             grossIncome = Convert.ToInt32(Console.ReadLine());

        }

        public void findLivingNumber()
        {
            Console.WriteLine("Add up ALL your expenses AND spending for a Month...This amount should enough to cover ALL your bills and a reasonable amount of money for entertainment etc.  Also known as your Monthly Living Number");
             livingNumber = Convert.ToInt32(Console.ReadLine());
        }
        
        public void determineNetIncome()
        {
            netIncome = grossIncome * takeTax / 12;
        }
               
        public void determineSavingNumber()
        {
            savingNumber = netIncome - livingNumber;
        }

        public void displaySavingNumber()
        {
            Console.WriteLine(savingNumber);
        }
        

        }
    }

