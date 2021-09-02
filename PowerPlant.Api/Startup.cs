using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using PowerPlant.Application.Service;
using PowerPlant.Core.Repository;
using PowerPlant.Core.Service;
using PowerPlant.RelationalRepository;
using PowerPlant.RelationalRepository.Mapping;
using PowerPlant.RelationalRepository.Repository;
using System.Reflection;

namespace PowerPlant.Api
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            services.AddRouting();

            #region NHibernate 

            var connectionString = Configuration.GetConnectionString("DefaultConnection");
            var assembly = Assembly.GetAssembly(typeof(WebDefinitionMapping));
            var sessionFactory = new FluentNHibernateSessionFactoryBuilder().GetSessionFactory(connectionString, assembly);
            services.AddSingleton(sessionFactory);
            services.AddTransient(f => sessionFactory.OpenSession());

            #endregion


            services.AddControllers();

            services.AddScoped<IWebDefinitionRepository, WebDefinitionRepository>();
            services.AddScoped<IWebDefinitionService, WebDefinitionService>();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
