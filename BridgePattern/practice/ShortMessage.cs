using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.BridgePattern.practice
{
    public class ShortMessage: AbstractMessage
    {
        public ShortMessage(IMessageSender messageSender) {
            this.messageSender = messageSender;
        }

        public override void SendMessage (string message)
        {
            if (message.Length <= 10)
            {
                messageSender.SendMessage(message);
            }
            else
            {
                Console.WriteLine("Unable to send the message as length > 10 characters");
            }    
        }
    }
}
