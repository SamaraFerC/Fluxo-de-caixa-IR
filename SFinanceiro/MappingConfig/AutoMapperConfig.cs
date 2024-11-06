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

            services.AddAutoMapper(typeof(EntityToViewModelProfile), typeof(ViewModelToEntityProfile));
        }
    }
}