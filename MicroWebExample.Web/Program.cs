using Abp.AspNetCore;
using Abp.Dependency;
using Abp.ObjectMapping;
using Abp.Web.Configuration;
using Abp.Reflection.Extensions;
using MicroWebExample.Application;
using MicroWebExample.Application.Mapping;
using MicroWebExample.Infrastructure;
using MicroWebExample.Persistence;
using MicroWebExample.Persistence.Repositories.AppServices;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);
var services = builder.Services;
var configuration = builder.Configuration;
// Add services to the container.
services.AddControllersWithViews();
services.AddInfrastructureServices();
services.AddApplicationService();
services.AddPersistenceServices(configuration);
services.AddMvc();


var app = builder.Build();

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

app.UseAuthorization();

app.MapControllerRoute(
	name: "default",
	pattern: "{controller=Default}/{action=Index}/{id?}");

app.Run();
