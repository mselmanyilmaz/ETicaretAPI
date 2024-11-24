using Microsoft.EntityFrameworkCore;
using ETicaretAPI.Persistance.Contexts;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace ETicaretAPI.Persistance
{
    public static class ServiceRegistration
    {
        public static void AddPersitanceServices(this IServiceCollection services)
        {
            

            services.AddDbContext<ETicaretAPIDbContext>(options => options.UseNpgsql(Configuration.ConnectionString));
        }
    }
}
