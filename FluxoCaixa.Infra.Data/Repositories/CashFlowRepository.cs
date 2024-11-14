using FluxoCaixa.Domain.Entities;
using FluxoCaixa.Domain.Interfaces;

namespace FluxoCaixa.Infra.Data.Repositories
{
    public class CashFlowRepository : ICashFlowRepository
    {
        public CashFlow? FindCashFlow(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<CashFlow> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<CashFlow> GetById(int id)
        {
            throw new NotImplementedException();
        }
        public void Add(CashFlow activity)
        {
            throw new NotImplementedException();
        }

        public void Delete(CashFlow activity)
        {
            throw new NotImplementedException();
        }

        public void Update(CashFlow activity)
        {
            throw new NotImplementedException();
        }
    }
}
