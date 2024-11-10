using AutoMapper;
using FluxoCaixa.Application.Interfaces;
using FluxoCaixa.Application.ViewModel;
using FluxoCaixa.Domain.Entities;
using FluxoCaixa.Domain.Interfaces;

namespace FluxoCaixa.Application.Services
{
    public class CollaboratorService : ICollaboratorService
    {
        private readonly ICollaboratorRepository _CollaboratorRepository;
        private readonly IMapper _mapper;

        public CollaboratorService(ICollaboratorRepository collaboratorRepository, IMapper mapper)
        {
            _CollaboratorRepository = collaboratorRepository;
            _mapper = mapper;
        }

        public async Task<CollaboratorViewModel> GetById(int? id)
        {
            var objCollaborator = await _CollaboratorRepository.GetById(id);

            return _mapper.Map<CollaboratorViewModel>(objCollaborator);
        }

        public IEnumerable<CollaboratorViewModel> GetAll()
        {
            var objCollaborator = _CollaboratorRepository.GetAll();

            return _mapper.Map<IEnumerable<CollaboratorViewModel>>(objCollaborator);
        }

        public void Add(CollaboratorViewModel collaborator)
        {
            collaborator.Status = true;
            collaborator.UserIncluded = "fulano";
            collaborator.DateIncluded = DateTime.Now;

            var newCollaborator = _mapper.Map<Collaborator>(collaborator);

            _CollaboratorRepository.Add(newCollaborator);
        }

        public void Delete(int CollaboratorID)
        {
            var coll = _CollaboratorRepository.GetById(CollaboratorID).Result;

            _CollaboratorRepository.Delete(coll);
        }

        public void Update(CollaboratorViewModel collaborator)
        {
            collaborator.UserChanged = "fulano";
            collaborator.DateChanged = DateTime.Now;

            var updatectivity = _mapper.Map<Collaborator>(collaborator);

            _CollaboratorRepository.Update(updatectivity);
        }
    }
}
