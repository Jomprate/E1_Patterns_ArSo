using DecoratorPattern.Components;

namespace DecoratorPattern.Decorators
{
    // Concrete decorator: adds milk to the coffee
    public class MilkDecorator : CoffeeDecorator
    {
        public MilkDecorator(IComponent component) : base(component)
        {
        }

        public override string Description() => _component.Description() + ", with Milk";

        public override double Cost() => _component.Cost() + 0.5; // Adds the cost of milk
    }
}