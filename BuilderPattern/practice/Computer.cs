using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.BuilderPattern.practice
{
    public class Computer
    {
        public string CPU { get; set; }
        public string RAM { get; set; }
        public string Storage { get; set; }
        public string GPU { get; set; }

        public string ListParts ()
        {
            return $"Computer [CPU={CPU}, RAM={RAM}, Storage={Storage}, GPU={GPU}]";
        }
    }
}
