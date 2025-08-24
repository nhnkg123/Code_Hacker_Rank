using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.AdapterPattern
{
    public class Adaptee_ClientCanNotUse
    {
        public string GetSpecificRequest()
        {
            return "Specific request. (at first, client can not call this method)";
        }
    }
}
