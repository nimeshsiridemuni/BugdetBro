using System.Numerics;

// Defining global varaibles to hold catch the values and keep them zero and null
decimal userBalance = 0.00m;
decimal totalIncome = 0.00m;
decimal totalExpenses = 0.00m;
string? menuChoice = "";


// The while loop will make sure the program run unless the input choice is "0"
while (menuChoice != "0")
{
    Console.WriteLine("=== Budget Bro ===");
    Console.WriteLine("1. Add Income");
    Console.WriteLine("2. Add Expense");
    Console.WriteLine("3. View Summary");
    Console.WriteLine("0. Exit");
            
    Console.Write("Choose an option: ");
    menuChoice = Console.ReadLine() ?? ""; 

// Switch cases to avoid loop repition
    switch (menuChoice)
    {
        case "1":
        Console.WriteLine("Add your income:");
        decimal addIncome = Convert.ToDecimal(Console.ReadLine());
        userBalance = userBalance + addIncome;
        totalIncome = totalIncome + addIncome;
        break;   

        case "2":
        Console.WriteLine("Add your total expenses:");
        decimal addExpense = Convert.ToDecimal(Console.ReadLine());
        userBalance = userBalance - addExpense;
        totalExpenses = totalExpenses + addExpense;
        break;

        case "3":
        Console.WriteLine("Your Summary");
        Console.WriteLine($"Income: {totalIncome}");
        Console.WriteLine($"Expenses: {totalExpenses}");
        Console.WriteLine($"Final Balance: {userBalance}");
        break;

        case "0":
        Console.WriteLine("Shutting Down...");
        break;

// To prevent invalid inputs and crash the program.
        default:
        Console.WriteLine("Invalid input");
        break;

    }
} 

