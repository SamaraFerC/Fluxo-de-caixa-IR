using AutoMapper;
using FluxoCaixa.Application.ViewModel;
using FluxoCaixa.Domain.Entities;

namespace FluxoCaixa.Application.Mappings
{
    public class ViewModelToEntityProfile : Profile
    {
        public ViewModelToEntityProfile()
        {
            CreateMap<ActivityViewModel, Activity>();
        }
    }
}