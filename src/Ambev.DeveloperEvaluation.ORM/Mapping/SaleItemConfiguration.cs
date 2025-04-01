﻿using Ambev.DeveloperEvaluation.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Ambev.DeveloperEvaluation.ORM.Mapping
{
    public class SaleItemConfiguration : IEntityTypeConfiguration<SaleItem>
    {
        public void Configure(EntityTypeBuilder<SaleItem> builder)
        {
            builder.ToTable("SaleItems");

            builder.HasKey(si => si.Id);

            builder.Property(si => si.Id)
                .HasColumnType("uuid")
                .HasDefaultValueSql("gen_random_uuid()");

            builder.Property(si => si.SaleId)
                .IsRequired();

            builder.Property(si => si.Quantity)
                .IsRequired()
                .HasDefaultValue(1);

            builder.Property(si => si.UnitPrice)
                .HasColumnType("decimal(18,2)")
                .IsRequired();

            builder.Property(si => si.Discount)
                .HasColumnType("decimal(18,2)")
                .HasDefaultValue(0);

            builder.Property(si => si.TotalAmount)
                .HasColumnType("decimal(18,2)")
                .IsRequired();
        }
    }
}
