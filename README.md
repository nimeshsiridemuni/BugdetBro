# Budget Bro

Budget Bro is my learning project for building foundations in the C# and TypeScript full stack ecosystem.

I am starting with a simple C# console application and gradually working towards a web application that I can deploy. The focus is understanding each concept, practising it, and learning to build systems independently.

## Current Stage

The application currently runs in the console and tracks income, expenses, and the remaining balance during a single session.

### Completed Features

- Repeating menu with options to add income, add expenses, view a summary, and exit.
- Running totals for income and expenses.
- Balance updates when income or expenses are added.
- Summary showing total income, total expenses, and remaining balance.
- Invalid menu choices handled through a `default` case.

### Current Limitations

- Non-numeric amounts can cause the application to stop.
- Zero and negative amounts are currently accepted.
- Data is lost when the application closes.
- Individual transactions, descriptions, and categories are not stored yet.

## How to Run

Install the .NET SDK, then open a terminal in the repository root.

```powershell
cd BudgetBasics
dotnet run
```

### Menu

```text
=== Budget Bro ===
1. Add Income
2. Add Expense
3. View Summary
0. Exit
Choose an option:
```

## Learning Progress

### Day 1 — Setup and Console Output

- Created the `BudgetBasics` console application.
- Used `Console.WriteLine` to display messages.
- Learned how to run the application with `dotnet run`.
- Set up Git and connected the repository to GitHub.

### Day 2 — Interactive Menu and Calculations

- Practised using `decimal` variables for monetary values.
- Used `Console.ReadLine` to accept input.
- Created a repeating menu using a `while` loop.
- Used `switch`, `case`, and `default` to handle menu choices.
- Updated income, expense, and balance totals.
- Used string interpolation to display values.
- Explored the difference between `null`, an empty string, and the `??` operator.
- Identified the difference between menu-choice validation and amount validation.

I have practised these concepts in code and will review the theory to strengthen my understanding.

## Next Steps

- Review loops, switches, variable scope, and decimal values.
- Use `decimal.TryParse` to handle invalid numeric input.
- Reject zero and negative amounts.
- Allow the user to retry after entering an invalid amount.

## Longer-Term Learning Path

1. Organise code into methods.
2. Learn classes, objects, and collections.
3. Store and display individual transactions.
4. Save and load data using JSON files.
5. Build an API with ASP.NET Core.
6. Add database persistence.
7. Learn TypeScript and build a frontend.
8. Connect the frontend to the backend.
9. Use Docker to run the application and its dependencies.
10. Test and deploy the application.

## Learning Approach

I use documentation, tutorials, and AI assistance to explore concepts and examples. My goal is to explain the code I use, modify it independently, and practise rebuilding features without relying on a complete solution.
