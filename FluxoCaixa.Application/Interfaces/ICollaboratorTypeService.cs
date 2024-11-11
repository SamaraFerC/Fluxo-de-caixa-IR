using FluxoCaixa.Application.ViewModel;

namespace FluxoCaixa.Application.Interfaces
{
    public interface ICollaboratorTypeService
    {
        IEnumerable<CollaboratorTypeViewModel> GetAll();

        public Task<CollaboratorTypeViewModel> GetById(int? id);

        void Add(CollaboratorTypeViewModel activity);

        void Update(CollaboratorTypeViewModel activity);

        void Delete(int id);
    }
}
