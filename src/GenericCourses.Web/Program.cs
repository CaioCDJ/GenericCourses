using GenericCourses.Infra;
using GenericCourses.Infra.Persistence;
using GenericCourses.Application;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args); {
	// Add services to the container.
	builder.Services.AddControllersWithViews();

	builder.Services.addInfra(builder.Configuration);
	builder.Services.addApplication();
}

var app = builder.Build(); {

	// Configure the HTTP request pipeline.
	if (!app.Environment.IsDevelopment()) {
		app.UseExceptionHandler("/Home/Error");
		// The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
		app.UseHsts();

		app.Services.GetRequiredService<AppDbContext>().Database.Migrate();
	}

	app.UseHttpsRedirection();
	app.UseStaticFiles();

	app.UseRouting();

	app.UseAuthorization();

	app.MapControllers();

	app.Run();

}
