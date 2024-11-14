using AutoMapper;
using FluxoCaixa.Application.Interfaces;
using FluxoCaixa.Application.ViewModel;
using FluxoCaixa.Domain.Entities;
using FluxoCaixa.Domain.Interfaces;

namespace FluxoCaixa.Application.Services
{
    public class PaymentTypeService : IPaymentTypeService
    {
        private readonly IPaymentTypeRepository _collaboratorRepository;
        private readonly IMapper _mapper;

        public PaymentTypeService(IPaymentTypeRepository collaboratorRepository, IMapper mapper)
        {
            _collaboratorRepository = collaboratorRepository;
            _mapper = mapper;
        }

        public async Task<PaymentTypeViewModel> GetById(int? id)
        {
            var objCollaborator = await _collaboratorRepository.GetById(id);

            return _mapper.Map<PaymentTypeViewModel>(objCollaborator);
        }

        public IEnumerable<PaymentTypeViewModel> GetAll()
        {
            var objCollaborator = _collaboratorRepository.GetAll();

            return _mapper.Map<IEnumerable<PaymentTypeViewModel>>(objCollaborator);
        }

        public IEnumerable<PaymentTypeViewModel> GetAllActives()
        {
            var objCollaborator = _collaboratorRepository.GetAll().Where(x =>x.Status);

            return _mapper.Map<IEnumerable<PaymentTypeViewModel>>(objCollaborator);
        }

        public void Add(PaymentTypeViewModel typevm)
        {
            typevm.UserIncluded = "userSystem"; //pegar usuario logado
            typevm.DateIncluded = DateTime.Now;

            var updateType = _mapper.Map<PaymentType>(typevm);

            _collaboratorRepository.Add(updateType);
        }

        public void Delete(int CollaboratorID)
        {
            var coll = _collaboratorRepository.GetById(CollaboratorID).Result;

            _collaboratorRepository.Delete(coll);
        }

        public void Update(PaymentTypeViewModel type)
        {
            type.UserChanged = "userSystem";
            type.DateChanged = DateTime.Now;

            var updateType = _mapper.Map<PaymentType>(type);

            _collaboratorRepository.Update(updateType);
        }
    }
}
