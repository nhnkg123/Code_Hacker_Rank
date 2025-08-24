using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.BridgePattern.practice
{
    public class ClientCode_Bridge_Practice
    {
        public void _ClientCode_Bridge_Practice ()
        {
            Console.WriteLine("Select the massage type 1. For long message or 2. For short message");
            int MessageType = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the message that you want to send");
            string Message  = Console.ReadLine();  
            
            if (MessageType == 1)
            {
                AbstractMessage longMessage = new LongMessage(new EmailMessageSender());
                longMessage.SendMessage(Message);
            } else
            {
                AbstractMessage shortMessage = new ShortMessage(new SmsMessageSender());
                shortMessage.SendMessage(Message);
            }
        } 
    }
}
