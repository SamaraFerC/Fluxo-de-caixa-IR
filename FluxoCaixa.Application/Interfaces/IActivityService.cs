using FluxoCaixa.Application.ViewModel;

namespace FluxoCaixa.Application.Interfaces
{
    public interface IActivityService
    {
        IEnumerable<ActivityViewModel> GetAllActivities();

        IEnumerable<ActivityViewModel> GetAllActives();

        public Task<ActivityViewModel> GetById(int? id);

        void AddActivity(ActivityViewModel activity);

        void UpdateActivity(ActivityViewModel activity);

        void DeleteActivity(int id);
    }
}
