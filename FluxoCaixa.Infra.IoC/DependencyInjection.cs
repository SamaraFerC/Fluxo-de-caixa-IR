﻿using FluxoCaixa.Application.Interfaces;
using FluxoCaixa.Application.Mappings;
using FluxoCaixa.Application.Services;
using FluxoCaixa.Domain.Interfaces;
using FluxoCaixa.Infra.Data.Context;
using FluxoCaixa.Infra.Data.Repositories;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace FluxoCaixa.Infra.Ioc
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration) {

            services.AddDbContext<AppDbContext>(options =>
                            options.UseMySQL(connectionString: configuration.GetConnectionString("DefaultConnection")));

            services.Configure<IdentityOptions>(options => {
                options.Password.RequiredLength = 10;
                options.Password.RequiredUniqueChars = 3;
                options.Password.RequireNonAlphanumeric = false;
            });

            services.AddAutoMapper(typeof(EntityToViewModelProfile), typeof(ViewModelToEntityProfile));
            services.AddScoped<IActivityRepository, ActivityRepository>();
            services.AddScoped<IActivityService, ActivityService>();
            services.AddScoped<ICollaboratorRepository, CollaboratorRepository>();
            services.AddScoped<ICollaboratorService, CollaboratorService>();
            services.AddScoped<ICollaboratorTypeRepository, CollaboratorTypeRepository>();
            services.AddScoped<ICollaboratorTypeService, CollaboratorTypeService>();
            services.AddScoped<IPaymentTypeRepository, PaymentTypeRepository>();
            services.AddScoped<IPaymentTypeService, PaymentTypeService>();
            services.AddScoped<IAddressRepository, AddressRepository>();
            services.AddScoped<IAddressService, AddressService>();
            services.AddScoped<IFlowTypeRepository, FlowTypeRepository>();
            services.AddScoped<IFlowTypeService, FlowTypeService>();
            services.AddScoped<ICashFlowRepository, CashFlowRepository>();
            services.AddScoped<ICashFlowService, CashFlowService>();
            //services. AddIdentity<IdentityUser, IdentityRole>().AddEntityFrameworkStores<AppDbContext>();

            //services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
            //    .AddCookie(options =>
            //    {
            //        options.Cookie.Name = "AspNetCore.Cookie";
            //        options.ExpireTimeSpan = TimeSpan.FromMinutes(5);
            //        options.SlidingExpiration = true;
            //    });

            return services;
        }
    }
}
