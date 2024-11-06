using FluxoCaixa.Application.Mappings;

namespace FluxoCaixa.SFinanceiro.MappingConfig
{
    public static class AutoMapperConfig
    {
        public static void AddAutoMapperConfig(this IServiceCollection services)
        {
            if(services == null)
            {
                throw new ArgumentNullException(nameof(services));
            }

            services.AddAutoMapperConfig(typeof(EntityToViewModelProfile), typeof(ViewModelToEntityProfile));
        }
    }
}
