# Week 10: Habit Tracker (File I/O) — Study Notes

**Name:** Ujwal Garine

## File I/O — Reading

**What does `File.ReadAllLines` return, and how did you use it?**

Answer: It returns a string array where each element is one line from the file. I looped through each line, split it by commas, and pulled out the name, status, and frequency to build Habit objects.

**Why is it important to skip blank lines when reading a CSV file?**

Answer: If you try to split an empty string on a comma, you get an array with nothing useful in it. Accessing parts like index 0 or 1 would crash the program with an index out of range error, so skipping blank lines prevents that from happening.

## File I/O — Writing

**What does `File.WriteAllLines` do, and what arguments does it take?**

Answer: It writes an array of strings to a file, one string per line. It takes two arguments: the file path where you want to save and the string array containing what to write. It creates the file if it doesn't exist, or overwrites it if it does.

**What is `Select(...).ToArray()` doing in `SaveHabits`?**

Answer: Select transforms each Habit object into a formatted CSV string like Exercise,done,daily. It produces an IEnumerable, and ToArray converts that into a plain string array that File.WriteAllLines can actually accept and use.

## Exception Handling

**What is a `FileNotFoundException` and when does it occur?**

Answer: It is an error C# throws when you try to read a file that does not exist at the given path. For example, if the user provides a wrong file name or the file was deleted, this exception gets thrown automatically.

**Why do we catch `FileNotFoundException` specifically instead of using `catch (Exception)`?**

Answer: Catching all exceptions hides bugs you actually want to know about. If something unexpected breaks like a permissions error or corrupted data, a generic catch would silently swallow it. Being specific means only the case we planned for gets handled quietly, while everything else still surfaces as an error.

## What I Learned

**Key takeaways from this week:**

1. File.ReadAllLines and File.WriteAllLines make reading and writing files surprisingly straightforward in C#.
2. Always validate input data by skipping blanks and trimming whitespace before processing it, because real files tend to be messy.
3. Specific exception handling is better practice than catching everything, because it keeps unexpected bugs visible instead of hiding them.

**What was the trickiest part of this assignment and how did you work through it?**

Answer: The trickiest part was making sure the return statement was outside the try/catch block. At first I had it inside the try block, which meant the method would not return anything if an exception occurred. Moving it outside ensured the list always gets returned, even if it ends up empty.

## Time Spent

**Total time:** ~5 hours

**Breakdown:**

- Understanding the starter code and CSV formats: 0.5 hours
- Implementing LoadHabits: 1 hour
- Implementing PrintHabits / PrintSummary: 0.5 hours
- Implementing AddHabit / UpdateHabit / SaveHabits: 1.5 hours
- Testing and debugging: 1 hour
- Writing study notes: 0.5 hours

**Most time-consuming part:**

Answer: Implementing AddHabit, UpdateHabit, and SaveHabits together took the most time because they all needed to work correctly with each other before I could properly test any of them.
