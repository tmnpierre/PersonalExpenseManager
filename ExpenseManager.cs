using System;
using System.Collections.Generic;

public class ExpenseManager
{
    private List<Expense> expenses;

    public ExpenseManager()
    {
        expenses = new List<Expense>();
    }

    public void AddExpense(Expense expense)
    {
        expenses.Add(expense);
    }

    public void DisplayExpenses()
    {
        if (expenses.Count == 0)
        {
            Console.WriteLine("No expenses recorded yet.");
            return;
        }

        Console.WriteLine("\nList of Expenses:");
        foreach (Expense e in expenses)
        {
            Console.WriteLine(e);
        }
    }
}
