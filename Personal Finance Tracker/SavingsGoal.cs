using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Personal_Finance_Tracker
{
 class SavingsGoal
        {
            public decimal GoalAmount { get; private set; }
            public decimal CurrentSavings { get; private set; }

            public SavingsGoal(decimal goalAmount)
            {
                GoalAmount = goalAmount;
                CurrentSavings = 0;
            }

            public void AddSavings(decimal amount)
            {
                if (amount < 0)
                {
                    Console.WriteLine("Cannot add a negative amount.");
                    return;
                }

                CurrentSavings += amount;
                Console.WriteLine("Added {amount:C}. Current savings: {CurrentSavings:C}");
            }

            public bool IsGoalReached()
            {
                return CurrentSavings >= GoalAmount;
            }

            public void DisplayProgress()
            {
                Console.WriteLine("Current savings: {CurrentSavings:C} out of {GoalAmount:C}");
            }
        }
    }

        
    

