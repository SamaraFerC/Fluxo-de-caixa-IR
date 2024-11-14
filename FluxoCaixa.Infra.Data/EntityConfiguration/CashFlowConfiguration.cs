using FluxoCaixa.Domain.Entities;
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

            entity.Property(p => p.Description)
                .HasMaxLength(200)
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

            entity.HasOne(e => e.Activity)
                  .WithMany(e => e.CashFlow)
                  .HasForeignKey(e => e.ActivityId)
                  .IsRequired();

            entity.HasOne(e => e.Collaborator)
                  .WithMany(e => e.CashFlow)
                  .HasForeignKey(e => e.CollaboratorId)
                  .IsRequired();

            entity.HasOne(e => e.FlowType)
                  .WithMany(e => e.CashFlow)
                  .HasForeignKey(e => e.FlowTypeId)
                  .IsRequired();

            entity.HasOne(e => e.PaymentType)
                  .WithMany(e => e.CashFlow)
                  .HasForeignKey(e => e.PaymentTypeId)
                  .IsRequired();
        }
    }
}