using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Personal_Finance_Tracker
{
    class Program
    {
        static void Main(string[] args)
        {

            FinanceTracker financeTracker = new FinanceTracker();
            bool running = true;

            while (running)
            {
                Console.Clear();
                Console.WriteLine("Personal Finance Tracker");
                Console.WriteLine("-------------------------");
                Console.WriteLine("1. Add Expense");
                Console.WriteLine("2. View Expenses");
                Console.WriteLine("3. View Total Expenses");
                Console.WriteLine("4. Exit");
                Console.Write("Choose an option: ");

                string choice = Console.ReadLine();
                
                switch (choice)
                {
                    case "1":
                        AddExpense(financeTracker);
                        break;
                    case "2":
                        financeTracker.DisplayExpenses();
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey();
                        break;
                    case "3":
                        ShowTotalExpenses(financeTracker);
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey();
                        break;
                    case "4":
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey();
                        break;
                }
            }
        }

        static void AddExpense(FinanceTracker financeTracker)
        {
            Console.Clear();
            Console.WriteLine("Add Expense");
            Console.WriteLine("-----------");

            Console.Write("Enter amount: ");
            decimal amount = Convert.ToDecimal(Console.ReadLine());
            if (amount <= 0)
            {
                Console.WriteLine("Invalid amount. Please try again.");
                return;
            }

            Console.Write("Enter category: ");
            string category = Console.ReadLine();

            Console.Write("Enter description: ");
            string description = Console.ReadLine();

            financeTracker.AddExpense(amount, category, description);
            Console.WriteLine("Expense added successfully! Press any key to continue...");
            Console.ReadKey();
        }

        static void ShowTotalExpenses(FinanceTracker financeTracker)
        {
            Console.Clear();
            decimal total = financeTracker.GetTotalExpenses();
            Console.WriteLine("Total Expenses: {total:C}");
        }
    }
}
        
    

