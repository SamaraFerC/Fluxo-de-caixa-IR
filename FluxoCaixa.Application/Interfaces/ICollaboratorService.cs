using FluxoCaixa.Application.ViewModel;

namespace FluxoCaixa.Application.Interfaces
{
    public interface ICollaboratorService
    {
        public IEnumerable<CollaboratorViewModel> GetAll();

        public IEnumerable<CollaboratorViewModel> GetAllActives();

        public Task<CollaboratorViewModel> GetById(string id);

        void Add(CollaboratorViewModel activity);

        void Update(CollaboratorViewModel activity);

        void Delete(int id);
    }
}
