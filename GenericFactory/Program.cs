var fromType = new FromType1(new Dictionary<string, string> { { "value1", "1" } }, "This is a string", new PlaceholderObject());

var newType = Initializer.Init().Create(fromType);

Console.WriteLine($"Original Type is of type: {fromType.GetType().Name}");
Console.WriteLine($"New type is of type: {newType.GetType().Name}");
newType.Output();
