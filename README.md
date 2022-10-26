# Generic Factory
## Generic version of my favorite factory pattern implementation

### Class Diagram

```mermaid
classDiagram
    Client --> Initializer
    Initializer --> AbstractFactory
    AbstractFactory <|-- ConcreteFactory
    AbstractFactory <|-- ConcreteFactory2
    
    Initializer : -Dictionary~IInputType, AbstractFactory~ _factories
    Initializer : +Initialize()$ Initializer
    Initializer : +Create(IInputType) IOutputType
    AbstractFactory : +Create()* IOutputType
    ConcreteFactory : +Create() IOutputType
    ConcreteFactory2 : +Create() IOutputType
```

### How to use
The "client" in this case is whatever class needs to convert from one type to another to call this factory implementation use 
```csharp 
Initializer.Initialize().Create(typeToConvert)
```
