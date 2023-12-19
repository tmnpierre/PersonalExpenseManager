using System;

public class Expense
{
    public double Amount { get; set; }
    public DateTime Date { get; set; }
    public string Category { get; set; }

    public Expense(double amount, DateTime date, string category)
    {
        Amount = amount;
        Date = date;
        Category = category;
    }

    public override string ToString()
    {
        return $"Amount: {Amount}, Date: {Date.ToShortDateString()}, Category: {Category}";
    }
}
