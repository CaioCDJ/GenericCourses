global using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.FileProviders;
using GenericCourses.Infra;
using GenericCourses.Infra.Persistence;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.addInfra(builder.Configuration);

builder.Services.AddIdentity<LoginUser, IdentityRole>()
    .AddEntityFrameworkStores<AppDbContext>() 
    .AddDefaultTokenProviders();


builder.Services.AddRazorPages(options=>{
    options.Conventions.AuthorizeFolder("/Admin");
});
builder.Services.AddAuthentication().AddCookie(options=>{
    options.LoginPath = "/Login";
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseStaticFiles(
    new StaticFileOptions
    {
        FileProvider = new PhysicalFileProvider(
            Path.Combine(app.Environment.ContentRootPath, "node_modules")),
        RequestPath = "/node_modules"
    }
);

///- [] make an error page

app.UseStaticFiles();

app.UseHttpsRedirection();

app.UseRouting();

app.UseAuthorization();
app.UseAuthentication();

app.MapRazorPages();

app.Run();
