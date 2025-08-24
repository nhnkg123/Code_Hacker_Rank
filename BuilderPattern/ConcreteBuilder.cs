using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.BuilderPattern
{
    public class ConcreteBuilder : IBuilder
    {
        public Product _product = new Product();
        public ConcreteBuilder() 
        {
            this.reset();
        }
        public void reset()
        {
            this._product = new Product();
        }
        public void BuildPartA()
        {
            this._product.Add("PartA1");
        }
        public void BuildPartB()
        {
            this._product.Add("PartB1");
        }
        public void BuildPartC()
        {
            this._product.Add("PartC1");
        }
        public Product getProduct()
        {
            Product result = this._product;
            this.reset();
            return result;
        }
    }
}
