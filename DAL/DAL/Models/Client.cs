using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class Client
    {
        public int ClientId { get; set; }
        public string? Name { get; set; }
        public string? PhoneNumber { get; set; }
        public int? ClientCode { get; set; }

        public virtual Order? Order { get; set; }
    }
}
