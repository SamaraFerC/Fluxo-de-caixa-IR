using FluxoCaixa.Application.ViewModel;

namespace FluxoCaixa.Application.Interfaces
{
    public interface ICollaboratorService
    {
        IEnumerable<CollaboratorViewModel> GetAll();

        public Task<CollaboratorViewModel> GetById(int? id);

        void Add(CollaboratorViewModel activity);

        void Update(CollaboratorViewModel activity);

        void Delete(int id);
    }
}
