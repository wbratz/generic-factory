namespace GenericFactory.Factories;

public abstract class AbstractFactory
{
    public abstract IOutputType Create(Dictionary<string, string> attributes, string primitive, PlaceholderObject placeholderObject);
}
