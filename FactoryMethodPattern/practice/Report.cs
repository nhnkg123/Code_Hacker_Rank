using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.FactoryMethodPattern.practice
{
    public class Report: Document
    {
        public override string Print()
        {
            return "Printing Report Document...";
        }
    }
}
