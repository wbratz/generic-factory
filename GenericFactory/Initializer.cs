namespace GenericFactory;

public sealed class Initializer
{
    private readonly Dictionary<Type, AbstractFactory> _factories;

    public Initializer()
    {
        _factories = new Dictionary<Type, AbstractFactory>
        {
            { typeof(FromType1), new ToType1Factory() }
        };
    }

    public static Initializer Init() => new();

    public IOutputType Create(IInputType inputType)
        => _factories[inputType.GetType()].Create(inputType.Attributes, inputType.PrimitiveValue, inputType.PlaceholderObject);
}
