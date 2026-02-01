namespace ProfileCard;

using System;
using System.Globalization;


public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("╔════════════════════════════════════════════╗");
        Console.WriteLine("║         STUDENT PROFILE CARD               ║");
        Console.WriteLine("╚════════════════════════════════════════════╝\n");

        // TODO: Collect PERSONAL INFORMATION (strings)
        // - Full name
        // - Hometown (city, state)
        // - Favorite color
        // - Dream job
        // Hint: string variableName = Console.ReadLine();
        Console.Write("Enter your full name: ");
        string fullName = Console.ReadLine();

        Console.Write("Enter your hometown (city, state): ");
        string hometown = Console.ReadLine();

        Console.Write("Enter your favorite color: ");
        string favoriteColor = Console.ReadLine();

        Console.Write("Enter your dream job: ");
        string dreamJob = Console.ReadLine();


        // TODO: Collect ACADEMIC INFORMATION
        // - Major (string)
        // - GPA (double, 0.0-4.0)
        // - Graduation year (int)
        // - Is full-time student? (bool from yes/no)
        // Hint: double gpa = double.Parse(Console.ReadLine());
        // Hint: bool isFullTime = answer.ToLower() == "yes";
        Console.Write("Enter your major/field of study: ");
        string major = Console.ReadLine();

        Console.Write("Enter your current GPA (0.0 - 4.0): ");
        double gpa = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.Write("Enter your graduation year (e.g., 2028): ");
        int graduationYear = int.Parse(Console.ReadLine());

        Console.Write("Are you a full-time student? (yes/no): ");
        string fullTimeAnswer = Console.ReadLine();
        bool isFullTime = fullTimeAnswer != null && fullTimeAnswer.Trim().ToLower() == "yes";

        // TODO: Collect ADDITIONAL DETAILS
        // - Age (int)
        // - Height in inches (double)
        // - Favorite number (int)
        Console.Write("Enter your age (years): ");
        int age = int.Parse(Console.ReadLine());

        Console.Write("Enter your height in inches (e.g., 70.5): ");
        double heightInches = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.Write("Enter your favorite number: ");
        int favoriteNumber = int.Parse(Console.ReadLine());

        // TODO: CALCULATE derived information
        // - Birth year = 2026 - age
        // - Years to graduation = graduationYear - 2026
        // - Height in feet and inches: feet = heightInches / 12, inches = heightInches % 12
        // - Is honor student? = gpa >= 3.5
        // - Age in months = age * 12
        int birthYear = 2026 - age;
        int yearsToGraduation = graduationYear - 2026;
        int heightFeet = (int)(heightInches / 12);
        double remainingInches = heightInches % 12;
        bool isHonorStudent = gpa >= 3.5;
        int ageInMonths = age * 12;

        // TODO: DISPLAY formatted profile card
        // Use sections with headers:
        // - PERSONAL INFORMATION
        // - ACADEMIC DETAILS
        // - CALCULATED STATISTICS
        // Use proper alignment and formatting
        Console.WriteLine("\n═════════════════════════ PROFILE ════════════════════════");
        Console.WriteLine("PERSONAL INFORMATION");
        Console.WriteLine($"  {"Full Name:",-22}{fullName}");
        Console.WriteLine($"  {"Hometown:",-22}{hometown}");
        Console.WriteLine($"  {"Favorite Color:",-22}{favoriteColor}");
        Console.WriteLine($"  {"Dream Job:",-22}{dreamJob}\n");

        Console.WriteLine("ACADEMIC DETAILS");
        Console.WriteLine($"  {"Major:",-22}{major}");
        Console.WriteLine($"  {"GPA:",-22}{gpa:F2}");
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
