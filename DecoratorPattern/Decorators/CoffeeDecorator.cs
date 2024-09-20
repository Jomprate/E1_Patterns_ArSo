using DecoratorPattern.Components;

namespace DecoratorPattern.Decorators
{
    // Abstract decorator class that implements the IComponent interface
    public abstract class CoffeeDecorator : IComponent
    {
        protected IComponent _component;

        public CoffeeDecorator(IComponent component)
        {
            _component = component;
        }

        public virtual string Description() => _component.Description();

        public virtual double Cost() => _component.Cost();
    }
}