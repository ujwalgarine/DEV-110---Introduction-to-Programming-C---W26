namespace ProfileCard;

using System;
using System.Globalization;

public class Program
{
    public static void Main(string[] args)
    {
        // Title banner (just for looks)
        Console.WriteLine("╔════════════════════════════════════════════╗");
        Console.WriteLine("║         STUDENT PROFILE CARD               ║");
        Console.WriteLine("╚════════════════════════════════════════════╝\n");

        // =========================================================
        // 1) PERSONAL INFORMATION (strings)
        // Strings store text.
        // =========================================================
        Console.Write("Enter your full name: ");
        string fullName = Console.ReadLine();

        Console.Write("Enter your hometown (city, state): ");
        string hometown = Console.ReadLine();

        Console.Write("Enter your favorite color: ");
        string favoriteColor = Console.ReadLine();

        Console.Write("Enter your dream job: ");
        string dreamJob = Console.ReadLine();

        // =========================================================
        // 2) ACADEMIC INFORMATION
        // - major: string (text)
        // - gpa: double (decimal number)
        // - graduationYear: int (whole number)
        // - isFullTime: bool (true/false) based on yes/no input
        // =========================================================
        Console.Write("Enter your major/field of study: ");
        string major = Console.ReadLine();

        Console.Write("Enter your current GPA (0.0 - 4.0): ");
        // InvariantCulture means it expects a decimal point like 3.75 (not 3,75).
        double gpa = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.Write("Enter your graduation year (e.g., 2028): ");
        int graduationYear = int.Parse(Console.ReadLine());

        Console.Write("Are you a full-time student? (yes/no): ");
        string fullTimeAnswer = Console.ReadLine();

        // Convert the user's yes/no into a boolean (true if they typed "yes")
        bool isFullTime =
            fullTimeAnswer != null &&
            fullTimeAnswer.Trim().ToLower() == "yes";

        // =========================================================
        // 3) ADDITIONAL DETAILS
        // - age: int
        // - heightInches: double (can include decimals like 70.5)
        // - favoriteNumber: int
        // =========================================================
        Console.Write("Enter your age (years): ");
        int age = int.Parse(Console.ReadLine());

        Console.Write("Enter your height in inches (e.g., 70.5): ");
        double heightInches = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.Write("Enter your favorite number: ");
        int favoriteNumber = int.Parse(Console.ReadLine());

        // =========================================================
        // 4) CALCULATED (derived) VALUES
        // These are based on what the user typed.
        // =========================================================

        // Example: if it's 2026 and you're 18, birth year = 2026 - 18 = 2008
        int birthYear = 2026 - age;

        // Example: if graduation year is 2028, years left = 2028 - 2026 = 2
        int yearsToGraduation = graduationYear - 2026;

        // Convert inches into feet + remaining inches
        // Example: 70.5 inches -> 5 feet, 10.5 inches
        int heightFeet = (int)(heightInches / 12);
        double remainingInches = heightInches % 12;

        // Honor student if GPA is 3.5 or higher
        bool isHonorStudent = gpa >= 3.5;

        // Convert age in years to age in months
        int ageInMonths = age * 12;

        // =========================================================
        // 5) DISPLAY THE PROFILE CARD
        // Using alignment so it looks clean.
        // =========================================================
        Console.WriteLine("\n═════════════════════════ PROFILE ════════════════════════");

        Console.WriteLine("PERSONAL INFORMATION");
        Console.WriteLine($"  {"Full Name:",-22}{fullName}");
        Console.WriteLine($"  {"Hometown:",-22}{hometown}");
        Console.WriteLine($"  {"Favorite Color:",-22}{favoriteColor}");
        Console.WriteLine($"  {"Dream Job:",-22}{dreamJob}\n");

        Console.WriteLine("ACADEMIC DETAILS");
        Console.WriteLine($"  {"Major:",-22}{major}");
        Console.WriteLine($"  {"GPA:",-22}{gpa:F2}"); // F2 = show 2 decimal places
        Console.WriteLine($"  {"Graduation Year:",-22}{graduationYear}");
        Console.WriteLine($"  {"Full-Time Student:",-22}{(isFullTime ? "Yes" : "No")}");
        Console.WriteLine($"  {"Age:",-22}{age}\n");

        Console.WriteLine("CALCULATED STATISTICS");
        Console.WriteLine($"  {"Birth Year:",-22}{birthYear}");
        Console.WriteLine($"  {"Years to Graduation:",-22}{yearsToGraduation}");
        Console.WriteLine($"  {"Height (ft & in):",-22}{heightFeet} ft {remainingInches:F1} in");
        Console.WriteLine($"  {"Honor Student:",-22}{(isHonorStudent ? "Yes" : "No")}");
        Console.WriteLine($"  {"Age in Months:",-22}{ageInMonths}");
        Console.WriteLine($"  {"Favorite Number:",-22}{favoriteNumber}");

        Console.WriteLine("\n═══════════════════════════════════════════");
        Console.WriteLine("Profile complete! Good luck with your studies!");
    }
}
