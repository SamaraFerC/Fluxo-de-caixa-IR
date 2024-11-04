
using FluxoCaixa.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FluxoCaixa.Infra.Data.EntityConfiguration
{
    public class TypeCollaboratorConfiguration :IEntityTypeConfiguration<TypeCollaborator>
    {
        public void Configure(EntityTypeBuilder<TypeCollaborator> entity)
        {
            entity.HasKey(x => x.Id);

            entity.Property(p => p.Description)
                .HasMaxLength(100)
                .IsRequired();

            entity.Property(p => p.Status)
                .IsRequired();

            entity.Property(p => p.UserIncluded)
                .HasMaxLength(50)
                .IsRequired();

            entity.Property(p => p.DateIncluded)
              .IsRequired();

            entity.Property(p => p.UserChange)
                .HasMaxLength(50);

            entity.HasMany(e => e.Collaborators)
                  .WithOne(e => e.TypeCollaborator)
                  .HasForeignKey(e => e.TypeCollaboratorID)
                  .HasPrincipalKey(e => e.Id);
        }
    }
}
