using FluxoCaixa.Domain.Entities;

namespace FluxoCaixa.Domain.Interfaces
{
    public interface ICashFlowRepository
    {
        IEnumerable<CashFlow> GetAll();

        public Task<CashFlow> GetById(int id);

        public CashFlow? FindCashFlow(int id);

        void Add(CashFlow activity);

        void Update(CashFlow activity);

        void Delete(CashFlow activity);
    }
}
