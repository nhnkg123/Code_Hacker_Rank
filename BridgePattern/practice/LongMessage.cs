using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.BridgePattern.practice
{
    public class LongMessage: AbstractMessage
    {
        public LongMessage(IMessageSender messageSender)
        {
            this.messageSender = messageSender;
        }

        public override void SendMessage(string message)
        {
            messageSender.SendMessage(message);
        }
    }
}
