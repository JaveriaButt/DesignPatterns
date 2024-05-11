Scenario
    Imagine you are working on a coffee shop application where customers can order different types of coffee with optional add-ons such as milk and sugar. You want to implement this functionality using the Decorator design pattern to allow for flexible customization of coffee orders.

Step-by-Step Implementation:

Define the Coffee Interface:

Create an interface named ICoffee with methods GetDescription() and GetCost() to represent different types of coffee.
Implement the Base Coffee Class:

Create a class PlainCoffee that implements the ICoffee interface.
Implement the GetDescription() method to return "Plain Coffee" and the GetCost() method to return the base cost of plain coffee.
Create the Coffee Decorator Abstract Class:

Define an abstract class CoffeeDecorator that implements the ICoffee interface.
Include a protected field decoratedCoffee of type ICoffee to hold the decorated coffee object.
Implement the GetDescription() and GetCost() methods to delegate to the decorated coffee object.
Implement Concrete Coffee Decorators:

Create concrete decorator classes such as MilkDecorator and SugarDecorator that extend the CoffeeDecorator class.
Override the GetDescription() method to append the decorator's description to the decorated coffee's description and the GetCost() method to add the cost of the decorator to the decorated coffee's cost.
Client Code:

In the Main method, create instances of coffee objects and decorate them with various decorators.
Print the description and cost of each coffee order.