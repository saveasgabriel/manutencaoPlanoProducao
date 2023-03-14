using ManutencaoPlano.Data;
using ManutencaoPlano.Repositorio;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ManutencaoPlano
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
            services.AddControllersWithViews();
            services.AddEntityFrameworkNpgsql()
                .AddDbContext<planodiarioContext>(options => options.UseNpgsql(Configuration.GetConnectionString("DataBase")));
            
            services.AddScoped<IEntradaProducaoRepositorio, EntradaProducaoRepositorio>();
            
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "EntradaProducao",
                    pattern: "EntradaProducao/{tipo}/{unidade?}",
                    defaults: new { controller = "EntradaProducao", action = "Tabela"}
                    );

                endpoints.MapControllerRoute(
                    name: "TabelaParcial",
                    pattern: "EntradaProducao/TabelaParcial/{tipo}/{unidade?}",
                    defaults: new { controller = "EntradaProducao", action = "TabelaParcial" }
                    );


                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
