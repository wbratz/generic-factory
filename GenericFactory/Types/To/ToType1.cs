namespace GenericFactory.Types.To;

public sealed class ToType1 : IOutputType
{
    public Dictionary<string, string> Attributes { get; }

    public PlaceholderObject PlaceholderObject { get; }

    public string PrimitiveValue { get; }

    public ToType1(Dictionary<string, string> attributes, PlaceholderObject placeholderObject, string primitiveValue)
    {
        Attributes = attributes;
        PlaceholderObject = placeholderObject;
        PrimitiveValue = primitiveValue;
    }

    public void Output()
        => Console.WriteLine($"There are {Attributes.Count} attributes, The primitive value is: {PrimitiveValue}, and PlaceholderObject is {(PlaceholderObject != null ? "not NULL" : "NULL")}");
}
