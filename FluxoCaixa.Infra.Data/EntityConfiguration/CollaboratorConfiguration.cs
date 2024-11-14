using FluxoCaixa.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;

namespace FluxoCaixa.Infra.Data.EntityConfiguration
{
    public class CollaboratorConfiguration : IEntityTypeConfiguration<Collaborator>
    {
        public void Configure(EntityTypeBuilder<Collaborator> entity)
        {
            entity.HasKey(x => x.Id);

            entity.Property(p => p.Id)
                  .IsRequired()
                  .HasMaxLength(20)
                  .HasColumnType("VARCHAR");

            entity.Property(p => p.FullName)
                .HasMaxLength(50)
                .IsRequired();

            entity.Property(p => p.DateBirth);

            entity.Property(p => p.Status)
                .IsRequired();

            entity.Property(p => p.UserIncluded)
                .HasMaxLength(50)
                .IsRequired();

            entity.Property(p => p.DateIncluded)
               .IsRequired();

            entity.Property(p => p.UserChanged)
                .HasMaxLength(50);

            entity.Property(p => p.AddressID);

            entity.Property(p => p.CollaboratorTypeID)
                  .IsRequired();

            entity.HasOne(c => c.CollaboratorType)
                  .WithMany(tc => tc.Collaborators)
                  .HasForeignKey(c => c.CollaboratorTypeID)
                  .IsRequired();
        }
    }
}