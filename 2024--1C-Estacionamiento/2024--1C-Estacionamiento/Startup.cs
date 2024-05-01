using _2024__1C_Estacionamiento.Models;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Identity;

namespace _2024__1C_Estacionamiento
{
    public class Startup
    {

        public static WebApplication InicializarApp(string[] args)
        {
            //Crear una nueva instancia de nuestro Servidor Web
            var builder = WebApplication.CreateBuilder(args);

            //Agrego Servicios. El contexot de base de datos le agrego el Database in memory. Expreciones Lambda

            //  builder.Services.AddDbContext<EstacionamientoContext>(options => options.UseInMemoryDatabase("EstacionamientoDb"));

            ////Agrego la base de datos SQL , y guardo el conection string en el appsetting.json
            //builder.Services.AddDbContext<EstacionamientoContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("EstacionamientoDBCS")));


            builder.Services.AddControllersWithViews();

            ConfigureServices(builder);//Lo configuramos con sus respectivos servicios

            var app = builder.Build();

            Configure(app);

            return app;

        }
        private static void ConfigureServices(WebApplicationBuilder builder)
        {

            builder.Services.AddControllersWithViews();
        }

        private static void Configure(WebApplication app)
        {

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            //Agrego autenticacion
            app.UseAuthentication();
            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");
        }

    }
}

