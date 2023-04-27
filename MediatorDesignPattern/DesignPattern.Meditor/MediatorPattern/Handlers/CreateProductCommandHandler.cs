using DesignPattern.Meditor.DAL;
using DesignPattern.Meditor.MediatorPattern.Commands;
using MediatR;

namespace DesignPattern.Meditor.MediatorPattern.Handlers
{
    public class CreateProductCommandHandler : IRequestHandler<CreateProductCommand>
    {
        private readonly Context _context;

        public CreateProductCommandHandler(Context context)
        {
            _context = context;
        }

        public async Task Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            _context.Products.Add(new Product
            {
                ProductName = request.ProductName,
                ProductCategory = request.ProductCategory,
                ProductPrice = request.ProductPrice,
                ProductStock = request.ProductStock,
                ProductStockType = request.ProductStockType
            });
            await _context.SaveChangesAsync();
        }
    }
}
