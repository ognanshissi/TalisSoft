using System;
using TalisSoft.Common.Domain.Entities;

namespace TalisSoft.Octopus.Domain.Entities
{
    public class Customer: Auditable
    {
        public string  Name { get; set; }
        public string Contact { get; set; }
    }
}