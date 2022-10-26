namespace GenericFactory.Factories;

public sealed class ToType1Factory : AbstractFactory
{
    public override IOutputType Create(Dictionary<string, string> attributes, string primitive, PlaceholderObject placeholderObject)
        => new ToType1(attributes, placeholderObject, primitive);
}
