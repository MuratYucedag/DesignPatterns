using DesignPattern.CQRS.CQRSPattern.Queries;
using DesignPattern.CQRS.CQRSPattern.Results;
using DesignPattern.CQRS.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.CQRS.CQRSPattern.Handlers
{
    public class GetProductUpdateByIDQueryHandler
    {
        private readonly Context _context;
        public GetProductUpdateByIDQueryHandler(Context context)
        {
            _context = context;
        }
        public GetProductUpdateQueryResult Handle(GetProductUpdateByIDQuery query)
        {
            var values = _context.Products.Find(query.ID);
            return new GetProductUpdateQueryResult
            {
                Description = values.Description,
                Name = values.Name,
                Price = values.Price,
                Stock = values.Stock,
                ProductID = values.ProductID
            };
        }
    }
}
