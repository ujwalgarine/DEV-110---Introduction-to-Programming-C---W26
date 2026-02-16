# Week 6: Text Menu App - Study Notes

**Name:** Ujwal Garine


## Loop Types

**How is a `do-while` loop different from a `while` loop?**

Answer:
A do-while loop runs at least once before checking the condition, while a while loop checks the condition first before running. A do-while is best when the user must enter something at least one time, and a while loop is best when repeating until a condition becomes false.

**Where did you use a `do-while` loop in this assignment and why?**

Answer:
I used a do-while loop inside my input validation helper methods. It keeps prompting the user until they enter a valid number within the required range.

**Where did you use a `while` loop and why?**

Answer:
I used a while loop for the main menu. It keeps showing the menu options until the user selects option 6 to exit.

**Where did you use a `for` loop and why?**

Answer:
I did not use a for loop in this assignment because I did not need to repeat something a fixed number of times. Most repetition depended on user input instead of a counter.


## Input Validation

**Why did you create a helper method for input validation?**

Answer:
I created helper methods to avoid repeating the same validation logic multiple times. This makes the code cleaner and easier to maintain.

**How did you validate the menu choice (1–6)?**

Answer:
I used int.TryParse to convert the input into a number and checked that it was between 1 and 6. If it was not valid, the program prompted the user again.

**How did you handle invalid input (non-numbers)?**

Answer:
I used int.TryParse and double.TryParse. These methods safely attempt conversion and return false instead of crashing the program if the input is invalid.


## String Operations

**Which string methods did you use across the different menu options?**

Answer:
I used Trim, ToUpper, ToLower, Replace, Split, Join, Contains, PadLeft, PadRight, Substring, Equals, EndsWith, IndexOf, and string formatting methods like interpolation and string.Format.

**Which four string methods did you demonstrate in Option 6 (String Analysis)?**

Answer:
I demonstrated Equals with StringComparison.OrdinalIgnoreCase, Substring to extract the first three characters, EndsWith to check for an exclamation mark, and IndexOf to find the position of a space.

**What's the difference between string concatenation and interpolation?**

Answer:
Concatenation combines strings using the plus operator, while interpolation uses the dollar sign and curly braces to insert variables directly into a string. I prefer interpolation because it is cleaner and easier to read.


## What I Learned

**Key takeaways from this week:**

1. Loop structures control repetition in different ways depending on the situation.
2. Input validation prevents crashes and improves user experience.
3. String methods are powerful tools for formatting and analyzing text.
4. Helper methods make programs more organized and reusable.
5. Clear output formatting improves readability and professionalism.

**Which loop felt most natural to use and why?**

Answer:
The while loop felt most natural because it clearly represents repeating something until a condition changes, which matches how a menu system works.


## Time Spent

**Total time:** 3

**Breakdown:**

- Planning the loops: 0.5
- Input validation: 0.5
- String formatting: 0.75
- Testing and debugging: 0.75
- Writing documentation: 0.5

**Most time-consuming part:**

Answer:
Testing and debugging took the most time because small formatting differences caused test failures that required careful adjustments.


## Reflection

**What would you do differently next time?**

Answer:
Next time I would carefully review test expectations earlier to avoid small formatting mismatches.

**How did using three different loop types improve your understanding of repetition?**

Answer:
Using different loop types helped me understand when to use condition-first loops, condition-after loops, and counter-based repetition. It made me more confident in choosing the correct loop for different scenarios.
