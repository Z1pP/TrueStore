using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Store.Interfeces;
using Store.Repository;
using Store.Data;
using Store.mocks;

namespace Store
{
    public class Startup
    {
        public IConfigurationRoot _confString;
        public Startup(Microsoft.AspNetCore.Hosting.IHostingEnvironment hostingEnv)
        {
            _confString = new ConfigurationBuilder().SetBasePath(hostingEnv.ContentRootPath).AddJsonFile("dbSettings.json").Build();
        }
        
        public void ConfigureServices(IServiceCollection services)
        {
            //Получаем строку подключени из файла конфигурации
            services.AddDbContext<DateBaseContent>(options => options.UseSqlServer(_confString.GetConnectionString("DefaultConnection")));

            services.AddMvc();
            services.AddTransient<IAllGames,MockGames>(); // Интерфейс IAllGames реализуется в классе GameRepository
            services.AddTransient<IGamesCategory, MockCategory>();
            services.AddRazorPages();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseStaticFiles();
            app.UseRouting();
            app.UseCors();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute("default", "{controller=Games}/{action=List}");
            });
        }
    }
}
