using Test.DecoratorPattern.practice;

namespace Test.DecoratePattern.practice
{
    public abstract class CoffeeDecorator : ICoffee
    {
        protected ICoffee _coffee;
        public CoffeeDecorator(ICoffee coffee)
        {
            this._coffee = coffee;
        }
        public virtual string GetDescription()
        {
            return _coffee.GetDescription();
        }
        public virtual double GetCost()
        {
            return _coffee.GetCost();
        }
    }
}