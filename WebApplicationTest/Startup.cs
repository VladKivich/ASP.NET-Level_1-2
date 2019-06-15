using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using WebApplicationTest.Interfaces;
using WebApplicationTest.Services;
using WebStore.DB;

namespace WebApplicationTest
{
    public class Startup
    {
        /// <summary>
        /// Свойство для доступа к конфигурации appsettings.json
        /// </summary>
        public IConfiguration Configuration { get;}

        public Startup(IConfiguration Configuration)
        {
            this.Configuration = Configuration;
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            //Добавялем зависимости
            services.AddSingleton<IAstronautsCollection, AstronautsServices>();
            services.AddScoped<IProductData, SQLProductData>();
            services.AddDbContext<WebStoreContext>(options => options.UseSqlServer(
            Configuration.GetConnectionString("DefaultConnection")));

            //Добавляем MVC сервисы
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseStaticFiles();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=HomePage}/{action=Index}/{id?}"
                    );
            });
        }
    }
}
