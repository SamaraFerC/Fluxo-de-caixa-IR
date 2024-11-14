using AutoMapper;
using FluxoCaixa.Application.Interfaces;
using FluxoCaixa.Application.ViewModel;
using FluxoCaixa.Domain.Interfaces;

namespace FluxoCaixa.Application.Services
{
    public class FlowTypeService : IFlowTypeService
    {
        private readonly IFlowTypeRepository _flowTypeRepository;
        private readonly IMapper _mapper;

        public FlowTypeService(IFlowTypeRepository flowTypeRepository, IMapper mapper)
        {
            _flowTypeRepository = flowTypeRepository;
            _mapper = mapper;
        }

        public async Task<FlowTypeViewModel> GetById(int id)
        {
            var objCollaborator = await _flowTypeRepository.GetById(id);

            return _mapper.Map<FlowTypeViewModel>(objCollaborator);
        }

        public IEnumerable<FlowTypeViewModel> GetAll()
        {
            var objCollaborator = _flowTypeRepository.GetAll();

            return _mapper.Map<IEnumerable<FlowTypeViewModel>>(objCollaborator);
        }
    }
}
