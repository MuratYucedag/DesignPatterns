using DesignPattern.Decorator.DAL;

namespace DesignPattern.Decorator.DecoratorPattern
{
    public class Decorator : INotifier
    {
        private readonly INotifier _notifier;
        public Decorator(INotifier notifier)
        {
            _notifier = notifier;
        }
        virtual public void CreateNotify(Notifier notifier)
        {
            notifier.NotifierCreator = "Admin";
            notifier.NotifierSubject = "Toplantı";
            notifier.NotifierType = "Public";
            notifier.NotifierChannel = "Whatsapp";
            _notifier.CreateNotify(notifier);
        }
    }
}
