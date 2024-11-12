using FluxoCaixa.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FluxoCaixa.Infra.Data.EntityConfiguration
{
    public class CollaboratorTypeConfiguration : IEntityTypeConfiguration<CollaboratorTypes>
    {
        public void Configure(EntityTypeBuilder<CollaboratorTypes> entity)
        {
            entity.HasKey(x => x.Id);

            entity.Property(p => p.Name)
                .HasMaxLength(50)
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

            entity.HasMany(e => e.Collaborators)
                  .WithOne(e => e.CollaboratorType)
                  .HasForeignKey(e => e.CollaboratorTypeID)
                  .HasPrincipalKey(e => e.Id);
        }
    }
}
