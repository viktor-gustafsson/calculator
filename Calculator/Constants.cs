namespace Calculator;

public static class Constants
{
    public static readonly IEnumerable<string> Menu = new List<string>
    {
        "Select operation:",
        "1. Add",
        "2. Subtract",
        "3. Multiply",
        "4. Divide",
        "X. Exit"
    };

    public const string InvalidInputMessage = "Invalid input. Please try again.";
}