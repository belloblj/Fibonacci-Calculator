# 📘 FibonacciCalculator

![Build Status](https://img.shields.io/badge/build-passing-brightgreen)
![Platform](https://img.shields.io/badge/platform-.NET%206.0-blue)
![License](https://img.shields.io/badge/license-MIT-lightgrey)

A beginner-friendly C# console application that calculates and displays the Fibonacci sequence up to a user-specified number of terms. 
This project demonstrates input validation, loop-based computation, jump statements, and formatted output messaging.

---

## 🚀 Features

- ✅ Accepts user input for number of terms
- 🔁 Calculates Fibonacci sequence using loops
- 🧠 Uses jump statements for base cases
- 🗨️ Displays formatted messages for each term
- ⚠️ Handles overflow and invalid input gracefully

---

## 🛠️ Technologies Used

- C# (.NET 6.0 or later)
- Console Application
- Visual Studio / VS Code

---

## 📦 Setup Instructions

### Option 1: Using Visual Studio

1. Open Visual Studio.
2. Create a new **Console App (.NET Core)** project.
3. Replace the contents of `Program.cs` with the code from this repository.
4. Press `Ctrl + F5` to run.

### Option 2: Using .NET CLI

```bash
dotnet new console -n FibonacciCalculator
cd FibonacciCalculator
# Replace Program.cs with the provided code
dotnet run
```
---

### Sample Output

<img width="608" height="614" alt="image" src="https://github.com/user-attachments/assets/49ae26e9-d045-4d9b-a1a1-cc329d1d1845" />


 ### Code Overview
- Main() handles input, validation, and output.
- CalculateFibonacci(int term) computes each term using a loop.
- switch expressions format output messages.
- try-catch and Environment.Exit() handle errors.

### ⚠️ Error Handling
- ❌ Non-integer input → Displays error and exits
- ❌ Negative or zero input → Displays error and exits
- ❌ Overflow detection → Stops calculation and warns the user

### ✍️ Author Notes
This project is ideal for beginners learning:
- Control flow in C#
- Input/output handling
- Basic algorithm implementation
- Defensive programming practices


## 🌍 Real-World Applications of the Fibonacci Sequence
### 1. 📈 Algorithm Design & Software Engineering
  - Recursive thinking: Fibonacci is a classic example for teaching recursion, memoization, and dynamic programming.
  - Performance benchmarking: Used to compare iterative vs recursive implementations and optimize algorithms.
  - Data structure traversal: Fibonacci heaps are used in advanced priority queue implementations.
### 2. 🧬 Biology & Nature
  - Plant growth: Leaf arrangements, seed patterns (like sunflower spirals), and pinecone scales often follow Fibonacci numbers.
  - Animal reproduction: The sequence models idealized rabbit population growth over time.
### 3. 🎨 Art, Architecture & Design
  - Golden Ratio: Closely related to Fibonacci; used to create visually pleasing proportions in art, buildings, and product design.
  - Spiral patterns: Found in shells, hurricanes, and galaxies—often modeled using Fibonacci-based spirals.
### 4. 💹 Finance & Trading
  - Technical analysis: Traders use Fibonacci retracement levels to predict price movements and support/resistance zones.
  - Risk modeling: Fibonacci ratios help in estimating market corrections and trend reversals.
### 5. 📊 Data Visualization & Dashboards
  - Layout optimization: Fibonacci-based grids and spacing improve readability and aesthetics in dashboards.
  - Animation timing: Fibonacci intervals can be used to create natural-feeling transitions and delays.
### 6. 🧠 Education & Cognitive Science
  - Learning progression: Fibonacci is used to scaffold learning in math and computer science curricula.
  - Memory training: Patterns based on Fibonacci help in developing memory and pattern recognition skills.

## 🧪 Bonus: Your Calculator as a Learning Tool
Your FibonacciCalculator is more than a coding exercise—it’s a gateway to:
- Practicing error handling, loop control, and modular design
- Building interactive command-line tools
- Connecting backend logic to real-world modeling

### 📄 License
This project is licensed under the MIT License.

