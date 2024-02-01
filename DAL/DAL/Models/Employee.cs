using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class Employee
    {
        public int EmployeeId { get; set; }
        public int? NumOfOrders { get; set; }
        public string? Name { get; set; }
    }
}
