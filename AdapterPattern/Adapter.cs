using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.AdapterPattern
{
    public class Adapter: ITarget_IAdapter
    {
        private readonly Adaptee_ClientCanNotUse _adaptee_ClientCanNotUse;
        public Adapter(Adaptee_ClientCanNotUse adaptee)
        {
            this._adaptee_ClientCanNotUse = adaptee;
        }
        public string GetRequest()
        {
            return $"This is {this._adaptee_ClientCanNotUse.GetSpecificRequest()}";
        }
    }
}
