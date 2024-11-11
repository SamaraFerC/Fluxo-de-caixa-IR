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
            CreateMap<Address, AddressViewModel>();
            CreateMap<CashFlow, CashFlowViewModel>();
            CreateMap<Collaborator, CollaboratorViewModel>();
            CreateMap<CollaboratorTypes, CollaboratorTypeViewModel>();
            CreateMap<FlowType, FlowTypeViewModel>();
            CreateMap<PaymentType, PaymentTypeViewModel>();
        }
    }
}