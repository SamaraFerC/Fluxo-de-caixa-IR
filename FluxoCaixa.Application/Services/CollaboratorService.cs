using AutoMapper;
using FluxoCaixa.Application.Interfaces;
using FluxoCaixa.Application.ViewModel;
using FluxoCaixa.Domain.Entities;
using FluxoCaixa.Domain.Interfaces;

namespace FluxoCaixa.Application.Services
{
    public class CollaboratorService : ICollaboratorService
    {
        private readonly ICollaboratorRepository _collaboratorRepository;
        private readonly IMapper _mapper;

        public CollaboratorService(ICollaboratorRepository collaboratorRepository, IMapper mapper)
        {
            _collaboratorRepository = collaboratorRepository;
            _mapper = mapper;
        }

        public async Task<CollaboratorViewModel> GetById(int? id)
        {
            var objCollaborator = await _collaboratorRepository.GetById(id);

            return _mapper.Map<CollaboratorViewModel>(objCollaborator);
        }

        public IEnumerable<CollaboratorViewModel> GetAll()
        {
            var objCollaborator = _collaboratorRepository.GetAll();

            return _mapper.Map<IEnumerable<CollaboratorViewModel>>(objCollaborator);
        }

        public IEnumerable<CollaboratorViewModel> GetAllActives()
        {
            var objCollaborator = _collaboratorRepository.GetAll().Where(x =>x.Status);

            return _mapper.Map<IEnumerable<CollaboratorViewModel>>(objCollaborator);
        }

        public void Add(CollaboratorViewModel collaborator)
        {
            collaborator.UserIncluded = "fulano";
            collaborator.DateIncluded = DateTime.Now;

            var newCollaborator = _mapper.Map<Collaborator>(collaborator);

            _collaboratorRepository.Add(newCollaborator);
        }

        public void Delete(int CollaboratorID)
        {
            var coll = _collaboratorRepository.GetById(CollaboratorID).Result;

            _collaboratorRepository.Delete(coll);
        }

        public void Update(CollaboratorViewModel collaborator)
        {
            collaborator.UserChanged = "fulano";
            collaborator.DateChanged = DateTime.Now;

            var updatectivity = _mapper.Map<Collaborator>(collaborator);

            _collaboratorRepository.Update(updatectivity);
        }
    }
}
