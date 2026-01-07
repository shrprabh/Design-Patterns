# Design Patterns: Kid Simple, Interview Ready

This repo gives each pattern a kid-friendly story, a clear interview definition, and runnable examples in Python and C#.

## Quick start

Python (3.10+):

```
cd python
python main.py abstract_factory
python main.py all
```

C# (.NET 8):

```
dotnet run --project csharp -- abstract_factory
dotnet run --project csharp -- all
```

Pattern keys (use in both languages):

```
abstract_factory
adapter
builder
chain_of_responsibility
command
composite
decorator
facade
factory
iterator
mvc
mvp
mvvm
observer
prototype
singleton
state
strategy
template_method
```

## Abstract Factory
- Kid idea: Pick a themed room and you get matching chair and sofa.
- Interview definition: Create families of related objects without naming concrete classes.
- Use when: You want to swap an entire product family (modern vs. Victorian).
- Run (Python): `python main.py abstract_factory`
- Run (C#): `dotnet run --project csharp -- abstract_factory`
- Code: `python/patterns/abstract_factory.py` and `csharp/Patterns/AbstractFactory.cs`

## Adapter
- Kid idea: A plug adapter lets a square plug fit a round hole.
- Interview definition: Convert one interface into another clients expect.
- Use when: You must use a class with an incompatible interface.
- Run (Python): `python main.py adapter`
- Run (C#): `dotnet run --project csharp -- adapter`
- Code: `python/patterns/adapter.py` and `csharp/Patterns/Adapter.cs`

## Builder
- Kid idea: Build a sandwich step by step with different toppings.
- Interview definition: Separate construction of a complex object from its representation.
- Use when: Many optional parts and different configurations.
- Run (Python): `python main.py builder`
- Run (C#): `dotnet run --project csharp -- builder`
- Code: `python/patterns/builder.py` and `csharp/Patterns/Builder.cs`

## Chain of Responsibility
- Kid idea: If the robot cannot answer, it passes the question to a human, then to an expert.
- Interview definition: Pass a request along a chain until someone handles it.
- Use when: Multiple handlers might process a request.
- Run (Python): `python main.py chain_of_responsibility`
- Run (C#): `dotnet run --project csharp -- chain_of_responsibility`
- Code: `python/patterns/chain_of_responsibility.py` and `csharp/Patterns/ChainOfResponsibility.cs`

## Command
- Kid idea: A remote button is a note that says "turn on the light".
- Interview definition: Encapsulate a request as an object.
- Use when: You want to queue, log, or undo operations.
- Run (Python): `python main.py command`
- Run (C#): `dotnet run --project csharp -- command`
- Code: `python/patterns/command.py` and `csharp/Patterns/Command.cs`

## Composite
- Kid idea: A big toy box can hold toys or smaller boxes.
- Interview definition: Treat individual objects and compositions uniformly.
- Use when: You model tree structures.
- Run (Python): `python main.py composite`
- Run (C#): `dotnet run --project csharp -- composite`
- Code: `python/patterns/composite.py` and `csharp/Patterns/Composite.cs`

## Decorator
- Kid idea: Add sprinkles and a cherry without changing the ice cream.
- Interview definition: Add responsibilities to objects dynamically.
- Use when: Avoid subclass explosion for combinations of features.
- Run (Python): `python main.py decorator`
- Run (C#): `dotnet run --project csharp -- decorator`
- Code: `python/patterns/decorator.py` and `csharp/Patterns/Decorator.cs`

## Facade
- Kid idea: One button for movie night turns on everything.
- Interview definition: Provide a simple interface to a complex subsystem.
- Use when: You want a clean, easy API for messy internals.
- Run (Python): `python main.py facade`
- Run (C#): `dotnet run --project csharp -- facade`
- Code: `python/patterns/facade.py` and `csharp/Patterns/Facade.cs`

## Factory Method
- Kid idea: A delivery company decides whether to use a truck or ship.
- Interview definition: Define creation in a base class, let subclasses decide the concrete type.
- Use when: Base class should defer object creation.
- Run (Python): `python main.py factory`
- Run (C#): `dotnet run --project csharp -- factory`
- Code: `python/patterns/factory.py` and `csharp/Patterns/FactoryMethod.cs`

## Iterator
- Kid idea: Flip through songs one by one without opening the playlist box.
- Interview definition: Access elements sequentially without exposing internal structure.
- Use when: You want a standard loop over a custom collection.
- Run (Python): `python main.py iterator`
- Run (C#): `dotnet run --project csharp -- iterator`
- Code: `python/patterns/iterator.py` and `csharp/Patterns/Iterator.cs`

## Model View Controller (MVC)
- Kid idea: The controller presses the button, the model holds the number, the view shows it.
- Interview definition: Separate data, UI, and input handling.
- Use when: Classic UI separation of concerns.
- Run (Python): `python main.py mvc`
- Run (C#): `dotnet run --project csharp -- mvc`
- Code: `python/patterns/mvc.py` and `csharp/Patterns/Mvc.cs`

## Model View Presenter (MVP)
- Kid idea: The presenter is the coach telling the view what to show.
- Interview definition: View is passive; presenter handles input and updates the view.
- Use when: You want testable UI logic and a thin view.
- Run (Python): `python main.py mvp`
- Run (C#): `dotnet run --project csharp -- mvp`
- Code: `python/patterns/mvp.py` and `csharp/Patterns/Mvp.cs`

## Model View ViewModel (MVVM)
- Kid idea: The view listens to the viewmodel and shows whatever it says.
- Interview definition: View binds to viewmodel data and commands.
- Use when: Data binding frameworks or reactive UIs.
- Run (Python): `python main.py mvvm`
- Run (C#): `dotnet run --project csharp -- mvvm`
- Code: `python/patterns/mvvm.py` and `csharp/Patterns/Mvvm.cs`

## Observer
- Kid idea: Kids subscribe to ice cream truck alerts.
- Interview definition: Observers get notified when a subject changes.
- Use when: Publish-subscribe events and updates.
- Run (Python): `python main.py observer`
- Run (C#): `dotnet run --project csharp -- observer`
- Code: `python/patterns/observer.py` and `csharp/Patterns/Observer.cs`

## Prototype
- Kid idea: Copy your drawing and then color it differently.
- Interview definition: Create new objects by cloning an existing one.
- Use when: Construction is expensive and copies are needed.
- Run (Python): `python main.py prototype`
- Run (C#): `dotnet run --project csharp -- prototype`
- Code: `python/patterns/prototype.py` and `csharp/Patterns/Prototype.cs`

## Singleton
- Kid idea: Only one principal in the whole school.
- Interview definition: Ensure a class has a single instance with global access.
- Use when: Shared configuration or a single shared resource.
- Run (Python): `python main.py singleton`
- Run (C#): `dotnet run --project csharp -- singleton`
- Code: `python/patterns/singleton.py` and `csharp/Patterns/Singleton.cs`

## State
- Kid idea: The traffic light acts differently when it is red, yellow, or green.
- Interview definition: An object changes behavior when its internal state changes.
- Use when: Many conditional branches based on state.
- Run (Python): `python main.py state`
- Run (C#): `dotnet run --project csharp -- state`
- Code: `python/patterns/state.py` and `csharp/Patterns/State.cs`

## Strategy
- Kid idea: Choose how to pay: card or cash.
- Interview definition: Define a family of algorithms and make them interchangeable.
- Use when: You want to swap behavior at runtime.
- Run (Python): `python main.py strategy`
- Run (C#): `dotnet run --project csharp -- strategy`
- Code: `python/patterns/strategy.py` and `csharp/Patterns/Strategy.cs`

## Template Method
- Kid idea: A recipe has fixed steps, but ingredients can change.
- Interview definition: Define an algorithm skeleton and let subclasses fill steps.
- Use when: Common flow with variable steps.
- Run (Python): `python main.py template_method`
- Run (C#): `dotnet run --project csharp -- template_method`
- Code: `python/patterns/template_method.py` and `csharp/Patterns/TemplateMethod.cs`
