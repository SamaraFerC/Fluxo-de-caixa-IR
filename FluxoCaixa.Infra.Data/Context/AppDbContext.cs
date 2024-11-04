using FluxoCaixa.Domain.Entities;
using FluxoCaixa.Infra.Data.EntityConfiguration;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace FluxoCaixa.Infra.Data.Context
{
    public class AppDbContext : IdentityDbContext

    {
        public AppDbContext(DbContextOptions<AppDbContext> options) :
            base(options)
        {

        }

        public DbSet<Activity> Activity{ get; set; }
        public DbSet<Collaborator> Collaborator { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<TypeCollaborator> TypeCollaborators { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //modelBuilder.ApplyConfiguration(new ActivityConfiguration());

            modelBuilder.Entity<TypeCollaborator>()
                        .HasMany(e => e.Collaborators)
                        .WithOne(e => e.TypeCollaborator)
                        .HasForeignKey(e => e.TypeCollaboratorID)
                        .HasPrincipalKey(e => e.Id);

            modelBuilder.Entity<Address>()
                       .HasMany(e => e.Collaborators)
                       .WithOne(e => e.Address)
                       .HasForeignKey(e => e.AddressID)
                       .HasPrincipalKey(e => e.Id);
        }
    }
}