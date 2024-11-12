using FluxoCaixa.Application.ViewModel;

namespace FluxoCaixa.Application.Interfaces
{
    public interface ICollaboratorService
    {
        IEnumerable<CollaboratorViewModel> GetAll();

        public Task<CollaboratorViewModel> GetById(string id);
        public IEnumerable<CollaboratorViewModel> GetAllActives();

        public CollaboratorViewModel FindCollaborator(string id);

        void Add(CollaboratorViewModel activity);

        void Update(CollaboratorViewModel activity);

        void Delete(string id);
    }
}
