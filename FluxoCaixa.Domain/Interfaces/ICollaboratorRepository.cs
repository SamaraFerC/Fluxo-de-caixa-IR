using FluxoCaixa.Domain.Entities;

namespace FluxoCaixa.Domain.Interfaces
{
    public interface ICollaboratorTypeRepository
    {
        IEnumerable<CollaboratorTypes> GetAll();

        public Task<CollaboratorTypes> GetById(int? id);

        void Add(CollaboratorTypes activity);

        void Update(CollaboratorTypes activity);

        void Delete(CollaboratorTypes activity);
    }
}