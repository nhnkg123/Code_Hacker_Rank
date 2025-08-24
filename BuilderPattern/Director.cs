using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.BuilderPattern
{
    public class Director
    {
        private IBuilder _builder;
        public void setBuilder (IBuilder builder)
        {
            this._builder = builder;
        }
        public void buidMinimalViableProduct()
        {
            this._builder.BuildPartA();
        }
        public void BuildFullFeaturedProduct()
        {
            this._builder.BuildPartA();
            this._builder.BuildPartB();
            this._builder.BuildPartC();
        }
    }
}
