namespace Calculator;

public class ConsoleHandler
{
    public void WriteMessage(string message)
    {
        Console.WriteLine(message);
    }

    public void WriteMessages(IEnumerable<string> messages)
    {
        foreach (var message in messages)
        {
            Console.WriteLine(message);
        }
    }

    public void WriteSumAndWait(OperationResult operationResult)
    {
        Console.WriteLine($"Sum: {operationResult.Result}");
        Console.ReadKey();
    }

    public string GetString()
    {
        var input = Console.ReadLine();
        return input;
    }

    public OperationResult GetStringAsInt()
    {
        var input = Console.ReadLine();
        var couldParseInt = int.TryParse(input, out var parsedInt);
        if (!couldParseInt)
        {
            return new OperationResult
            {
                Message = Constants.InvalidInputMessage,
                Success = false
            };
        }

        return new OperationResult
        {
            Success = true,
            Result = parsedInt
        };
    }
}