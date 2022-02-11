using StrategyPattern.Library;
using StrategyPattern.UserInterface;
// Метод Main() является контекстом, так как он выступает клиентом стратегии.
IUserInterface UserInterface;
if (args[0] == "console")
{
    UserInterface = new ConsoleInterface();
}
else
{
    UserInterface = new WebInterface();
}

string userInput = "";
UserInterface.WriteMessage("Hello, dear user!");
UserInterface.WriteWarning("Enter \"exit\" to finish the programme");
while (userInput != "exit")
{
    UserInterface.WriteMessage("Write something. The programme will write what you enter: ");
    userInput = UserInterface.ReadMessage();
    UserInterface.WriteMessage(userInput);
    UserInterface.WriteWarning(userInput);
    UserInterface.WriteError(userInput);
}