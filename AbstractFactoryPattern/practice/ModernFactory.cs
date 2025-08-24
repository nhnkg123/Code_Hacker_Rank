using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.AbstractFactoryPattern.practice
{
    public class ModernFactory: IAbstractFactory
    {
        public IAbstractChair CreateChair()
        {
            return new ModernChair();
        }
        public IAbstractCoffeeTable CreateCoffeeTable()
        {
            return new ModernCoffeeTable();
        }
        public IAbstractSofa CreateSofa()
        {
            return new ModernSofa();
        }
    }
}
