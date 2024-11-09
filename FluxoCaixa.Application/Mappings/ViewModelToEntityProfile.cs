using AutoMapper;
using FluxoCaixa.Application.ViewModel;
using FluxoCaixa.Domain.Entities;

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