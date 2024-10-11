using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Personal_Finance_Tracker
{
 class FinanceTracker
    {
        private List<Expense> expenses;

        public FinanceTracker()
        {
            expenses = new List<Expense>();
        }

        public void AddExpense(decimal amount, string category, string description)
        {
            Expense newExpense = new Expense(amount, category, description);
            expenses.Add(newExpense);
            Console.WriteLine("Expense added successfully!");
        }

        public void DisplayExpenses()
        {
            Console.WriteLine("\nExpenses:");
            foreach (var expense in expenses)
            {
                expense.DisplayExpense();
            }
        }

        public decimal GetTotalExpenses()
        {
            decimal total = 0;
            foreach (var expense in expenses)
            {
                total += expense.Amount;
            }
            return total;
        }
    }
}