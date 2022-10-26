# Generic Factory
### Generic version of my favorite factory pattern implementation

```mermaid
classDiagram
    Client --> Initializer
    Initializer --> AbstractFactory
    AbstractFactory <|-- ConcreteFactory
    AbstractFactory <|-- ConcreateFactory2
    
    Initializer : -Dictionary~IInputType, AbstractFactory~ _factories
    Initializer : +Initialize()$
    Initializer : +Create()
    AbstractFactory : +Create()*
    ConcreteFactory : +Create() IOutputType
    ConcreteFactory2 : +Create() IOutputType
```
