using FluxoCaixa.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FluxoCaixa.Infra.Data.EntityConfiguration
{
    public class FlowTypeConfiguration : IEntityTypeConfiguration<FlowType>
    {
        public void Configure(EntityTypeBuilder<FlowType> entity)
        {
            entity.HasKey(x => x.Id);

            entity.Property(p => p.Name)
                .HasMaxLength(100)
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
        }
    }
}
