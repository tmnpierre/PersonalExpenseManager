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
            Console.WriteLine("3. Exit");
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
        Console.Write("Enter the amount: ");
        double amount = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the date (format YYYY-MM-DD): ");
        DateTime date = Convert.ToDateTime(Console.ReadLine());

        Console.Write("Enter the category: ");
        string category = Console.ReadLine();

        Expense newExpense = new Expense(amount, date, category);
        expenseManager.AddExpense(newExpense);

        Console.WriteLine("Expense added successfully.");
    }
}
