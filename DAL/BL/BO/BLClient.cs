﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.BO
{
    public class BLClient
    {
        public int ClientId { get; set; }
        public string? Name { get; set; }
        public string? PhoneNumber { get; set; }
        public int? Age { get; set; }
        public DateTime firstMeeting { get; set; }
    }
}
