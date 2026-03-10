# Week 9: Score Stats (Methods + LINQ) - Study Notes

**Name:** Ujwal Garine

## Methods and Decomposition

**Why is it helpful to break a program into small methods?**
[Think about readability, testing, and debugging]

Answer:
Small methods are easier to read and debug. Each method does one thing, so if something breaks, I know exactly where to look.

## LINQ (Stats + Method Chaining)

**Which LINQ methods did you use for basic statistics?**
[Examples: Min, Max, Average, Count with predicates]

Answer:
I used `Min()`, `Max()`, `Average()`, and `Count()` with lambda predicates to get stats without writing any loops.

**Which LINQ methods did you chain together for reports?**
[Examples: Where + OrderByDescending, OrderByDescending + Take]

Answer:
I chained `Where()` + `OrderByDescending()` for passing/failing scores, and `OrderByDescending()` + `Take()` for top scores.

**Why is it helpful to put score logic in a class (ScoreReport) instead of keeping everything in Program?**
[Think about organization, reuse, and readability]

Answer:
It keeps things organized. `Program` handles input, `ScoreReport` handles analysis. Each class is shorter and easier to understand.

## What I Learned

**Key takeaways from this week:**
[3-5 main things you learned]

1. LINQ replaces manual loops with clean, readable one-liners.
2. Chaining LINQ methods builds a pipeline that filters and sorts in one step.
3. Breaking code into small methods makes debugging much easier.
4. An orchestrator method like `PrintReport()` makes the overall flow obvious.
5. `CultureInfo.InvariantCulture` keeps number formatting consistent across machines.

**Which concept felt easiest (methods or LINQ) and why?**

Answer:
Methods felt easier — splitting code into named chunks is straightforward. LINQ took more thought until I understood how chaining flows from one method to the next.

## Time Spent

**Total time:** 2 hours

**Breakdown:**

- Understanding the starter code: 0.25 hours
- Implementing the print methods: 0.75 hours
- LINQ method chaining: 0.5 hours
- Testing and debugging: 0.25 hours
- Writing documentation: 0.25 hours

**Most time-consuming part:** [Which aspect took the longest and why?]

Answer:
LINQ chaining took the longest. Getting the order right — filter first, then sort — and using the correct predicates took a few tries.

## Reflection

**What would you improve next time?**

Answer:
I'd trace through a small example on paper before coding. That would help me catch comparison mistakes like `>=` vs `>` earlier.

**How did methods make this program easier to work on?**

Answer:
I could finish and test one method at a time. `PrintReport()` made it easy to see if I'd missed calling anything.
