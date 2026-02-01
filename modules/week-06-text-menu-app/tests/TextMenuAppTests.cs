/*******************************************************************************
- Course: DEV 110
- Instructor: Zak Brinlee
- Term: Winter 2026
-
- Programmer: YourName
- Assignment: Week 6: Text Menu App
-
- What does this program do?:
- Tests the Week 6 text menu assignment requirements.
- */

using System;
using System.IO;
using System.Text.RegularExpressions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TextMenuApp.Tests;

[TestClass]
public class TextMenuAppTests
{
    private StringWriter _output;
    private TextWriter _originalOutput;

    [TestInitialize]
    public void Setup()
    {
        _output = new StringWriter();
        _originalOutput = Console.Out;
        Console.SetOut(_output);
    }

    [TestCleanup]
    public void Cleanup()
    {
        Console.SetOut(_originalOutput);
        _output.Dispose();
    }

    private void ProvideInput(params string[] inputs)
    {
        var input = new StringReader(string.Join(Environment.NewLine, inputs));
        Console.SetIn(input);
    }

    private static int CountMatches(string input, string pattern)
    {
        return Regex.Matches(input, pattern, RegexOptions.IgnoreCase).Count;
    }

    [TestMethod]
    public void Test01_ProgramCompiles()
    {
        Assert.IsTrue(true, "✅ Project compiled successfully");
    }

    [TestMethod]
    public void Test02_MenuRepeatsAndExits()
    {
        ProvideInput(
            "0", "1", "Ada", "Hello!", // invalid option, then greeting card
            "6"                     // exit
        );

        Program.Main(Array.Empty<string>());
        string output = _output.ToString();
        string outputLower = output.ToLower();

        int menuPromptCount = CountMatches(outputLower, "choose an option");
        bool hasMenuLine = outputLower.Contains("1) greeting card") && outputLower.Contains("6) exit");
        bool hasTitle = outputLower.Contains("text menu studio") && outputLower.Contains("strings + console output patterns");
        bool hasHello = outputLower.Contains("hello, ada");
        bool hasGoodbye = outputLower.Contains("goodbye");

        Assert.IsTrue(
            menuPromptCount >= 2 && hasMenuLine && hasTitle && hasHello && hasGoodbye,
            "❌ Menu loop or exit behavior missing\n" +
            "💡 Tip: Use a while loop for the menu and ReadIntInRange for input");
    }

    [TestMethod]
    public void Test03_MenuOptionsWork()
    {
        ProvideInput(
            "2", "Ada", "Lovelace", // name tag
            "3", "hello world",     // phrase analyzer
            "4", "Pen", "2.5", "2", // receipt line
            "5", "Menu", "Today", "30", // banner
            "6"                       // exit
        );

        Program.Main(Array.Empty<string>());
        string outputLower = _output.ToString().ToLower();

        bool hasNameTag = outputLower.Contains("name tag: [ada lovelace");
        bool hasInitials = outputLower.Contains("initials: al");
        bool hasLowercase = outputLower.Contains("lowercase: ada lovelace");
        bool hasLength = outputLower.Contains("length:");
        bool hasDashed = outputLower.Contains("dashed: hello-world");
        bool hasWords = outputLower.Contains("words: hello, world");
        bool hasReceiptHeader = outputLower.Contains("item") && outputLower.Contains("total");
        bool hasCurrency = Regex.IsMatch(outputLower, @"\$\s*5\.00|\$5\.00");
        bool hasBanner = outputLower.Contains("centered:") && outputLower.Contains("left:") && outputLower.Contains("right:");

        Assert.IsTrue(
            hasNameTag && hasInitials && hasLowercase && hasLength && hasDashed && hasWords && hasReceiptHeader && hasCurrency && hasBanner,
            "❌ Menu option output missing or incorrect\n" +
            "💡 Tip: Match prompts and output formatting exactly");
    }

    [TestMethod]
    public void Test04_StudyNotesFileExists()
    {
        string testDir = Path.GetDirectoryName(typeof(TextMenuAppTests).Assembly.Location);
        string starterPath = Path.Combine(testDir, "..", "..", "..", "..", "starter", "STUDY_NOTES.md");
        string studyNotesPath = Path.GetFullPath(starterPath);
        bool exists = File.Exists(studyNotesPath);

        Assert.IsTrue(
            exists,
            "\n❌ Missing STUDY_NOTES.md file!\n" +
            "📝 The file should exist in the starter folder\n" +
            "💡 Location: modules/week-06-text-menu-app/starter/STUDY_NOTES.md");
    }

    [TestMethod]
    public void Test05_StudyNotesAllSectionsCompleted()
    {
        string testDir = Path.GetDirectoryName(typeof(TextMenuAppTests).Assembly.Location);
        string starterPath = Path.Combine(testDir, "..", "..", "..", "..", "starter", "STUDY_NOTES.md");
        string studyNotesPath = Path.GetFullPath(starterPath);

        if (File.Exists(studyNotesPath))
        {
            string content = File.ReadAllText(studyNotesPath);

            Assert.IsFalse(
                string.IsNullOrWhiteSpace(content.Split(new[] { "**Name:**" }, StringSplitOptions.None)[1].Split('\n')[0].Trim()),
                "\n❌ Please fill in your name at the top of STUDY_NOTES.md");

            string[] sections = content.Split("Answer:");
            int totalAnswerSections = sections.Length - 1;
            int filledAnswers = 0;

            for (int i = 1; i < sections.Length; i++)
            {
                string afterAnswer = sections[i].Trim();
                int nextSectionIndex = afterAnswer.IndexOf("**");
                if (nextSectionIndex > 0)
                {
                    afterAnswer = afterAnswer.Substring(0, nextSectionIndex).Trim();
                }

                if (!string.IsNullOrWhiteSpace(afterAnswer) && afterAnswer.Length > 5)
                {
                    filledAnswers++;
                }
            }

            Assert.IsTrue(
                filledAnswers >= totalAnswerSections - 2,
                $"\n❌ STUDY_NOTES.md has incomplete answers! (Completed: {filledAnswers}/{totalAnswerSections})\n" +
                "💡 Tip: Fill in all 'Answer:' sections with thoughtful responses");

            bool hasTakeaway1 = Regex.IsMatch(content, @"1\.\s+\w{3,}");
            bool hasTakeaway2 = Regex.IsMatch(content, @"2\.\s+\w{3,}");
            bool hasTakeaway3 = Regex.IsMatch(content, @"3\.\s+\w{3,}");

            Assert.IsTrue(
                hasTakeaway1 && hasTakeaway2 && hasTakeaway3,
                "\n❌ Please complete the 'Key takeaways' list (items 1, 2, and 3)");

            bool hasTimeTotal = content.Contains("**Total time:**") &&
                               Regex.IsMatch(content, @"\*\*Total time:\*\*\s+\d+");

            Assert.IsTrue(
                hasTimeTotal,
                "\n❌ Please fill in the 'Total time' section\n" +
                "💡 Tip: Example: **Total time:** 3 hours");
        }
        else
        {
            Assert.Inconclusive("STUDY_NOTES.md file does not exist yet");
        }
    }
}
