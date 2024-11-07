using FluxoCaixa.Application.Interfaces;
using FluxoCaixa.Application.ViewModel;
using FluxoCaixa.Domain.Entities;
using FluxoCaixa.Domain.Interfaces;

namespace FluxoCaixa.Application.Services
{
    public class ActivityService : IActivityService
    {
        private readonly IActivityRepository _activityRepository;

        public ActivityService(IActivityRepository activityRepository)
        {
            _activityRepository = activityRepository;
        }

        public async Task<ActivityViewModel> GetById(int id)
        {
            var objActivity = await _activityRepository.GetById(id);

            var act = new Activity(objActivity.Name,objActivity.Description,objActivity.Status,objActivity.UserIncluded,objActivity.DateIncluded);

            return act;
        }

        //public async Task<List<ActivityViewModel>> GetAllActivities()
        //{
        //    var objActivity = await _activityRepository.GetAllActivities();

        //    return _mapper.Map<List<ActivityViewModel>>(objActivity);
        //}

        //public void AddActivity(ActivityViewModel activity)
        //{
        //    var newActivity = _mapper.Map<Activity>(activity);

        //    _activityRepository.AddActivity(newActivity);
        //}

        //public void DeleteActivity(int activityID)
        //{
        //    var act = GetById((int)activityID).Result;

        //    _activityRepository.DeleteActivity(_mapper.Map<Activity>(act));
        //}        

        //public void UpdateActivity(ActivityViewModel activity)
        //{
        //    var updatectivity = _mapper.Map<Activity>(activity);
        //    _activityRepository.UpdateActivity(updatectivity);
        //}
    }
}
