using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Personal_Finance_Tracker
{
    class Budget
    {

        public decimal TotalAmount { get; private set; }
        public decimal RemainingAmount { get; private set; }

        public Budget(decimal totalAmount)
        {
            TotalAmount = totalAmount;
            RemainingAmount = totalAmount;
        }

        public void AddExpense(decimal amount)
        {
            if (amount < 0)
            {
                Console.WriteLine("Cannot add a negative amount.");
                return;
            }

            RemainingAmount -= amount;

            if (RemainingAmount < 0)
            {
                Console.WriteLine("Warning: You have exceeded your budget!");
            }
        }

        public void DisplayBudget()
        {
            Console.WriteLine("Total Budget: {TotalAmount:C}");
            Console.WriteLine("Remaining Amount: {RemainingAmount:C}");
        }

        public void ResetBudget(decimal newAmount)
        {
            TotalAmount = newAmount;
            RemainingAmount = newAmount;
        }
    }
}
        
    
        
    

