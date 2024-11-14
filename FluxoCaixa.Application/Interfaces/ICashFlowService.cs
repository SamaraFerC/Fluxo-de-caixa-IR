using FluxoCaixa.Application.ViewModel;

namespace FluxoCaixa.Application.Interfaces
{
    public interface ICashFlowService
    {
        IEnumerable<CashFlowViewModel> GetAll();

        public Task<CashFlowViewModel> GetById(int id);

        public CashFlowViewModel FindCashFlow(int id);

        void Add(CashFlowViewModel activity);

        void Update(CashFlowViewModel activity);

        void Delete(int id);
    }
}
