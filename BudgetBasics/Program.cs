// Keep totals outside the loop so values persist between menu choices.
decimal userBalance = 0.00m;
decimal totalIncome = 0.00m;
decimal totalExpenses = 0.00m;
string menuChoice = "";

// Repeat the menu until the user chooses "0".
while (menuChoice != "0")
{
    Console.WriteLine();
    Console.WriteLine("=== Budget Bro ===");
    Console.WriteLine("1. Add Income");
    Console.WriteLine("2. Add Expense");
    Console.WriteLine("3. View Summary");
    Console.WriteLine("0. Exit");

    Console.Write("Choose an option: ");
    menuChoice = Console.ReadLine() ?? "";

    // Handle the selected menu option.
    switch (menuChoice)
    {
        case "1":
            Console.Write("Add your income: ");
            string incomeInput = Console.ReadLine() ?? "";

            if (decimal.TryParse(incomeInput, out decimal addIncome))
            {
                if (addIncome > 0)
                {
                    userBalance = userBalance + addIncome;
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
                    userBalance = userBalance - addExpense;
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
            Console.WriteLine("Your Summary");
            Console.WriteLine($"Income: LKR {totalIncome:F2}");
            Console.WriteLine($"Expenses: LKR {totalExpenses:F2}");
            Console.WriteLine($"Final Balance: LKR {userBalance:F2}");
            break;

        case "0":
            Console.WriteLine("Shutting down...");
            break;

        default:
            // Handle unsupported menu choices.
            Console.WriteLine("Invalid option. Please choose 0, 1, 2, or 3.");
            break;
    }
}