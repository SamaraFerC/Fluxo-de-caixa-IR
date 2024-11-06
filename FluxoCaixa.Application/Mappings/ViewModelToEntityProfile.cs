using AutoMapper;
using FluxoCaixa.Domain.Entities;
using FluxoCaixa.Infra.Data.ViewModel;

namespace FluxoCaixa.Application.Mappings
{
    public class ViewModelToEntityProfile : Profile
    {
        protected ViewModelToEntityProfile()
        {
            CreateMap<ActivityViewModel, Activity>();
        }
    }
}