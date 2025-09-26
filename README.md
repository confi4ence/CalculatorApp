# CalculatorApp
A simple C# console calculator with **unit tests**.  
The program allows a user to enter two numbers and calculates:

- ✅ Sum of the numbers  
- ✅ Product of the numbers  
- ✅ Quotient of the numbers (with division-by-zero handling)  
- ✅ Difference of the numbers  

Unit tests are written with **MSTest** to verify correctness.

## 📂 Project Structure
CalculatorSolution/
├─ CalculatorApp/ # Console application
│ ├─ Program.cs
│ └─ Calculator.cs
└─ CalculatorTests/ # MSTest project
└─ CalculatorTests.cs

### Running the Console App
```bash
cd CalculatorApp
dotnet run

