namespace GenericFactory.Types;

public interface IInputType
{
    Dictionary<string, string> Attributes { get; }
    PlaceholderObject PlaceholderObject { get; }
    string PrimitiveValue { get; }
}
