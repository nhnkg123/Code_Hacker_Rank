using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.AdapterPattern.practice
{
    public class clientCode_Adapter_Practice
    {
        public void _clientCode_Adapter_Practice()
        {
            // Your application expects a TextEditor interface

            // Integrating the third-party editor using the adapter
            ThirdPartyEditor thirdPartyEditor = new ThirdPartyEditor();
            TextEditor adapter = new EditorAdapter(thirdPartyEditor);
            adapter.DisplayText("The result call drawingText through adapter because it only have displayText interface");
        }
    }
}
