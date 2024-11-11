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
            CreateMap<AddressViewModel, Address>();
            CreateMap<CashFlowViewModel, CashFlow>();
            CreateMap<CollaboratorViewModel, Collaborator>();
            CreateMap<CollaboratorTypeViewModel, CollaboratorTypes>();
            CreateMap<FlowTypeViewModel, FlowType>();
            CreateMap<PaymentTypeViewModel, PaymentType>();
        }
    }
}