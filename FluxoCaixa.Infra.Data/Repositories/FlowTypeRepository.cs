using FluxoCaixa.Domain.Entities;
using FluxoCaixa.Domain.Interfaces;
using FluxoCaixa.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace FluxoCaixa.Infra.Data.Repositories
{
    public class FlowTypeRepository : IFlowTypeRepository
    {
        private AppDbContext _context;

        public FlowTypeRepository(AppDbContext appDbContext)
        {
            _context = appDbContext;
        }

        public IEnumerable<FlowType> GetAll()
        {
            return _context.FlowType;
        }

        public Task<FlowType?> GetById(int id)
        {
            return _context.FlowType.FirstOrDefaultAsync(x => x.Id == id);
        }
    }
}