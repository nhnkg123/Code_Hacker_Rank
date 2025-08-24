using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.FactoryMethodPattern.practice
{
    public abstract class DocumentCreator
    {
        public abstract Document CreateDocument(); 
        public string DoSomeOtherThingWithDocument()
        {
            return $"Do some other things beside [creating] : [{CreateDocument().Print()}]";
        }
    }
}
