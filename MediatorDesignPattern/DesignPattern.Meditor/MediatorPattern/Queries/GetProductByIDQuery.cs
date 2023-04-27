using DesignPattern.Meditor.MediatorPattern.Results;
using MediatR;

namespace DesignPattern.Meditor.MediatorPattern.Queries
{
    public class GetProductByIDQuery:IRequest<GetProductByIDQueryResult>
    {
        public GetProductByIDQuery(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
    }
}
