using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.AbstractFactoryPattern.practice
{
    public interface IAbstractFactory
    {
        IAbstractChair CreateChair();
        IAbstractCoffeeTable CreateCoffeeTable();
        IAbstractSofa CreateSofa();
    }
}
