using DecoratorPatternDotNET;

StandartMessage StandartMessage = new StandartMessage();
ErrorMessage ErrorMessage = new ErrorMessage(StandartMessage);
SuccessMessage SuccessMessage = new SuccessMessage(StandartMessage);

IMessage message = StandartMessage;
message.Write("Standart message");

message = ErrorMessage;
message.Write("Error message");

message = SuccessMessage;
message.Write("Success message");