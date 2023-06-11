﻿using CleanArch.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CleanArch.Infra.Data.FluenteApiEntitiesConfig
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(t => t.Id);
            builder.Property(p => p.Name).HasMaxLength(100).IsRequired();
            builder.Property(p => p.Description).HasMaxLength(250).IsRequired();

            builder.Property(p => p.Price).HasPrecision(18, 2);

            //=> Definindo chave estrangeira 1-N
            builder.HasOne(e => e.Category).WithMany(e => e.Products) .HasForeignKey(e => e.CategoryId); 
        }
    }
}
