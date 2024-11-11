using FluxoCaixa.Domain.Entities;
using FluxoCaixa.Domain.Interfaces;
using FluxoCaixa.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace FluxoCaixa.Infra.Data.Repositories
{
    public class PaymentTypeRepository : IPaymentTypeRepository
    {
        private AppDbContext _context;

        public PaymentTypeRepository(AppDbContext appDbContext)
        {
            _context = appDbContext;
        }

        public IEnumerable<PaymentType> GetAll()
        {
            return _context.PaymentType;
        }
        public Task<PaymentType> GetById(int? id)
        {
            return _context.PaymentType.FirstOrDefaultAsync(x => x.Id == id);
        }

        public void Add(PaymentType collaboratorType)
        {
            _context.Add(collaboratorType);
            _context.SaveChanges();
        }

        public void Delete(PaymentType collaborator)
        {
            _context.Remove(collaborator);
            _context.SaveChanges();
        }

        public void Update(PaymentType collaborator)
        {
            _context.Update(collaborator);
            _context.SaveChanges();
        }
    }
}
