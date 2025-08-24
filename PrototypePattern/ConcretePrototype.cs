using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.PrototypePattern
{
    public class ConcretePrototype: IPrototypeShape
    {
        protected string field1 { get; set; } 
        public ConcretePrototype(string field)
        {
            this.field1 = field;
        }
        public ConcretePrototype(ConcretePrototype prototype)
        {
            this.field1 = prototype.field1;
        }
        public string getField()
        {
            return this.field1;
        }
        public void setField(string newField)
        {
            this.field1 = newField;
        }
        public IPrototypeShape clone ()
        {
            return new ConcretePrototype(this);
        }
    }
}
