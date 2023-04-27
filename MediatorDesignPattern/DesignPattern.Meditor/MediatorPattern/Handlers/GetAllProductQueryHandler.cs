using DesignPattern.Meditor.DAL;
using DesignPattern.Meditor.MediatorPattern.Queries;
using DesignPattern.Meditor.MediatorPattern.Results;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace DesignPattern.Meditor.MediatorPattern.Handlers
{
    public class GetAllProductQueryHandler : IRequestHandler<GetlAllProductQuery, List<GelAllProductQueryResult>>
    {
        private readonly Context _context;

        public GetAllProductQueryHandler(Context context)
        {
            _context = context;
        }

        public async Task<List<GelAllProductQueryResult>> Handle(GetlAllProductQuery request, CancellationToken cancellationToken)
        {
            return await _context.Products.Select(x => new GelAllProductQueryResult
            {
                ProductID = x.ProductID,
                ProductName = x.ProductName,
                ProductCategory = x.ProductCategory,
                ProductPrice = x.ProductPrice,
                ProductStock = x.ProductStock,
                ProductStockType = x.ProductStockType
            }).AsNoTracking().ToListAsync();
        }
    }
}
