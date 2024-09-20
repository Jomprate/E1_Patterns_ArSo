namespace DecoratorPattern.Components
{
    // Base interface for the coffee component
    public interface IComponent
    {
        string Description(); // Method to get the description of the coffee

        double Cost(); // Method to get the cost of the coffee
    }
}