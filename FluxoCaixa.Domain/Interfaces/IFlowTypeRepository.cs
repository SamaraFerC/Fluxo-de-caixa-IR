using FluxoCaixa.Domain.Entities;

namespace FluxoCaixa.Domain.Interfaces
{
    public interface IFlowTypeRepository
    {
        IEnumerable<FlowType> GetAll();

        public Task<FlowType> GetById(int id);
    }
}
