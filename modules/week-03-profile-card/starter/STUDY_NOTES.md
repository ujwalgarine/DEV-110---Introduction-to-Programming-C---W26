# Week 3: Personal Profile Card - Study Notes

**Name:**
Ujwal

## Understanding Variables and Data Types

**What are the four main data types you used in this assignment?**
[List string, int, double, and bool - explain what each stores and give examples from your profile card]

Answer:
- string: used for text inputs (full name, hometown, favorite color, dream job, major).
- double: used for GPA and height in inches to preserve decimals.
- int: used for age, graduation year, favorite number, birth year, and age in months.
- bool: used for full-time status and honor student (derived from gpa >= 3.5).
Conversions are done with int.Parse and double.Parse.

**Why did you use `double` for GPA instead of `int`?**
[Explain the difference and why decimal precision matters for GPA]

Answer: Because GPA is calculated using a decimal rather than an integer

**How did you convert the yes/no input into a boolean?**
[Explain the comparison operation you used]

Answer: compared the inpur to "yes" using = operator after converting it to lowercase.

## Data Modeling Decisions

**How did you organize the information into logical groups?**
[Explain why you grouped certain pieces of information together (personal, academic, etc.)]

Answer: I grouped the data into personal, academic, and calculated sections to keep it clear for the user.
an example of this is area like home town is personal
metric like gpa or desired field of study is academic
age in months or whether you are an honors student is calculated

**Which pieces of information did you calculate rather than ask for?**
[List the derived data: birth year, years to graduation, height conversion, honor status, age in months]

Answer:
- Birth year = 2026 - age.
- Years to graduation = graduationYear - 2026.
- Height conversion: feet = (int)(heightInches / 12); remaining inches = heightInches % 12 (keeps fractional inches).
- Honor student: gpa >= 3.5.
- Age in months = age * 12.

**Why is it better to calculate birth year from age rather than ask for both?**
[Explain data consistency and reducing redundant input]

Answer: because to find the year of birth the only thing you need is (current year - age)

## Challenges and Solutions

**Biggest challenge with this assignment:**
[What was the hardest part? Type conversion, calculations, formatting, choosing data types?]

Answer:Main challenges were ensuring parsing works across locales and making sure output labels match test expectations. I tested with `dotnet run` and the automated tests via `dotnet test ../tests`. I added explicit prompts using Console.Write to ensure tests detect input prompts.

**How you solved it:**
[Explain your approach to overcoming the challenge]

Answer:
I solved it by asking google or asking chatGPT which github commands I needed to use if I was struggling.

**Most confusing concept:**
[What was hardest to understand? Type casting, modulus for height, boolean logic, or formatting?]

Answer: for me formatting was really hard because I thought it would take forever. But I learned you can
do ,-int next to a string to create spacing based on your desired length. This was a huge time saver for me.

## Type Conversion and Calculations

**How do you convert string input to a number?**
[Explain Parse methods: int.Parse(), double.Parse()]

Answer: To convert user input from a string to a number, I used parsing methods such as `int.Parse()` and `double.Parse()`. These methods take a string and convert it into numeric form. If the input is invalid, the program throws an error, so validation is important.

**What calculation did you use to convert height from inches to feet and inches?**
[Explain: feet = inches / 12, remaining = inches % 12]

Answer:
I divided the total inches by 12 to get the number of feet. Then, I used the modulus operator to find the remaining inches.

- feet = inches / 12
- remainingInches = inches % 12

**How did you determine if someone is an honor student?**
[Explain the boolean comparison: gpa >= 3.5]

Answer:
I used a boolean comparison to check whether the GPA was greater than or equal to 3.5.

Example:
`isHonorStudent = gpa >= 3.5`

## Output Formatting

**How did you format the GPA to show exactly 2 decimal places?**
[Explain the :F2 format specifier]

Answer:
I used the `:F2` format specifier, which displays the number with two decimal places.

**How did you display different text based on whether someone is full-time or part-time?**
[Explain the conditional/ternary operator you used]

Answer:
I used the conditional (ternary) operator to choose between two outputs.

Example:
`status = credits >= 12 ? "Full-Time" : "Part-Time"`

**What techniques did you use to make the output look organized?**
[Discuss alignment, spacing, section headers, borders]

Answer:
- Used spacing and line breaks
- Added section headers
- Aligned labels and values
- Used separators

## Real-World Data Modeling

**What other calculated fields could you add to a profile?**
[Think of other derived data: BMI from height/weight, time to birthday, etc.]

Answer:
- BMI from height and weight
- Days until next birthday
- Age from date of birth
- Average grade
- Attendance percentage

**Why is choosing the right data type important in real applications?**
[Explain memory, precision, and type safety]

Answer: Choosing the right data type improves accuracy, saves memory, prevents errors,
and makes programs more reliable and efficient.

**How does this profile card relate to real-world applications?**
[Think about social media profiles, job applications, student records systems]

Answer:
Profile cards are similar to systems used in social media,
job applications, school records, and databases that store
and process personal information.

## What I Learned

**Key takeaways from this week:**
[What are the 3-5 most important things you learned about variables and data modeling?]

1. Different data types store different kinds of information.
2. User input must be converted before calculations.
3. Boolean values help control program logic.
4. Formatting improves readability.
5. Good variable names make code easier to understand.

**Which data type was most challenging to work with and why?**
[Reflect on your experience with string, int, double, or bool]

Answer: The `double` data type was most challenging because of rounding and precision issues when working with decimals.

**How does understanding data types help you write better programs?**
[Explain the benefits of type safety and appropriate data representation]

Answer: Understanding data types reduces bugs, improves performance, and makes programs easier to maintain and debug.

## Testing and Debugging

**What test cases did you use to verify your calculations?**
[List different inputs you tested - edge cases, typical values, etc.]

Answer:
- GPA: 3.5, 4.0, 2.8, 0.0
- Height: 60, 72, 0 inches
- Credits: 11, 12, 15
- Invalid input (letters instead of numbers)

**What bugs or errors did you encounter and fix?**
[Describe any type conversion errors, calculation mistakes, or formatting issues]

Answer:
- Errors from invalid user input
- Incorrect height conversions
- Formatting mistakes
- Logic errors in conditions

**How did you validate that your data types were correct?**
[Explain how you checked that GPA, heights, ages worked correctly]

Answer:
I checked that numbers used `int` or `double`, text used `string`, and conditions used `bool`. I also tested multiple inputs.

## Time Spent

**Total time:** [1 hours 45m]

**Breakdown:**

-   Understanding data types and planning variables: [15 m]
-   Collecting user input with correct types: [15 m]
-   Implementing calculations: [20 m]
-   Formatting output: [30 m]
-   Testing and debugging: [10 m]
-   Writing documentation: [15 m]

**Most time-consuming part:** [Which aspect took the longest and why?]

Answer: formatting because I had to go back and make lots of changes to format my code

## Reflection

**What would you do differently if you started over?**
[Consider variable names, calculation order, organization, etc.]

Answer:I would organize my variables better, add input validation earlier, and plan my calculations more carefully.

**How does proper data modeling make programs easier to maintain?**
[Think about readability, consistency, and reducing errors]

Answer:Good data modeling improves readability, keeps data consistent, and reduces future bugs.

**What real-world system would you like to model next?**
[Shopping cart, game character, recipe calculator, etc.]

Answer:
