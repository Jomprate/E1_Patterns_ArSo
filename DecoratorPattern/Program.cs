using DecoratorPattern.Components;
using DecoratorPattern.Decorators;

namespace DecoratorPattern
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // We start with a simple coffee
            IComponent coffee = new SimpleCoffee();
            Console.WriteLine($"{coffee.Description()} - ${coffee.Cost()}");

            // Now we decorate the coffee by adding milk
            coffee = new MilkDecorator(coffee);
            Console.WriteLine($"{coffee.Description()} - ${coffee.Cost()}");

            // Finally, we add sugar to the coffee
            coffee = new SugarDecorator(coffee);
            Console.WriteLine($"{coffee.Description()} - ${coffee.Cost()}");

            // This demonstrates how we can dynamically add functionalities (decorations) to our base object.
            Console.ReadLine();
        }
    }
}