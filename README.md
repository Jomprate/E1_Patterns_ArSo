
# Design Patterns: Multiton & Decorator

## 📋 Overview

This repository contains practical implementations of two design patterns:

1. **Multiton Pattern (Creational)**
2. **Decorator Pattern (Structural)**

These patterns are widely used to solve different structural and creational problems in software development. The implementations provided here are designed to be easy to understand and demonstrate the core concepts of each pattern.

---

## 🧩 Multiton Pattern (Creational)

The **Multiton Pattern** ensures that a class has multiple controlled instances but only one instance per unique key. This is especially useful when you need to manage several instances of a class, but you want each instance to be identified by a unique key.

### 🔨 Implementation Details
In this implementation, a dictionary is used to store instances of the `MultitonManager` class. Each key corresponds to a unique instance. If the key is already present in the dictionary, the existing instance is returned; otherwise, a new instance is created.

### 📝 Code Example:
\`\`\`csharp
var instanceA = MultitonManager.GetInstance("A");
var instanceB = MultitonManager.GetInstance("B");
var instanceA2 = MultitonManager.GetInstance("A");

// 'instanceA' and 'instanceA2' will be the same instance, but 'instanceB' is different.
\`\`\`

### 💻 How to Run
1. Navigate to the **MultitonPattern** directory:
    \`\`\`bash
    cd MultitonPattern
    \`\`\`
2. Run the application to see how instances are controlled by keys.

---

## 🎨 Decorator Pattern (Structural)

The **Decorator Pattern** allows behavior to be added to individual objects dynamically without modifying the behavior of other objects from the same class. It provides a flexible alternative to subclassing for extending functionality.

### 🔨 Implementation Details
We start with a basic component, `SimpleCoffee`, which represents a plain coffee. We then create decorators such as `MilkDecorator` and `SugarDecorator` that add extra features (milk, sugar) to the base object. Each decorator wraps the original component and adds its behavior without altering the structure of the base class.

### 📝 Code Example:
\`\`\`csharp
IComponent coffee = new SimpleCoffee();
coffee = new MilkDecorator(coffee);   // Add milk
coffee = new SugarDecorator(coffee);  // Add sugar

Console.WriteLine($"\{coffee.Description()} - $\{coffee.Cost()}");
// The final coffee has milk and sugar, and the description and cost reflect these additions.
\`\`\`

### 💻 How to Run
1. Navigate to the **DecoratorPattern** directory:
    \`\`\`bash
    cd DecoratorPattern
    \`\`\`
2. Run the application to see how functionality is added dynamically to the base object.

---

## 📂 Project Structure

This repository is organized into two main directories, each containing a specific design pattern example.

### 🗂 Multiton Pattern
\`\`\`
/MultitonPattern
    /Models
        MultitonManager.cs
    Program.cs
\`\`\`

### 🗂 Decorator Pattern
\`\`\`
/DecoratorPattern
    /Components
        IComponent.cs
        SimpleCoffee.cs
    /Decorators
        CoffeeDecorator.cs
        MilkDecorator.cs
        SugarDecorator.cs
    Program.cs
\`\`\`

---

## 🚀 How to Get Started

### Prerequisites
- .NET SDK installed
- Visual Studio 2022 or any compatible IDE

### Steps to Run:
1. **Clone** the repository:
   \`\`\`bash
   git clone https://github.com/Jomprate/E1_Patterns_ArSo.git
   \`\`\`
2. **Open** the solution in Visual Studio or your favorite IDE.
3. **Navigate** to the folder of the pattern you'd like to run:
    - For **Multiton**, navigate to `/MultitonPattern`
    - For **Decorator**, navigate to `/DecoratorPattern`
4. **Run** the applications to see the patterns in action.

---

## 🧠 Concepts Explained

### Multiton Pattern
- Controls multiple instances but ensures only one instance per unique key.
- Useful for managing configurations, connections, or similar objects based on a key.

### Decorator Pattern
- Dynamically adds behavior to an object without modifying its structure.
- Promotes flexibility by combining behaviors through decorators.
- Useful when you need to extend functionality without altering existing code.

---

## 📚 References

- [Multiton Pattern - Wikipedia](https://en.wikipedia.org/wiki/Multiton_pattern)
- [Decorator Pattern - Wikipedia](https://en.wikipedia.org/wiki/Decorator_pattern)

---

## 🤝 Contributions

Feel free to fork this repository, submit issues, and make pull requests to improve the code or provide alternative pattern implementations!

---

## 📄 License

This repository is licensed under the MIT License. See the `LICENSE` file for more details.

---

## 👨‍💻 Author

- **SSDevop** - [GitHub Profile](https://github.com/Jomprate)
