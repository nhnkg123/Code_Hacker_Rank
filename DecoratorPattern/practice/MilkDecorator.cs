using Test.DecoratorPattern.practice;

namespace Test.DecoratePattern.practice
{
    public class MilkDecorator : CoffeeDecorator
    {
        public MilkDecorator(ICoffee coffee) : base(coffee)
        {

        }
        public override string GetDescription()
        {
            return base.GetDescription() + ", Milk";
        }
        public override double GetCost()
        {
            return base.GetCost() + 1.5;
        }
    }
}