using AutoMapper;
using FluxoCaixa.Domain.Entities;
using FluxoCaixa.Infra.Data.ViewModel;

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
