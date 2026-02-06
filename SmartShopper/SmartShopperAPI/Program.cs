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
            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            //SQL connection
            builder.Services.AddDbContext<SmartShopperContext>(o =>
                o.UseSqlServer(configuration.GetConnectionString("SqlDatabase")));


            builder.Services.AddDbContext<SmartShopperContext>(o => o.UseSqlServer(configuration.GetConnectionString("SqlDatabase")));
            builder.Services.AddScoped<IShoppingListRepository, ShoppingListRepository>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
