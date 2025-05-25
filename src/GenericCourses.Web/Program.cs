using GenericCourses.Web.Validations;
using GenericCourses.Infra;
using GenericCourses.Infra.Persistence;
using GenericCourses.Application;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authentication.Cookies;

var builder = WebApplication.CreateBuilder(args); {
	// Add services to the container.
	builder.Services.AddControllersWithViews();
	builder.Services.addInfra(builder.Configuration);
	builder.Services.addApplication();
	builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
	.AddCookie(options => {
		options.ExpireTimeSpan = TimeSpan.FromHours(3);// momentaneo
		options.SlidingExpiration = true;
		options.AccessDeniedPath = "/Forbidden/";
	});

	builder.Services.AddMvc();
	builder.Services.Validations();
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
	app.UseAuthentication();
	app.UseAuthorization();
	app.UseCookiePolicy(new CookiePolicyOptions {
		MinimumSameSitePolicy = SameSiteMode.Strict
	});
	app.MapControllers();

	app.Run();

}
