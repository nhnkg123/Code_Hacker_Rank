using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.FactoryMethodPattern.practice
{
    public class InvoiceCreator: DocumentCreator
    {
        public override Document CreateDocument()
        {
            return new Invoice();
        }
    }
}
