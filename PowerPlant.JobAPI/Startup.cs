using Hangfire;
using Hangfire.SqlServer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using PowerPlant.Application.Service;
using PowerPlant.Core.Repository;
using PowerPlant.Core.Service;
using PowerPlant.RelationalRepository;
using PowerPlant.RelationalRepository.Mapping;
using PowerPlant.RelationalRepository.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace PowerPlant.JobAPI
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
            var assembly = Assembly.GetAssembly(typeof(WebIdDataMapping));
            var sessionFactory = new FluentNHibernateSessionFactoryBuilder().GetSessionFactory(connectionString, assembly);
            services.AddSingleton(sessionFactory);
            services.AddTransient(f => sessionFactory.OpenSession());

            #endregion

            #region Hangfire
            // Add Hangfire services.
            services.AddHangfire(configuration => configuration
                .SetDataCompatibilityLevel(CompatibilityLevel.Version_170)
                .UseSimpleAssemblyNameTypeSerializer()
                .UseRecommendedSerializerSettings()
                .UseSqlServerStorage(Configuration.GetConnectionString("DefaultConnection"), new SqlServerStorageOptions
                {
                    CommandBatchMaxTimeout = TimeSpan.FromMinutes(5),
                    SlidingInvisibilityTimeout = TimeSpan.FromMinutes(5),
                    QueuePollInterval = TimeSpan.Zero,
                    UseRecommendedIsolationLevel = true,
                    DisableGlobalLocks = true
                }));

            // Add the processing server as IHostedService
            services.AddHangfireServer();

            #endregion

            services.AddControllers();

            services.AddScoped<IWebDefinitionService, WebDefinitionService>();
            services.AddScoped<IWebDefinitionRepository, WebDefinitionRepository>();

            services.AddScoped<IWebIdDataService, WebIdDataService>();
            services.AddScoped<IWebIdDataRepository, WebIdDataRepository>();

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
