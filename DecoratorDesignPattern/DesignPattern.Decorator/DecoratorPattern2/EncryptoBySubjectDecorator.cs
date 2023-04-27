using DesignPattern.Decorator.DAL;
using System;

namespace DesignPattern.Decorator.DecoratorPattern2
{
    public class EncryptoBySubjectDecorator:Decorator
    {
        private readonly ISendMessage _sendMessage;
        Context context = new Context();
        public EncryptoBySubjectDecorator(ISendMessage sendMessage) : base(sendMessage)
        {
            _sendMessage = sendMessage;
        }
        public void SendMessageByEncryptoSubject(Message message)
        {
            string data = "";
            data = message.MessageSubject;
            char[] chars = data.ToCharArray();
            foreach (var item in chars)
            {
                message.MessageSubject += Convert.ToChar(item + 3).ToString();
            }
            context.Messages.Add(message);
            context.SaveChanges();
        }
        public override void SendMessage(Message message)
        {
            base.SendMessage(message);
            SendMessageByEncryptoSubject(message);
        }
    }
}
//A B C D E
//D E F ...