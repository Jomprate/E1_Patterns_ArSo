using DecoratorPattern.Components;

namespace DecoratorPattern.Decorators
{
    // Concrete decorator: adds sugar to the coffee
    public class SugarDecorator : CoffeeDecorator
    {
        public SugarDecorator(IComponent component) : base(component)
        {
        }

        public override string Description() => _component.Description() + ", with Sugar";

        public override double Cost() => _component.Cost() + 0.2; // Adds the cost of sugar
    }
}