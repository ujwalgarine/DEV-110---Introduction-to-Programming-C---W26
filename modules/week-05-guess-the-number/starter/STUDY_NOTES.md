# Week 5: Guess the Number – Study Notes

**Name:** Ujwal Garine

---

## Loop Types

### How is a `do-while` loop different from a `while` loop?

**Answer:**
A `do-while` loop runs at least once before checking the condition. A `while` loop checks first and may not run at all. I used `do-while` when I needed to ask the user for input at least once.

---

### Where did you use a `do-while` loop and why?

**Answer:**
I used it when asking for the max number and number of rounds. This way, the program keeps asking until the user enters a valid number.

---

### Where did you use a `while` loop and why?

**Answer:**
I used a `while` loop when the user was guessing the number. It keeps running until the correct number is guessed.

---

### Where did you use a `for` loop and why?

**Answer:**
I used a `for` loop for the rounds because I already knew how many times the game should repeat.

---

## Input Validation

### Why did you make a helper method?

**Answer:**
I made a helper method so I didn’t have to repeat the same code again and again. It makes the program cleaner and easier to fix.

---

### How did you check that the max value was between 10 and 100?

**Answer:**
I checked if the number was between 10 and 100. If it wasn’t, the program asked again.

---

### How did you check that the rounds were between 1 and 3?

**Answer:**
I checked if the number was between 1 and 3. If it wasn’t, the user had to re-enter it.

---

### How did you handle letters and invalid input?

**Answer:**
I used `int.TryParse()` to check if the input was a number. If it wasn’t, the program showed an error message.

---

## Guessing Logic

### How did you compare the guess to the secret number?

**Answer:**
I used `if` and `else` statements. If the guess was too low, it said “Too low.” If it was too high, it said “Too high.” If it matched, it said “Correct.”

---

### How did you count guesses?

**Answer:**
I used a variable called `guessCount` and added 1 every time the user guessed.

---

## Random Numbers

### How did you make the secret number?

**Answer:**
I used the `Random` class and `Next()` to generate a random number.

---

### Why did you use `max + 1`?

**Answer:**
Because `Random.Next()` does not include the last number. Adding 1 makes sure the max number can be picked.

---

## Testing and Debugging

### What did you test?

**Answer:**

- Typing letters (abc)
- Entering small numbers (5)
- Entering big numbers (200)
- Guessing correctly
- Entering wrong rounds (0, 5)

---

### What problems did you fix?

**Answer:**
At first, I forgot to reset the guess counter each round. I also forgot to add `+1` to `Random.Next()`. After fixing those, the game worked better.

---

## What I Learned

### Main things I learned

1. How to use different loops
2. How to check user input
3. How random numbers work
4. How to stop infinite loops
5. How to fix bugs

---

### Which loop felt easiest?

**Answer:**
The `while` loop felt easiest because it is simple and easy to understand.

---

## Time Spent

**Total time:** 4 hours

### Breakdown

- Planning: 1 hour
- Input validation: 1 hour
- Guessing logic: 30 minutes
- Testing: 1 hour
- Writing notes: 30 minutes

---

### Most difficult part

**Answer:**
Input validation took the most time because I had to think about many possible mistakes.

---

## Reflection

### What would you do differently next time?

**Answer:**
Next time, I would test my program earlier so I can find bugs faster.

---

### How did using different loops help you?

**Answer:**
It helped me understand when each loop is useful. Now I know which loop works best in different situations.

---
