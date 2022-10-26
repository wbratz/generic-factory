namespace GenericFactory.Types.From;

public sealed class FromType1 : IInputType
{
    public Dictionary<string, string> Attributes { get; }
    public string PrimitiveValue { get; }
    public PlaceholderObject PlaceholderObject { get; }

    public FromType1(Dictionary<string, string> attributes, string primitiveValue, PlaceholderObject placeholderObject)
    {
        Attributes = attributes;
        PrimitiveValue = primitiveValue;
        PlaceholderObject = placeholderObject;
    }
}
