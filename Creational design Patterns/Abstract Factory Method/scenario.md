**Scenario Problem Statement:**

TechGadget, a leading electronics manufacturer, is expanding its product line to include smartwatches. They aim to maintain compatibility and consistency across their product line by implementing the Abstract Factory design pattern in their smartwatch manufacturing process.

**Description:**
TechGadget specializes in manufacturing electronic devices such as smartphones and tablets. They have decided to introduce smartwatches to their product lineup. However, they want to ensure that the smartwatches maintain the same level of quality and compatibility with their existing ecosystem of accessories and services.

To achieve this, TechGadget decides to implement the Abstract Factory design pattern. They create an abstract factory interface called `IDeviceFactory` that defines methods for creating various components of their electronic devices, such as screens and processors. Concrete factory classes like `SmartwatchFactory`, `SmartphoneFactory`, and `TabletFactory` are implemented to create device-specific components.

For example, the `SmartwatchFactory` class is responsible for creating smartwatch-specific components such as small screens, energy-efficient processors, compact batteries, and wearable operating systems.

By using the Abstract Factory pattern, TechGadget can easily extend their manufacturing process to include new types of electronic devices while maintaining compatibility and consistency across their product line.

**Objective:**
Design a UML diagram and Write code in c# illustrating the Abstract Factory pattern as implemented by TechGadget in their smartwatch manufacturing process. 