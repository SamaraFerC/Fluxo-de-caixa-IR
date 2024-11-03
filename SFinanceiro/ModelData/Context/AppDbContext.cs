﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SFinanceiro.ModelData.Entities;
using System.Reflection.Metadata;

namespace SFinanceiro.ModelData.Context
{
    public class AppDbContext : IdentityDbContext

    {
        public AppDbContext(DbContextOptions<AppDbContext> options) :
            base(options)
        {

        }

        public DbSet<Collaborator> Collaborator { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<TypeCollaborator> TypeCollaborators { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

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
