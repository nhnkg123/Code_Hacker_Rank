using Test.DecoratorPattern.practice;

namespace Test.DecoratePattern.practice
{
    public class SugarDecorator : CoffeeDecorator
    {
        public SugarDecorator(ICoffee coffee) : base(coffee)
        {

        }
        public override string GetDescription()
        {
            return base.GetDescription() + ", Sugar";
        }
        public override double GetCost()
        {
            return base.GetCost() + 0.5;
        }
    }
}