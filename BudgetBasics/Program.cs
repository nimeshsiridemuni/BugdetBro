
using System;

// Keep totals outside the loop so values persist between menu choices.
decimal totalIncome = 0.00m;
decimal totalExpenses = 0.00m;
string menuChoice = "";

// Repeat the menu until the user chooses "0".
while (menuChoice != "0")
{
    DisplayMenu();
    menuChoice = Console.ReadLine() ?? "";

    switch (menuChoice)
    {
        case "1":
        {
            decimal addIncome = ValidateAmount("income");

            totalIncome += addIncome;

            Console.WriteLine("Income added.");
            break;
        }

        case "2":
        {
            decimal addExpense = ValidateAmount("expense");

            totalExpenses += addExpense;

            Console.WriteLine("Expense added.");
            break;
        }

        case "3":
        {
            decimal balance = CalculateBalance(
                totalIncome,
                totalExpenses
            );

            DisplaySummary(totalIncome, totalExpenses, balance);
            break;
        }

        case "0":
            Console.WriteLine("Shutting down...");
            break;

        default:
            Console.WriteLine(
                "Invalid option. Please choose 0, 1, 2, or 3."
            );
            break;
    }
}

// Display the menu without returning a value.
void DisplayMenu()
{
    Console.WriteLine();
    Console.WriteLine("=== Budget Bro ===");
    Console.WriteLine("1. Add Income");
    Console.WriteLine("2. Add Expense");
    Console.WriteLine("3. View Summary");
    Console.WriteLine("0. Exit");
    Console.Write("Choose an option: ");
}

// Validate an amount and return it when valid.
decimal ValidateAmount(string transactionType)
{
    while (true)
    {
        Console.Write($"Add your {transactionType}: ");

        string input = Console.ReadLine() ?? "";

        if (decimal.TryParse(input, out decimal amount)
            && amount > 0)
        {
            return amount;
        }

        Console.WriteLine(
            "Invalid amount. Please enter a number greater than zero."
        );
    }
}

// Display the values passed into the function.
void DisplaySummary(decimal income, decimal expenses, decimal balance)
{
    Console.WriteLine();
    Console.WriteLine("Your Summary");
    Console.WriteLine($"Income: LKR {income:F2}");
    Console.WriteLine($"Expenses: LKR {expenses:F2}");
    Console.WriteLine($"Final Balance: LKR {balance:F2}");
}

// Calculate the balance and return it to the caller.
decimal CalculateBalance(decimal income, decimal expenses)
{
    return income - expenses;
}
