using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.AbstractFactoryPattern.practice
{
    public class ClientMethodPractice
    {
        public void _ClientMethodPractice(IAbstractFactory factory) 
        {
            IAbstractChair Chair = factory.CreateChair();
            IAbstractSofa Sofa = factory.CreateSofa();
            IAbstractCoffeeTable coffeeTable = factory.CreateCoffeeTable();


            Console.WriteLine(Chair.Have4Legs());
            Console.WriteLine(Chair.SitOn());
            Console.WriteLine(Sofa.Have4Legs());
            Console.WriteLine(Sofa.SitOn());
            Console.WriteLine(coffeeTable.Have4Legs());
            Console.WriteLine(coffeeTable.SitOn());
        }
    }
}
