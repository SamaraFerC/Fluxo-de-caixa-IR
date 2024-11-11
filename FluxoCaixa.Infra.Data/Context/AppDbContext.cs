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
        public DbSet<Address> Address { get; set; }
        public DbSet<CashFlow> CashFlow { get; set; }
        public DbSet<Collaborator> Collaborator { get; set; }
        public DbSet<CollaboratorTypes> CollaboratorTypes { get; set; }
        public DbSet<FlowType> FlowType { get; set; }
        public DbSet<PaymentType> PaymentType { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new ActivityConfiguration());
            modelBuilder.ApplyConfiguration(new AddressConfiguration());
            modelBuilder.ApplyConfiguration(new CashFlowConfiguration());
            modelBuilder.ApplyConfiguration(new CollaboratorConfiguration());
            modelBuilder.ApplyConfiguration(new CollaboratorTypeConfiguration());
            modelBuilder.ApplyConfiguration(new FlowTypeConfiguration());
            modelBuilder.ApplyConfiguration(new PaymentTypeConfiguration());
        }
    }
}