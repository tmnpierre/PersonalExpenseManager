using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

public class ExpenseManager
{
    private List<Expense> expenses;
    private readonly string filePath = "expenses.json";

    public ExpenseManager()
    {
        expenses = new List<Expense>();
        LoadExpenses();
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

    public double CalculateTotalExpenses()
    {
        double total = 0;
        foreach (Expense e in expenses)
        {
            total += e.Amount;
        }
        return total;
    }

    public void SaveExpenses()
    {
        string json = JsonConvert.SerializeObject(expenses, Formatting.Indented);
        File.WriteAllText(filePath, json);
    }

    private void LoadExpenses()
    {
        if (File.Exists(filePath))
        {
            string json = File.ReadAllText(filePath);
            expenses = JsonConvert.DeserializeObject<List<Expense>>(json) ?? new List<Expense>();
        }
    }
}
