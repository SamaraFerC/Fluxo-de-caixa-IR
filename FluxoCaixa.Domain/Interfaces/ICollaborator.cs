using FluxoCaixa.Domain.Entities;

namespace FluxoCaixa.Domain.Interfaces
{
    public interface ICollaborator
    {
        public IEnumerable<Collaborator> GetCollaborators();
    }
}
