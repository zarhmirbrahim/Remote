using System;

namespace Remote.Managers
{
    public class MessageInfo
    {
        public readonly Guid Sender;
        public readonly string Message;
       
        public MessageInfo(Guid sender, string message)
        {
            Sender = sender;
            Message = message;
        }
    }
}
