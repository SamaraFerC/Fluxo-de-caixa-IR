﻿using AutoMapper;
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

        public async Task<List<ActivityViewModel>> GetAllActivities()
        {
            var objActivity = await _activityRepository.GetAllActivities();

            return _mapper.Map<List<ActivityViewModel>>(objActivity);
        }

        public void AddActivity(ActivityViewModel activity)
        {
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
            var updatectivity = _mapper.Map<Activity>(activity);

            _activityRepository.UpdateActivity(updatectivity);
        }
    }
}
