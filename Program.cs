using System;

class Program
{
    static void Main(string[] args)
    {
        ExpenseManager expenseManager = new ExpenseManager();
        bool exitProgram = false;

        while (!exitProgram)
        {
            Console.WriteLine("\nPersonal Expense Manager");
            Console.WriteLine("1. Add an Expense");
            Console.WriteLine("2. View Expenses");
            Console.WriteLine("3. Calculate Total Expenses");
            Console.WriteLine("4. Exit");
            Console.Write("Choose an option: ");

            string option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    AddExpense(expenseManager);
                    break;
                case "2":
                    expenseManager.DisplayExpenses();
                    break;
                case "3":
                    CalculateAndDisplayTotal(expenseManager);
                    break;
                case "4":
                    exitProgram = true;
                    break;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }

    private static void AddExpense(ExpenseManager expenseManager)
    {

    }

    private static void CalculateAndDisplayTotal(ExpenseManager expenseManager)
    {
        double total = expenseManager.CalculateTotalExpenses();
        Console.WriteLine($"Total Expenses: {total:C}");
    }
}
