﻿using Atomiv.Infrastructure.EntityFrameworkCore;
using Atomiv.Template.Core.Common.Orders;
using System;

namespace Atomiv.Template.Infrastructure.Domain.Persistence.Records
{
    public class OrderItemRecord : Record<Guid>
    {
        public Guid OrderId { get; set; }
        
        public Guid ProductId { get; set; }
        
        public OrderItemStatus StatusId { get; set; }
        
        public decimal Quantity { get; set; }
        
        public decimal UnitPrice { get; set; }

        public virtual OrderRecord Order { get; set; }
       
        public virtual ProductRecord Product { get; set; }
        
        public virtual OrderItemStatusRecord Status { get; set; }
    }
}