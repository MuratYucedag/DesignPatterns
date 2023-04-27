﻿using MediatR;

namespace DesignPattern.Meditor.MediatorPattern.Commands
{
    public class CreateProductCommand:IRequest
    {
        public string ProductName { get; set; }
        public int ProductStock { get; set; }
        public string ProductStockType { get; set; }
        public decimal ProductPrice { get; set; }
        public string ProductCategory { get; set; }
    }
}
