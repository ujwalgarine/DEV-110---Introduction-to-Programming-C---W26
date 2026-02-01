# Week 6: Text Menu App

## Summary

Build a longer, text-heavy menu app that focuses on string techniques and polished console output. You will create a multi-option menu, format strings in several ways, and print aligned text patterns.

## Learning Objectives

- Use a `do-while` loop for input validation
- Use a `while` loop for a repeating menu
- Use a `switch` statement to handle menu choices
- Parse numeric input safely
- Format strings using multiple techniques
- Create elegant console output patterns

---

## Resources

- [C# Switch Statement](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/statements/selection-statements#the-switch-statement)
- [C# While and Do-While Loops](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/statements/iteration-statements#the-while-statement)
- [String Interpolation](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/tokens/interpolated)
- [String.Format](https://learn.microsoft.com/en-us/dotnet/api/system.string.format)
- [String Class Methods](https://learn.microsoft.com/en-us/dotnet/api/system.string)

---

## Assignment Requirements

Update a console program that follows this flow:

1. **Print a title banner**
    - Title: `Text Menu Studio`
    - Subtitle: `Strings + Console Output Patterns`
    - Divider line: 48 `=` characters

2. **Print the menu and repeat it until Exit**
    - Show a menu with options 1–6
    - Keep looping until the user chooses 6
    - Use a text box style menu (borders + alignment)

3. **Validate the menu choice using a `do-while` helper**
    - Create `ReadIntInRange(prompt, min, max)`
    - Use `int.TryParse`
    - Prompt: `Choose an option (1-6): `

4. **Handle each option with a `switch` statement**

    **Option 1: Greeting Card**
    - Prompts: `Enter your name: ` and `Enter a short message: `
    - Use `Trim()`, `ToUpper()`, `PadRight()`, and `string.Format()`
    - Print a boxed card with three lines (hello, shout, and message)

    **Option 2: Name Tag Formatter**
    - Prompts: `Enter first name: ` and `Enter last name: `
    - Build full name with concatenation
    - Build initials with `string.Format` and indexing
    - Print name tag, initials, and lowercase version

    **Option 3: Phrase Analyzer**
    - Prompt: `Enter a phrase: `
    - Use `Trim()`, `Replace()`, `Split()`, and `string.Join()`
    - Print length, contains 'a', dashed phrase, and words list

    **Option 4: Fancy Receipt Line**
    - Prompts: `Enter item name: `, `Enter price: `, `Enter quantity (1-9): `
    - Use composite formatting with alignment and currency
    - Print a small receipt-style table

    **Option 5: Menu Banner Builder**
    - Prompts: `Enter a title: `, `Enter a subtitle: `, `Enter width (30-60): `
    - Use `new string('=', width)` and alignment
    - Print a banner with centered title/subtitle and alignment samples

    **Option 6: Exit**
    - Output: `Goodbye!`

---

## Example Output

```
================================================
TEXT MENU STUDIO
Strings + Console Output Patterns
================================================

+------------------------------------------------+
| 1) Greeting Card                               |
| 2) Name Tag Formatter                          |
| 3) Phrase Analyzer                             |
| 4) Fancy Receipt Line                          |
| 5) Menu Banner Builder                         |
| 6) Exit                                        |
+------------------------------------------------+
Choose an option (1-6): 1

Enter your name: Ada
Enter a short message: Welcome!
------------------------------------------------
| Hello, Ada!                                   |
| Nice to meet you, ADA.                        |
| Message: Welcome!                             |
------------------------------------------------
```

---

## Getting Started

1. Navigate to the starter folder:

    ```bash
    # Mac/Linux:
    cd modules/week-06-text-menu-app/starter

    # Windows:
    cd modules\week-06-text-menu-app\starter
    ```

2. Review the TODO comments in `Program.cs`
3. Run your program:

    ```bash
    dotnet run
    ```

4. Test your work:

    ```bash
    # Mac/Linux:
    dotnet test ../tests

    # Windows:
    dotnet test ..\tests
    ```

---

## Grading Criteria

Your assignment will be automatically graded with 5 test cases:

| Test Area                       | Points  | Tests  |
| ------------------------------- | ------- | ------ |
| **Basic Setup**                 |         |        |
| Program compiles                | 10      | Test01 |
| **Menu + Validation**           |         |        |
| Menu repeats + input validation | 30      | Test02 |
| **Menu Options**                |         |        |
| Option outputs and calculations | 30      | Test03 |
| **Study Notes**                 |         |        |
| STUDY_NOTES.md exists           | 10      | Test04 |
| All sections completed          | 20      | Test05 |
| **Total**                       | **100** |        |

---

## Helpful Tips / Common Pitfalls

- Use `do-while` when you must ask at least once before checking validity.
- Keep your menu loop running until the user chooses Exit.
- Match prompts and output text exactly.
- Add a blank line between menu actions to keep output readable.
- Use alignment like `{0,-12}` and `{1,8}` for simple columns.
- Use `PadLeft` and `PadRight` to build centered text.

---

## Submission

1. Create a branch:

    ```bash
    git checkout main
    git pull origin main
    git checkout -b assignment/week-06
    ```

2. Commit and push your work:

    ```bash
    git add modules/week-06-text-menu-app/starter/Program.cs
    git add modules/week-06-text-menu-app/starter/STUDY_NOTES.md
    git commit -m "Complete Week 6: Text Menu App"
    git push -u origin assignment/week-06
    ```

3. Open a pull request in your GitHub repo:
    - Base branch: `main`
    - Title: `Week 6: Text Menu App`

4. Submit the pull request URL on Canvas.
