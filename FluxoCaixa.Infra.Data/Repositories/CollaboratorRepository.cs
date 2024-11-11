using FluxoCaixa.Domain.Entities;
using FluxoCaixa.Domain.Interfaces;
using FluxoCaixa.Infra.Data.Context;

namespace FluxoCaixa.Infra.Data.Repositories
{
    public class CollaboratorRepository : ICollaboratorRepository
    {
        private AppDbContext _context;

        public CollaboratorRepository(AppDbContext appDbContext) {
            _context = appDbContext;
        }

        public IEnumerable<Collaborator> GetCollaborators()
        {
            return _context.Collaborator;
        }
    }
}