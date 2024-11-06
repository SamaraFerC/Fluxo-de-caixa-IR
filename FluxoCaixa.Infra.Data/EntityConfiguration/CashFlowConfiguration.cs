﻿using FluxoCaixa.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace FluxoCaixa.Infra.Data.EntityConfiguration
{
    public class CashFlowConfiguration : IEntityTypeConfiguration<CashFlow>
    {
        public void Configure(EntityTypeBuilder<CashFlow> entity)
        {
            entity.HasKey(x => x.Id);

            entity.Property(p => p.FlowTypeId)
                .IsRequired();

            entity.Property(p => p.ActivityId)
                .IsRequired();

            entity.Property(p => p.CollaboratorId)
                .IsRequired();

            entity.Property(p => p.PaymentTypeId)
                .IsRequired();

            entity.Property(p => p.Value)
                .HasPrecision(15, 2)
                .IsRequired();

            entity.Property(p => p.Status)
                .IsRequired();

            entity.Property(p => p.UserIncluded)
                .HasMaxLength(50)
                .IsRequired();

            entity.Property(p => p.DateIncluded)
               .IsRequired();

            entity.Property(p => p.UserChanged)
                .HasMaxLength(50);

            //entity.HasMany(e => e.Collaborators)
            //           .WithOne(e => e.Address)
            //           .HasForeignKey(e => e.AddressID)
            //           .HasPrincipalKey(e => e.Id); fazer relacionamentos
        }
    }
}