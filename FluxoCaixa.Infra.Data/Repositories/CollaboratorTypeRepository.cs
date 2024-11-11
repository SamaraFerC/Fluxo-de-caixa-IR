using FluxoCaixa.Domain.Entities;
using FluxoCaixa.Domain.Interfaces;
using FluxoCaixa.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace FluxoCaixa.Infra.Data.Repositories
{
    public class CollaboratorTypeRepository : ICollaboratorTypeRepository
    {
        private AppDbContext _context;

        public CollaboratorTypeRepository(AppDbContext appDbContext) {
            _context = appDbContext;
        }

        public IEnumerable<CollaboratorTypes> GetAll()
        {
            return _context.CollaboratorTypes;
        }
        public Task<CollaboratorTypes> GetById(int? id)
        {
            return _context.CollaboratorTypes.FirstOrDefaultAsync(x => x.Id == id);
        }

        public void Add(CollaboratorTypes collaboratorType)
        {
            _context.Add(collaboratorType);
            _context.SaveChanges();
        }

        public void Delete(CollaboratorTypes collaborator)
        {
            _context.Remove(collaborator);
            _context.SaveChanges();
        }

        public void Update(CollaboratorTypes collaborator)
        {
            _context.Update(collaborator);
            _context.SaveChanges();
        }
    }
}