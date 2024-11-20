using FluxoCaixa.Domain.Entities;

namespace FluxoCaixa.Domain.Interfaces
{
    public interface IActivityRepository
    {
        IEnumerable<Activity> GetAllActivities();

        public Task<Activity> GetById(int? id);

        void AddActivity(Activity activity);

        void UpdateActivity(Activity activity);

        void DeleteActivity(Activity activity);
    }
}
