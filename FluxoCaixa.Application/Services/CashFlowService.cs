using AutoMapper;
using FluxoCaixa.Application.Interfaces;
using FluxoCaixa.Application.ViewModel;
using FluxoCaixa.Domain.Entities;
using FluxoCaixa.Domain.Interfaces;

namespace FluxoCaixa.Application.Services
{
    public class CashFlowService : ICashFlowService
    {
        private readonly ICashFlowRepository _cashFlowRepository;
        private readonly IMapper _mapper;

        public CashFlowService(ICashFlowRepository cashFlowRepository, IMapper mapper)
        {
            _cashFlowRepository = cashFlowRepository;
            _mapper = mapper;
        }

        public async Task<CashFlowViewModel> GetById(int id)
        {
            var cashFlow = await _cashFlowRepository.GetById(id);

            return _mapper.Map<CashFlowViewModel>(cashFlow);
        }

        public IEnumerable<CashFlowViewModel> GetAll()
        {
            var cashFlow =  _cashFlowRepository.GetAll();            

            return _mapper.Map<IEnumerable<CashFlowViewModel>>(cashFlow);
        }

        public CashFlowViewModel FindCashFlow(int id)
        {
            var cashFlow = _cashFlowRepository.FindCashFlow(id);

            var cashFlowVM = _mapper.Map<CashFlowViewModel>(cashFlow);

            cashFlowVM.ActivityVM = _mapper.Map<ActivityViewModel>(cashFlow.Activity);
            cashFlowVM.CollaboratorView = _mapper.Map<CollaboratorViewModel>(cashFlow.Collaborator);
            cashFlowVM.FlowTypeView = _mapper.Map<FlowTypeViewModel>(cashFlow.FlowType);
            cashFlowVM.PaymentTypeView = _mapper.Map<PaymentTypeViewModel>(cashFlow.PaymentType);

            return cashFlowVM;
        }

        public void Add(CashFlowViewModel flow)
        {
            flow.UserIncluded = "user";
            flow.DateIncluded = DateTime.Now;

            var newCF = _mapper.Map<CashFlow>(flow);

            _cashFlowRepository.Add(newCF);
        }
        public void Delete(int id)
        {
            var coll = _cashFlowRepository.GetById(id).Result;

            _cashFlowRepository.Delete(coll);
        }

        public void Update(CashFlowViewModel flow)
        {
            flow.UserChanged = "fulano";
            flow.DateChanged = DateTime.Now;

            var newcf = _mapper.Map<CashFlow>(flow);

            _cashFlowRepository.Update(newcf);
        }
    }
}
