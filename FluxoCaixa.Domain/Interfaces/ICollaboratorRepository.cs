using FluxoCaixa.Domain.Entities;

namespace FluxoCaixa.Domain.Interfaces
{
    public interface ICollaboratorRepository
    {
        public IEnumerable<Collaborator> GetCollaborators();
    }
}