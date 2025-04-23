using System;
using System.Collections.Generic;
using RO.DevTest.Domain.Abstract;

namespace RO.DevTest.Domain.Entities
{
    public class Customer : BaseEntity
    {
        public required string Name { get; set; }
        public required string Email { get; set; }

        public ICollection<Sale> Sales { get; set; } = new List<Sale>();
    }
}
