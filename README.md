# Generic Factory
### Generic version of my favorite factory pattern implementation

```mermaid
classDiagram
    Client --> Initializer
    Initializer --> AbstractFactory
    AbstractFactory <|-- ConcreteFactory
    
    Initializer : +Initialize()$
    Initializer : +Create()
    AbstractFactory : +Create()*
    ConcreteFactory : +Create() OutputType
```
