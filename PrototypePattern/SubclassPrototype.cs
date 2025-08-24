using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.PrototypePattern
{
    public class SubclassPrototype: ConcretePrototype
    {
        private string field2 { get; set; }
        public SubclassPrototype (SubclassPrototype subClassPrototype): base(subClassPrototype)
        {
            this.field2 = subClassPrototype.field2;
        }
        public IPrototypeShape clone()
        {
            return new SubclassPrototype(this);
        }
    }
}
