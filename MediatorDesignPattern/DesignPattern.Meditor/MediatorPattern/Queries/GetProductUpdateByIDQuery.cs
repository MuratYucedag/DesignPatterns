using DesignPattern.Meditor.MediatorPattern.Results;
using MediatR;

namespace DesignPattern.Meditor.MediatorPattern.Queries
{
    public class GetProductUpdateByIDQuery:IRequest<UpdateProductByIDQueryResult>
    {
        public GetProductUpdateByIDQuery(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
    }
}
