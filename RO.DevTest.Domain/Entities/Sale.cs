    
using RO.DevTest.Domain.Abstract;

namespace RO.DevTest.Domain.Entities
{
    public class Sale : BaseEntity
    {
        public Guid CustomerId { get; set; }
        public required Customer Customer { get; set; }

        public DateTime Date { get; set; } = DateTime.UtcNow;

        public decimal TotalAmount { get; set; }

        public ICollection<SaleItem> Items { get; set; } = new List<SaleItem>();
    }
}
