# 🧮 Calculator Project – Phase 4: Exception Handling

**Author:** Princess Ellis  
**Date:** November 2, 2025  
**Course:** Week 4 Calculator Project – Exception Handling  
**Language:** C#

---

## 📘 Project Overview
This project builds upon previous calculator phases to introduce **exception handling** and **input validation** in C#.  

The program allows users to:
- Enter two numeric values  
- Divide the first number by the second  
- Handle invalid input and divide-by-zero errors gracefully  
- Continue operations until the user chooses to quit  

This phase demonstrates structured error management and modular programming principles that will support the final calculator project.

---

## ⚙️ Features
✅ Displays a welcome message, title, and student name  
✅ Accepts user input for two values  
✅ Performs safe division operations  
✅ Handles the following exceptions:
- **DivideByZeroException** → Prompts user to re-enter a valid divisor  
- **FormatException** → Detects non-numeric input  
- **OverflowException** → Prevents overly large or small values  
✅ Allows the user to continue or quit the program  
✅ Displays a closing “thank you” message  

---

## 🧩 Program Structure

| Class | Responsibility |
|-------|----------------|
| `Calculator` | Performs arithmetic operations (currently division). |
| `InputHandler` | Manages user input safely and handles conversion exceptions. |
| `Program` | Controls program flow, displays menus, and handles top-level exceptions. |

---

## 🧠 Key Concepts Demonstrated
- **Try-Catch Blocks** for structured exception handling  
- **User Input Validation** using `Convert.ToDouble()` and error handling  
- **Custom Exception Messages** for better user experience  
- **Modular Design** with reusable classes and methods  

---

## 🖥️ Example Output

