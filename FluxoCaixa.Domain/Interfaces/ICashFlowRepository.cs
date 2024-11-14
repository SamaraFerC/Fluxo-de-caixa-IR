using FluxoCaixa.Domain.Entities;

namespace FluxoCaixa.Domain.Interfaces
{
    public interface ICashFlowRepository
    {
        IEnumerable<CashFlow> GetAll();

        public Task<CashFlow> GetById(string id);

        public CashFlow? FindCashFlow(string id);

        void Add(CashFlow activity);

        void Update(CashFlow activity);

        void Delete(CashFlow activity);
    }
}
