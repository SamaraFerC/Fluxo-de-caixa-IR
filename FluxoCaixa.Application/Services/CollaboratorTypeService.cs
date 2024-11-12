using AutoMapper;
using FluxoCaixa.Application.Interfaces;
using FluxoCaixa.Application.ViewModel;
using FluxoCaixa.Domain.Entities;
using FluxoCaixa.Domain.Interfaces;
using FluxoCaixa.Infra.Data.Repositories;

namespace FluxoCaixa.Application.Services
{
    public class CollaboratorTypeService : ICollaboratorTypeService
    {
        private readonly ICollaboratorTypeRepository _collaboratorTypeRepository;
        private readonly IMapper _mapper;

        public CollaboratorTypeService(ICollaboratorTypeRepository collaboratorRepository, IMapper mapper)
        {
            _collaboratorTypeRepository = collaboratorRepository;
            _mapper = mapper;
        }

        public async Task<CollaboratorTypeViewModel> GetById(int? id)
        {
            var objCollaborator = await _collaboratorTypeRepository.GetById(id);

            return _mapper.Map<CollaboratorTypeViewModel>(objCollaborator);
        }

        public IEnumerable<CollaboratorTypeViewModel> GetAll()
        {
            var objCollaborator = _collaboratorTypeRepository.GetAll();

            return _mapper.Map<IEnumerable<CollaboratorTypeViewModel>>(objCollaborator);
        }

        public IEnumerable<CollaboratorTypeViewModel> GetAllActives()
        {
            var objCollaborator = _collaboratorTypeRepository.GetAll().Where(x => x.Status);

            return _mapper.Map<IEnumerable<CollaboratorTypeViewModel>>(objCollaborator);
        }

        public void Add(CollaboratorTypeViewModel type)
        {
            type.UserIncluded = "fulano";
            type.DateIncluded = DateTime.Now;

            var updateType = _mapper.Map<CollaboratorTypes>(type);

            _collaboratorTypeRepository.Add(updateType);
        }

        public void Delete(int CollaboratorID)
        {
            var coll = _collaboratorTypeRepository.GetById(CollaboratorID).Result;

            _collaboratorTypeRepository.Delete(coll);
        }

        public void Update(CollaboratorTypeViewModel type)
        {
            type.UserChanged = "fulano";
            type.DateChanged = DateTime.Now;

            var updateType = _mapper.Map<CollaboratorTypes>(type);

            _collaboratorTypeRepository.Update(updateType);
        }
    }
}
