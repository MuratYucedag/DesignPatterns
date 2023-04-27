using DesignPattern.Meditor.MediatorPattern.Results;
using MediatR;

namespace DesignPattern.Meditor.MediatorPattern.Queries
{
    public class GetlAllProductQuery : IRequest<List<GelAllProductQueryResult>>
    {
    }
}
