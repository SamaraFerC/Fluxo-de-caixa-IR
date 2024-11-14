using AutoMapper;
using FluxoCaixa.Application.Interfaces;
using FluxoCaixa.Application.ViewModel;
using FluxoCaixa.Domain.Entities;
using FluxoCaixa.Domain.Interfaces;
using FluxoCaixa.Infra.Data.Repositories;

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

        public CashFlowViewModel FindCashFlow(string id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<CashFlowViewModel> GetAll()
        {
            var objMov = await _cashFlowRepository;

            return _mapper.Map<CashFlowViewModel>(objMov);
        }

        public Task<CashFlowViewModel> GetById(string id)
        {
            var objMov = await _cashFlowRepository.GetById(id);

            return _mapper.Map<CashFlowViewModel>(objMov);
        }

        public void Update(CashFlowViewModel cashFlowVM)
        {
            throw new NotImplementedException();
        }

        public void Delete(int cashFlowID)
        {
            var coll = _cashFlowRepository.GetById(cashFlowID).Result;

            _cashFlowRepository.Delete(coll);
        }

        public void Update(CashFlowViewModel cashFlowVM)
        {
            //collaborator.UserChanged = "fulano";
            //collaborator.DateChanged = DateTime.Now;

            var newcf = _mapper.Map<Collaborator>(cashFlowVM);

            //if (collaborator.addressVM != null)
            //{
            //    AddAddress(collaborator, newColl);
            //}
            //else
            //{
            //    //updateAddres();
            //}

            _cashFlowRepository.Update(newcf);
        }
    }
}
