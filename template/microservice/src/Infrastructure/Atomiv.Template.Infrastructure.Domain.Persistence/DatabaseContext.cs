﻿using Microsoft.EntityFrameworkCore;
using Atomiv.Infrastructure.EntityFrameworkCore;
using Atomiv.Template.Core.Common.Orders;
using Atomiv.Template.Infrastructure.Domain.Persistence.Configurations;
using Atomiv.Template.Infrastructure.Domain.Persistence.Records;

namespace Atomiv.Template.Infrastructure.Domain.Persistence.Common
{
    public partial class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options)
            : base(options)
        {
        }

        public virtual DbSet<CustomerRecord> Customers { get; set; }

        public virtual DbSet<OrderItemRecord> OrderItems { get; set; }

        public virtual DbSet<OrderItemStatusRecord> OrderItemStatuses { get; set; }

        public virtual DbSet<OrderRecord> Orders { get; set; }
        
        public virtual DbSet<OrderStatusRecord> OrderStatuses { get; set; }

        public virtual DbSet<ProductRecord> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            ApplyConfiguration(modelBuilder);
            SeedEnum(modelBuilder);
        }

        private void ApplyConfiguration(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CustomerRecordConfiguration());
            modelBuilder.ApplyConfiguration(new OrderItemRecordConfiguration());
            modelBuilder.ApplyConfiguration(new OrderItemStatusRecordConfiguration());
            modelBuilder.ApplyConfiguration(new OrderRecordConfiguration());
            modelBuilder.ApplyConfiguration(new OrderStatusRecordConfiguration());
            modelBuilder.ApplyConfiguration(new ProductRecordConfiguration());
        }

        private void SeedEnum(ModelBuilder modelBuilder)
        {
            modelBuilder.SeedEnum<OrderItemStatusRecord, OrderItemStatus>(e => new OrderItemStatusRecord { Id = e, Code = e.ToString() });
            modelBuilder.SeedEnum<OrderStatusRecord, OrderStatus>(e => new OrderStatusRecord { Id = e, Code = e.ToString() });
        }
    }
}