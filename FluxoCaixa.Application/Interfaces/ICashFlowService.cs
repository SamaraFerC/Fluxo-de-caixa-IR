using FluxoCaixa.Application.ViewModel;

namespace FluxoCaixa.Application.Interfaces
{
    public interface ICashFlowService
    {
        IEnumerable<CashFlowViewModel> GetAll();

        public Task<CashFlowViewModel> GetById(string id);

        public IEnumerable<CashFlowViewModel> GetAllActives();

        public CashFlowViewModel FindCashFlow(string id);

        void Add(CashFlowViewModel activity);

        void Update(CashFlowViewModel activity);

        void Delete(string id);
    }
}
