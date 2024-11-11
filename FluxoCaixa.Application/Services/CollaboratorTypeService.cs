using AutoMapper;
using FluxoCaixa.Application.Interfaces;
using FluxoCaixa.Application.ViewModel;
using FluxoCaixa.Domain.Entities;
using FluxoCaixa.Domain.Interfaces;

namespace FluxoCaixa.Application.Services
{
    public class CollaboratorTypeService : ICollaboratorTypeService
    {
        private readonly ICollaboratorTypeRepository _collaboratorRepository;
        private readonly IMapper _mapper;

        public CollaboratorTypeService(ICollaboratorTypeRepository collaboratorRepository, IMapper mapper)
        {
            _collaboratorRepository = collaboratorRepository;
            _mapper = mapper;
        }

        public async Task<CollaboratorTypeViewModel> GetById(int? id)
        {
            var objCollaborator = await _collaboratorRepository.GetById(id);

            return _mapper.Map<CollaboratorTypeViewModel>(objCollaborator);
        }

        public IEnumerable<CollaboratorTypeViewModel> GetAll()
        {
            var objCollaborator = _collaboratorRepository.GetAll();

            return _mapper.Map<IEnumerable<CollaboratorTypeViewModel>>(objCollaborator);
        }

        public void Add(CollaboratorTypeViewModel type)
        {
            type.Status = true;
            type.UserIncluded = "fulano";
            type.DateIncluded = DateTime.Now;

            var updateType = _mapper.Map<CollaboratorTypes>(type);

            _collaboratorRepository.Add(updateType);
        }

        public void Delete(int CollaboratorID)
        {
            var coll = _collaboratorRepository.GetById(CollaboratorID).Result;

            _collaboratorRepository.Delete(coll);
        }

        public void Update(CollaboratorTypeViewModel type)
        {
            type.UserChanged = "fulano";
            type.DateChanged = DateTime.Now;

            var updateType = _mapper.Map<CollaboratorTypes>(type);

            _collaboratorRepository.Update(updateType);
        }
    }
}
