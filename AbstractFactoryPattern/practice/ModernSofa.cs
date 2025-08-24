using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.AbstractFactoryPattern.practice
{
    public class ModernSofa: IAbstractSofa
    {
        public string Have4Legs()
        {
            return "A Modern Sofa have 4 legs";
        }
        public string SitOn()
        {
            return "Absolutelly we can sit on a Modern Sofa";
        }
    }
}
