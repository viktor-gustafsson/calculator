namespace Calculator;

public class Calc
{
    public OperationResult Add(int a, int b)
    {
        var operationResult = new OperationResult
        {
            Message = string.Empty,
            Result = a + b,
            Success = true
        };
        return operationResult;
    }

    public OperationResult Subtract(int a, int b)
    {
        var operationResult = new OperationResult
        {
            Message = string.Empty,
            Result = a - b,
            Success = true
        };

        return operationResult;
    }

    public OperationResult Multiply(int a, int b)
    {
        var operationResult = new OperationResult
        {
            Message = string.Empty,
            Result = a * b,
            Success = true
        };

        return operationResult;
    }

    public OperationResult Divide(int a, int b)
    {
        var operationresult = new OperationResult
        {
            Message = string.Empty,
            Result = 0,
            Success = true
        };

        if(a == 0 || b == 0)
        {
            var operationResult = new OperationResult
            {
                Message = "Cannot divide by zero",
                Success = false
            };
            return operationResult;
        }

        operationresult.Result = a / b;
        return operationresult;
    }
}
    