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
            Console.Write("Add your income: ");
            string incomeInput = Console.ReadLine() ?? "";

            if (decimal.TryParse(incomeInput, out decimal addIncome))
            {
                if (addIncome > 0)
                {
                    totalIncome = totalIncome + addIncome;
                    Console.WriteLine("Income added.");
                }
                else
                {
                    Console.WriteLine("Amount must be greater than zero.");
                }
            }
            else
            {
                Console.WriteLine("Please enter a valid number.");
            }

            break;

        case "2":
            Console.Write("Add your expense: ");
            string expenseInput = Console.ReadLine() ?? "";

            if (decimal.TryParse(expenseInput, out decimal addExpense))
            {
                if (addExpense > 0)
                {
                    totalExpenses = totalExpenses + addExpense;
                    Console.WriteLine("Expense added.");
                }
                else
                {
                    Console.WriteLine("Amount must be greater than zero.");
                }
            }
            else
            {
                Console.WriteLine("Please enter a valid number.");
            }

            break;

        case "3":
            decimal balance = CalculateBalance(totalIncome, totalExpenses);
            DisplaySummary(totalIncome, totalExpenses, balance);
            break;

        case "0":
            Console.WriteLine("Shutting down...");
            break;

        default:
            Console.WriteLine("Invalid option. Please choose 0, 1, 2, or 3.");
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