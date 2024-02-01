using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class Order
    {
        public int ClientCode { get; set; }
        public DateTime? Date { get; set; }
        public bool? Delivery { get; set; }
        public string? Description { get; set; }
        public int? OrderCode { get; set; }

        public virtual Client ClientCodeNavigation { get; set; } = null!;
    }
}
