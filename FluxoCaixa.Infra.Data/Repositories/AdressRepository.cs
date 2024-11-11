using FluxoCaixa.Domain.Entities;
using FluxoCaixa.Domain.Interfaces;
using FluxoCaixa.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace FluxoCaixa.Infra.Data.Repositories
{
    public class AddressRepository : IAddressRepository
    {
        private AppDbContext _context;

        public AddressRepository(AppDbContext context)
        {
            _context = context;
        }

        public Task<Address> GetById(int id)
        {
            return _context.Address.FirstOrDefaultAsync(x => x.Id == id);
        }

        public void Add(Address address)
        {
            _context.Add(address);
            _context.SaveChanges();
        }

        public void Delete(Address address)
        {
            _context.Remove(address);
            _context.SaveChanges();
        }

        public void Update(Address address)
        {
            _context.Update(address);
            _context.SaveChanges();
        }
    }
}
