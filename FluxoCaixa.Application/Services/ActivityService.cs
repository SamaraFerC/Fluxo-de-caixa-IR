using AutoMapper;
using FluxoCaixa.Application.Interfaces;
using FluxoCaixa.Application.ViewModel;
using FluxoCaixa.Domain.Entities;
using FluxoCaixa.Domain.Interfaces;

namespace FluxoCaixa.Application.Services
{
    public class ActivityService : IActivityService
    {
        private readonly IActivityRepository _activityRepository;
        private readonly IMapper _mapper;

        public ActivityService(IActivityRepository activityRepository, IMapper mapper)
        {
            _activityRepository = activityRepository;
            _mapper = mapper;
        }

        public async Task<ActivityViewModel> GetById(int? id)
        {
            var objActivity = await _activityRepository.GetById(id);

            return _mapper.Map<ActivityViewModel>(objActivity);
        }

        public IEnumerable<ActivityViewModel> GetAllActivities()
        {
            var objActivity = _activityRepository.GetAllActivities();

            return _mapper.Map<IEnumerable<ActivityViewModel>>(objActivity);
        }

        public IEnumerable<ActivityViewModel> GetAllActives()
        {
            var objActivity = _activityRepository.GetAllActivities().Where(x =>x.Status);

            return _mapper.Map<IEnumerable<ActivityViewModel>>(objActivity);
        }
        public void AddActivity(ActivityViewModel activity)
        {
            activity.Status = true;
            activity.UserIncluded = "userSystem";
            activity.DateIncluded = DateTime.Now;

            var newActivity = _mapper.Map<Activity>(activity);

            _activityRepository.AddActivity(newActivity);
        }

        public void DeleteActivity(int activityID)
        {
            var act = _activityRepository.GetById(activityID).Result;

            _activityRepository.DeleteActivity(act);
        }

        public void UpdateActivity(ActivityViewModel activity)
        {            
            activity.UserChanged = "userSystem";
            activity.DateChanged = DateTime.Now;

            var updatectivity = _mapper.Map<Activity>(activity);

            _activityRepository.UpdateActivity(updatectivity);
        }
    }
}
