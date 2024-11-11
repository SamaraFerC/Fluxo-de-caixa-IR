using FluxoCaixa.Domain.Entities;

namespace FluxoCaixa.Domain.Interfaces
{
    public interface ICollaboratorRepository
    {
        IEnumerable<Collaborator> GetAll();

        public Task<Collaborator> GetById(int? id);

        void Add(Collaborator activity);

        void Update(Collaborator activity);

        void Delete(Collaborator activity);
    }
}