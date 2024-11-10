using FluxoCaixa.Domain.Entities;
using FluxoCaixa.Domain.Interfaces;
using FluxoCaixa.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluxoCaixa.Infra.Data.Repositories
{
    public class ActivityRepository : IActivityRepository
    {
        private AppDbContext _context;

        public ActivityRepository(AppDbContext appDbContext)
        {
            _context = appDbContext;
        }

        public Task<Activity> GetById(int? id)
        {
            return _context.Activity.FirstOrDefaultAsync(x => x.Id == id);
        }

        public IEnumerable<Activity> GetAllActivities()
        {
            return _context.Activity;
        }

        public void AddActivity(Activity activity)
        {
            _context.Add(activity);
            _context.SaveChanges();
        }

        public void DeleteActivity(Activity activity)
        {
            _context.Remove(activity);
            _context.SaveChanges();
        }

        public void UpdateActivity(Activity activity)
        {
            _context.Update(activity);
            _context.SaveChanges();
        }
    }
}
