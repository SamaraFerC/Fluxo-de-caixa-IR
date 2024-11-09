using AutoMapper;
using FluxoCaixa.Application.ViewModel;
using FluxoCaixa.Domain.Entities;

namespace FluxoCaixa.Application.Mappings
{
    public class EntityToViewModelProfile : Profile
    {
        public EntityToViewModelProfile()
        {
            CreateMap<Activity, ActivityViewModel>();
        }
    }
}
