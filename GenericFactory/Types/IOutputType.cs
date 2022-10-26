namespace GenericFactory.Types;

public interface IOutputType
{
    Dictionary<string, string> Attributes { get; }
    PlaceholderObject PlaceholderObject { get; }
    string PrimitiveValue { get; }

    public void Output();
}
