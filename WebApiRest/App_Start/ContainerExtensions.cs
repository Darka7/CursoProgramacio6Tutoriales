using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BD;
using WBL;
namespace WebApiRest
{
    public static class ContainerExtensions
    {

        public static IServiceCollection AddDIContainer(this IServiceCollection services)
        {

            services.AddSingleton<IDataAccess,DataAccess>();
            services.AddTransient<IUsuariosServices, UsuariosServices>();
            services.AddTransient<IClientesService, ClientesService>();
            services.AddTransient<IAgenciaService, AgenciaService>();
            services.AddTransient<IAlquilerService,AlquilerService>();
            services.AddTransient<IVehiculoService, VehiculoService>();
            return services;
        }
    }
}
