using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.AdapterPattern.practice
{
    public class EditorAdapter: TextEditor
    {
        private readonly ThirdPartyEditor _thirdPartyEditor;
        public EditorAdapter(ThirdPartyEditor thirdPartyEditor)
        {
            _thirdPartyEditor = thirdPartyEditor;
        }
        public override void DisplayText(string text)
        {
            _thirdPartyEditor.DrawText($"Displaying text: {text}");
        }
    }
}
