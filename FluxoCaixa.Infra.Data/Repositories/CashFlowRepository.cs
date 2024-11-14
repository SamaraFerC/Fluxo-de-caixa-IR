using FluxoCaixa.Domain.Entities;
using FluxoCaixa.Domain.Interfaces;
using FluxoCaixa.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace FluxoCaixa.Infra.Data.Repositories
{
    public class CashFlowRepository : ICashFlowRepository
    {
        private AppDbContext _context;

        public CashFlowRepository(AppDbContext context)
        {
            _context = context;
        }

        public CashFlow? FindCashFlow(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<CashFlow> GetAll()
        {
            return _context.CashFlow;
        }

        public Task<CashFlow?> GetById(int id)
        {
            return _context.CashFlow.FirstOrDefaultAsync(c => c.Id == id);
        }
        public void Add(CashFlow flow)
        {
            _context.Add(flow);
            _context.SaveChanges();
        }

        public void Delete(CashFlow flow)
        {
            _context.Remove(flow);
            _context.SaveChanges();
        }

        public void Update(CashFlow flow)
        {
            _context.Update(flow);
            _context.SaveChanges();
        }
    }
}
