using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.AdapterPattern.practice
{
    public class ThirdPartyEditor
    {
        public void DrawText(string text)
        {
            Console.WriteLine($"Drawing text: {text}");
        }
    }
}
