using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.AbstractFactoryPattern.practice
{
    public class VictorianFactory: IAbstractFactory
    {
        public IAbstractChair CreateChair()
        {
            return new VictorianChair();
        }
        public IAbstractCoffeeTable CreateCoffeeTable()
        {
            return new VictorianCoffeeTable();
        }
        public IAbstractSofa CreateSofa()
        {
            return new VictorianSofa();
        }
    }
}
