﻿using System;
using System.Collections.Generic;

namespace Reto2eSge_3__.Core.Entities.DbViews
{
    public partial class SalesTotalsByAmount
    {
        public decimal? SaleAmount { get; set; }
        public int OrderId { get; set; }
        public string CompanyName { get; set; } = null!;
        public DateTime? ShippedDate { get; set; }
    }
}
