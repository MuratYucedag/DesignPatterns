using MediatR;

namespace DesignPattern.Meditor.MediatorPattern.Commands
{
    public class RemoveProductCommand:IRequest
    {
        public RemoveProductCommand(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
    }
}
