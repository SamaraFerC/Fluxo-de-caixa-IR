using FluxoCaixa.Infra.Data.ViewModel;

namespace FluxoCaixa.Application.Interfaces
{
    public interface IActivityService
    {
        Task<List<ActivityViewModel>> GetAllActivities();

        public Task<ActivityViewModel> GetById(int id);

        void AddActivity(ActivityViewModel activity);

        void UpdateActivity(ActivityViewModel activity);

        void DeleteActivity(int id);
    }
}
