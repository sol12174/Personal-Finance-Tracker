using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Personal_Finance_Tracker
{
  class Expense
        {
            public decimal Amount { get; private set; }
            public string Category { get; private set; }
            public DateTime Date { get; private set; }
            public string Description { get; private set; }

            public Expense(decimal amount, string category, string description)
            {
                Amount = amount;
                Category = category;
                Date = DateTime.Now; // Set to current date
                Description = description;
            }

            public void DisplayExpense()
            {
                Console.WriteLine("Date:"+ Date.ToShortDateString() +", Amount: " + Amount + "Category: "+ Category + "Description:" + Description);
            }
        }
    }

        
    
      
      

    

