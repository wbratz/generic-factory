# Generic Factory
### Generic version of my favorite factory pattern implementation

```mermaid
classDiagram
    Client --> Initializer
    Initializer --> AbstractFactory
    AbstractFactory <|-- ConcreteFactory
    
    AbstractFactory : +Create()
```
