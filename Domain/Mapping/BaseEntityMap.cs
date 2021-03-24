using Domain.Entities.Common;
using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.ValueGeneration;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Mapping
{
    public abstract class BaseEntityMap<T> : IEntityTypeConfiguration<T> where T : BaseEntity
    {
        public void Configure(EntityTypeBuilder<T> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.CreateTime).HasColumnType("DATETIME").HasDefaultValueSql("GETDATE()").ValueGeneratedOnAdd();
            builder.Property(x => x.UpdateTime).HasColumnType("DATETIME").HasDefaultValueSql("GETDATE()").ValueGeneratedOnAddOrUpdate();
            builder.Property(x => x.Status).HasValueGenerator((prop,type) =>
            {
                return new EntityStatusValueGeneratedOnAddOrUpdate();
            });
        }
    }

    public class EntityStatusValueGeneratedOnAddOrUpdate : ValueGenerator<EntityStatus>
    {
        public override bool GeneratesTemporaryValues => false;

        public override EntityStatus Next(EntityEntry entry)
        {
            if (entry.State == EntityState.Added)
            {
                return EntityStatus.Created;
            }
            else
            {
                return EntityStatus.Modified;
            }
        }
    }
}
