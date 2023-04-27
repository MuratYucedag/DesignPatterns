using DesignPattern.Decorator.DAL;

namespace DesignPattern.Decorator.DecoratorPattern
{
    public class MailDecorator : Decorator
    {
        private readonly INotifier _notifier;
        Context context = new Context();
        public MailDecorator(INotifier notifier) : base(notifier)
        {
            _notifier = notifier;
        }
        public void SendMailNotify(Notifier notifier)
        {
            notifier.NotifierSubject = "Günlük Sabah Toplantısı";
            notifier.NotifierCreator = "Scrum Master";
            notifier.NotifierChannel = "GMail-Outlook";
            notifier.NotifierType = "Private Team";
            context.Notifiers.Add(notifier);
            context.SaveChanges();
        }
        public override void CreateNotify(Notifier notifier)
        {
            base.CreateNotify(notifier);
            SendMailNotify(notifier);
        }
    }
}
