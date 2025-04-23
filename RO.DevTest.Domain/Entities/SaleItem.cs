//Para vendas com múltiplos produtos
using System;
using RO.DevTest.Domain.Abstract;

namespace RO.DevTest.Domain.Entities
{
    public class SaleItem : BaseEntity
    {
        public Guid SaleId { get; set; }
        public Sale Sale { get; set; }

        public Guid ProductId { get; set; }
        public Product Product { get; set; }

        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }

        public decimal Total => Quantity * UnitPrice;
    }
}
