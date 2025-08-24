using Test.DecoratePattern.practice;

namespace Test.DecoratorPattern.practice
{
    public class ClientCodeDecoratorPatternPractice
    {
        public void _clientCode()
        {
            //Order single coffee
            ICoffee myCoffee = new SimpleCoffee();
            Console.WriteLine($"{myCoffee.GetDescription()} - {myCoffee.GetCost()}");

            //Add milk to the coffee
            myCoffee = new MilkDecorator(myCoffee);
            Console.WriteLine($"{myCoffee.GetDescription()} - {myCoffee.GetCost()}");

            //Add milk to the coffee
            myCoffee = new SugarDecorator(myCoffee);
            Console.WriteLine($"{myCoffee.GetDescription()} - {myCoffee.GetCost()}");

            //Add another shot of milk 
            myCoffee = new MilkDecorator(myCoffee);
            Console.WriteLine($"{myCoffee.GetDescription()} - {myCoffee.GetCost()}");
        }
    }
}