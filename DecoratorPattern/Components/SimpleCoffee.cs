namespace DecoratorPattern.Components
{
    // Concrete component: simple coffee
    public class SimpleCoffee : IComponent
    {
        public string Description() => "Simple Coffee";

        public double Cost() => 2.0; // Base price for the coffee
    }
}