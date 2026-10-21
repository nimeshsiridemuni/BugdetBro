# Budget Bro

Budget Bro is a learning project where I am building my foundations in C# and TypeScript through a budget tracker.

I am starting with a console application and gradually working towards a full stack application that I can deploy. My goal is to understand how each part works and develop the skills to build systems independently.

## Current Features

- Add income and expenses.
- Track total income, total expenses, and remaining balance.
- View a summary with amounts displayed in LKR to two decimal places.
- Handle unsupported menu choices.
- Reject blank and non-numeric amounts.
- Reject zero and negative amounts.
- Keep the menu running until the user selects Exit.

Invalid amounts display an error and return the user to the main menu without changing the totals.

## Requirements

- .NET SDK compatible with the target framework in `BudgetBasics.csproj`.

## How to Run

From the repository root:

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

- Created the C# console application.
- Practised displaying text using `Console.WriteLine`.
- Ran the application using `dotnet run`.
- Set up Git and connected the repository to GitHub.

### Day 2 — Menu and Calculations

- Used `decimal` variables to store monetary values.
- Read user input with `Console.ReadLine`.
- Created a repeating menu using a `while` loop.
- Used `switch`, `case`, `default`, and `break`.
- Calculated income, expense, and balance totals.
- Used string interpolation to display values.
- Explored nullable strings, empty strings, and the `??` operator.

### Day 3 — Amount Validation

- Observed a `FormatException` caused by invalid numeric input.
- Replaced `Convert.ToDecimal` with `decimal.TryParse`.
- Used the conversion result and `out` parameter.
- Added nested conditions to accept only positive amounts.
- Applied validation to both income and expenses.
- Used `F2` formatting to display two decimal places.

### Part 2 — Functions

- Extracted menu output into DisplayMenu().
- Passed summary values into DisplaySummary().
- Used CalculateBalance() to return income minus expenses.
- Removed the separate running balance variable.
- Practised the difference between returning and printing a value.

Next: extract amount validation into ReadPositiveAmount() and add retries.

## Manual Testing

The following checks were completed manually:

| Test                    | Expected result                                   | Status |
| ----------------------- | ------------------------------------------------- | ------ |
| Unsupported menu choice | Display an invalid-option message                 | Passed |
| Non-numeric amount      | Display an error without stopping the application | Passed |
| Blank amount            | Reject without changing totals                    | Passed |
| Zero amount             | Display a positive-amount requirement             | Passed |
| Negative amount         | Reject without changing totals                    | Passed |
| Valid income            | Increase income and balance                       | Passed |
| Valid expense           | Increase expenses and decrease balance            | Passed |
| Summary                 | Display the correct totals and balance            | Passed |

## Current Limitations

- Data is stored only while the application is running.
- Individual transactions, descriptions, categories, and dates are not recorded.
- Invalid amounts return to the main menu rather than prompting for an immediate retry.
- Tests are manual; automated tests have not been added.

## Next Steps

- Learn methods and extract menu display into a reusable method.
- Add direct retries for invalid amounts.
- Learn classes and collections to store individual transactions.
- Save and load data using JSON files.

## Longer-Term Goals

- Build an ASP.NET Core API.
- Add database persistence.
- Learn TypeScript and build a frontend.
- Connect the frontend to the API.
- Use Docker to run the application and its dependencies.
- Add automated tests and deploy the application.

## Learning Approach

I use documentation, tutorials, and AI assistance to explore concepts and examples. I practise by running the code, testing different inputs, explaining its behaviour, and making changes myself.
