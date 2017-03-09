using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalFinanceCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Finance RunApp = new Finance();
          
            RunApp.Welcome();
            RunApp.findGrossIncome();
            RunApp.determineNetIncome();
            RunApp.findLivingNumber();
            RunApp.determineSavingNumber();
            RunApp.displaySavingNumber();

            Console.ReadKey();
        }
    }
}
