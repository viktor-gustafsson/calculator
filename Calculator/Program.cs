using Calculator;

var keepGoing = true;
var consoleHandler = new ConsoleHandler();
var operationHandler = new OperationHandler();

do
{
    consoleHandler.WriteMessages(Constants.Menu);
    var userSelection = consoleHandler.GetString();
    switch (userSelection.ToLower())
    {
        case "1":
            var addResult = operationHandler.PerformAdd();
            if(!addResult.Success)
            {
                consoleHandler.WriteMessage(addResult.Message);
                break;
            }

            consoleHandler.WriteSumAndWait(addResult);
            break;

        case "2":
            var subtractResult = operationHandler.PerformSubtract();
            if(!subtractResult.Success)
            {
                consoleHandler.WriteMessage(subtractResult.Message);
                break;
            }

            consoleHandler.WriteSumAndWait(subtractResult);
            break;

        case "3":
            var multiplicationResult = operationHandler.PerformMultiply();
            if(!multiplicationResult.Success)
            {
                consoleHandler.WriteMessage(multiplicationResult.Message);
                break;
            }

            consoleHandler.WriteSumAndWait(multiplicationResult);
            break;

        case "4":
            var divisionResult = operationHandler.PerformDivide();
            if(!divisionResult.Success)
            {
                consoleHandler.WriteMessage(divisionResult.Message);
                break;
            }

            consoleHandler.WriteSumAndWait(divisionResult);
            break;

        case "x":
            keepGoing = false;
            break;

        default:
            consoleHandler.WriteMessage(Constants.InvalidInputMessage);
            break;
    }
}
while (keepGoing);



