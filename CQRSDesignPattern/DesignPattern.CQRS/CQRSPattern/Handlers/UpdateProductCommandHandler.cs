using DesignPattern.CQRS.CQRSPattern.Commands;
using DesignPattern.CQRS.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.CQRS.CQRSPattern.Handlers
{
    public class UpdateProductCommandHandler
    {
        private readonly Context _context;
        public UpdateProductCommandHandler(Context context)
        {
            _context = context;
        }
        public void Handle(UpdateProductCommand command)
        {
            var values = _context.Products.Find(command.ProductID);
            values.Name = command.Name;
            values.Price = command.Price;
            values.Status = true;
            values.Stock = command.Stock;
            values.Description = command.Description;
            _context.SaveChanges();
        }
    }
}
