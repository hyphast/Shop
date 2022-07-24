using System;
using Shop.App_Data.Interfaces;
using Shop.App_Data.mocks;

namespace Shop
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddMvc();
            builder.Services.AddTransient<ICars, MockCars>();
            builder.Services.AddTransient<ICarCategories, MockCarCategories>();
            builder.Services.AddMvc(option => option.EnableEndpointRouting = false);
            var app = builder.Build();

            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
                app.UseHsts();
            }

            //app.MapGet("/", () => "Hello World!");

            app.UseDeveloperExceptionPage();
            app.UseStatusCodePages();
            app.UseStaticFiles();
            app.UseMvcWithDefaultRoute();

            app.Run();
        }
    }
}