using FluxoCaixa.Application.ViewModel;

namespace FluxoCaixa.Application.Interfaces
{
    public interface IFlowTypeService
    {
        IEnumerable<FlowTypeViewModel> GetAll();

        public Task<FlowTypeViewModel> GetById(int id);
    }
}
