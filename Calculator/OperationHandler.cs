namespace Calculator;

public class OperationHandler
{
    readonly Calc _calc = new Calc();
    readonly ConsoleHandler _consoleHandler = new ConsoleHandler();

    public OperationResult PerformAdd()
    {
        var (additionOne, additionTwo) = GetUserNumberInput();
        CheckOperationResults(additionOne, additionTwo);
        var addResult = _calc.Add(additionOne.Result, additionTwo.Result);
        return addResult;
    }
    public OperationResult PerformSubtract()
    {
        var (subtractOne, subtractTwo) = GetUserNumberInput();
        CheckOperationResults(subtractOne, subtractTwo);
        var subtractResult = _calc.Subtract(subtractOne.Result, subtractTwo.Result);
        return subtractResult;
    }
    public OperationResult PerformMultiply()
    {
        var (multiplyOne, multiplyTwo) = GetUserNumberInput();
        CheckOperationResults(multiplyOne, multiplyTwo);
        var multiplicationResult = _calc.Multiply(multiplyOne.Result, multiplyTwo.Result);
        return multiplicationResult;
    }
    public OperationResult PerformDivide()
    {
        var (divideOne, divideTwo) = GetUserNumberInput();
        CheckOperationResults(divideOne, divideTwo);
        var divisionResult = _calc.Divide(divideOne.Result, divideTwo.Result);
        return divisionResult;
    }

    private (OperationResult inputOne,OperationResult inputTwo) GetUserNumberInput()
    {
        _consoleHandler.WriteMessage("Please enter the first number");
        var inputResultOne = _consoleHandler.GetStringAsInt();
        _consoleHandler.WriteMessage("Please enter the second number");
        var inputResultTwo = _consoleHandler.GetStringAsInt();

        return (inputResultOne, inputResultTwo);
    }

    void CheckOperationResults(OperationResult operationResultOne, OperationResult operationResultTwo)
    {
        if(!operationResultOne.Success || !operationResultTwo.Success)
        {
            _consoleHandler.WriteMessages(new List<string>
            {
                operationResultOne.Message,
                operationResultTwo.Message
            });
        }
    }
}