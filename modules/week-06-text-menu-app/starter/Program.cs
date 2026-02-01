/*******************************************************************************
- Course: DEV 110
- Instructor: Zak Brinlee
- Term: Winter 2026
-
- Programmer: YourName
- Assignment: Week 6: Text Menu App
-
- What does this program do?:
- Runs a text-heavy menu app that demonstrates string formatting and output patterns.
- */

namespace TextMenuApp;

public class Program
{
    public static void Main(string[] args)
    {
        // TODO 1: Build a title banner using strings
        // Required pieces:
        // - title: "Text Menu Studio"
        // - subtitle: "Strings + Console Output Patterns"
        // - divider: 48 '=' characters
        // Print the divider, title (uppercase), subtitle, divider

        int choice = 0;

        // TODO 2: Create a menu loop that repeats until the user chooses 6 (Exit)
        // Hint: Use a while loop: while (choice != 6)

        // TODO 3: Print the menu box each time through the loop
        // Use this exact text:
        // +------------------------------------------------+
        // | 1) Greeting Card                               |
        // | 2) Name Tag Formatter                          |
        // | 3) Phrase Analyzer                             |
        // | 4) Fancy Receipt Line                          |
        // | 5) Menu Banner Builder                         |
        // | 6) Exit                                        |
        // +------------------------------------------------+

        // TODO 4: Read a valid menu choice using ReadIntInRange
        // Prompt: "Choose an option (1-6): "

        // TODO 5: Use a switch statement to handle each choice
        // Option 1: Greeting Card
        // - Prompt: "Enter your name: " and "Enter a short message: "
        // - Use Trim(), ToUpper(), PadRight(), string.Format()
        // - Print a boxed card with three lines:
        //   Hello, <name>!
        //   Nice to meet you, <NAME>.
        //   Message: <message>

        // Option 2: Name Tag Formatter
        // - Prompt: "Enter first name: " and "Enter last name: "
        // - Build full name with concatenation
        // - Build initials with string.Format and indexing
        // - Print:
        //   Name tag: [<full name padded to 20>]
        //   Initials: <initials>
        //   Lowercase: <full name in lowercase>

        // Option 3: Phrase Analyzer
        // - Prompt: "Enter a phrase: "
        // - Use Trim(), Replace(), Split(), string.Join()
        // - Print:
        //   Length: <length>
        //   Contains 'a': <true/false>
        //   Dashed: <phrase with '-' instead of spaces>
        //   Words: <comma-separated list>

        // Option 4: Fancy Receipt Line
        // - Prompt: "Enter item name: ", "Enter price: ", "Enter quantity (1-9): "
        // - Use composite formatting with alignment and currency
        // - Print a small receipt table with a header and one line

        // Option 5: Menu Banner Builder
        // - Prompt: "Enter a title: ", "Enter a subtitle: ", "Enter width (30-60): "
        // - Use new string('=', width), PadLeft(), PadRight(), ToUpper()
        // - Print a banner with centered title/subtitle and three alignment lines

        // Option 6: print "Goodbye!"

        // TODO 6: Add a blank line between menu actions (but not after Exit)
    }

    private static int ReadIntInRange(string prompt, int min, int max)
    {
        // TODO 7: Use a do-while loop and int.TryParse to validate input
        // Repeat until the number is in range
        // Hint: !isValid || value < min || value > max
        return min;
    }

    private static double ReadDouble(string prompt)
    {
        // TODO 8: Use a do-while loop and double.TryParse to validate input
        return 0;
    }
}
