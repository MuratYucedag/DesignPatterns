using DesignPattern.Decorator.DAL;
using System;

namespace DesignPattern.Decorator.DecoratorPattern2
{
    public class SubjectIDDecorator : Decorator
    {
        private readonly ISendMessage _sendMessage;
        Context context = new Context();
        public SubjectIDDecorator(ISendMessage sendMessage) : base(sendMessage)
        {
            _sendMessage = sendMessage;
        }
        public void SendMessageIDSubject(Message message)
        {
            if (message.MessageSubject == "1")
            {
                message.MessageSubject = "Toplantı";
            }
            if(message.MessageSubject == "2")
            {
                message.MessageSubject = "Scrum Toplantısı";
            }
            if(message.MessageSubject== "3")
            {
                message.MessageSubject = "Haftalık Değerlendirme";
            }
            context.Messages.Add(message);
            context.SaveChanges();
        }
        public override void SendMessage(Message message)
        {
            base.SendMessage(message);
            SendMessageIDSubject(message);
        }
    }
}
