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
        foreach (Expense e in expenses)
        {
            Console.WriteLine(e);
        }
    }
}
