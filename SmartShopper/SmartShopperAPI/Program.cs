using Microsoft.EntityFrameworkCore;
using SmartShopperDomain.Repository;
using SmartShopperInfrastructure;
using SmartShopperInfrastructure.Repository;

namespace SmartShopperAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            var configuration = builder.Configuration;

            builder.Services.AddControllers();
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            // CORS dla Blazor UI
            builder.Services.AddCors(options =>
            {
                options.AddPolicy("BlazorUI", policy =>
                {
                    policy.WithOrigins("https://localhost:7267") // Poprawny port Blazor UI
                          .AllowAnyHeader()
                          .AllowAnyMethod();
                });
            });

            builder.Services.AddDbContext<SmartShopperContext>(o =>
                o.UseSqlServer(configuration.GetConnectionString("SqlDatabase")));
            builder.Services.AddScoped<IShoppingListRepository, ShoppingListRepository>();

            var app = builder.Build();

            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();
            app.UseCors("BlazorUI");
            app.UseAuthorization();
            app.MapControllers();

            app.Run();
        }
    }
}
